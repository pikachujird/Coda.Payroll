// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Configuration;
using System;

namespace Cedita.Payroll.Calculation.NationalInsurance
{
    [CalculationEngineTaxYear(TaxYear = 2017)]
    [CalculationEngineTaxYear(TaxYear = 2018)]
    [CalculationEngineTaxYear(TaxYear = 2019)]
    public class NationalInsurance2017 : NationalInsurance2016
    {
        public NationalInsurance2017(TaxYearConfigurationData taxYearConfigurationData) : base(taxYearConfigurationData)
        {
        }

        public override NationalInsuranceCalculation CalculateNationalInsurance(decimal gross, char niCategory, PayPeriods payPeriods)
        {
            var totalPT = taxYearConfigurationData.PrimaryThreshold;
            var totalST = taxYearConfigurationData.SecondaryThreshold;
            var totalUEL = taxYearConfigurationData.UpperEarningsLimit;
            var totalLEL = taxYearConfigurationData.LowerEarningsLimit;
            var totalUST = taxYearConfigurationData.UpperSecondaryThreshold;
            var totalAUST = taxYearConfigurationData.ApprenticeUpperSecondaryThreshold;
            var niRates = taxYearConfigurationData.NiRates[niCategory];

            var factoring = TaxMath.GetFactoring(payPeriods);
            int periods = factoring.Periods,
                weeksInPeriod = factoring.WeeksInPeriod;

            // 'X' NI Code does not pay NI contributions
            if (niCategory == 'X')
            {
                gross = 0m;
            }
            
            // WTF. UEL must round 865.3846 to 866. But PT must round 680.3333 to 680. This isn't sane.
            decimal periodPT = TaxMath.PeriodRound(TaxMath.Factor(totalPT, weeksInPeriod, periods), weeksInPeriod),
                periodUEL = Math.Ceiling(TaxMath.Factor(totalUEL, weeksInPeriod, periods)),
                periodLEL = Math.Ceiling(TaxMath.Factor(totalLEL, weeksInPeriod, periods));

            var niCalc = new NationalInsuranceCalculation
            {
                EarningsUptoIncludingLEL = SubtractRound(gross, periodLEL, 0),
                EarningsAboveLELUptoIncludingPT = SubtractRound(gross, periodPT, periodLEL),
                EarningsAboveSTUptoIncludingUEL = SubtractRound(gross, periodUEL, periodPT),
                EarningsAboveUEL = SubtractRound(gross, gross, periodUEL)
            };

            niCalc.EmployeeNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveSTUptoIncludingUEL * (niRates.EeC / 100));
            niCalc.EmployeeNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveUEL * (niRates.EeD / 100));

            niCalc.EmployerNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveSTUptoIncludingUEL * (niRates.ErC / 100));
            niCalc.EmployerNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveUEL * (niRates.ErD / 100));

            return niCalc;
        }
    }
}
