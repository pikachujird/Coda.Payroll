// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Configuration;
using System;

namespace Cedita.Payroll.Calculation.NationalInsurance
{
    [CalculationEngineTaxYear(TaxYear = 2016)]
    public class NationalInsurance2016 : NationalInsurance2014
    {
        public NationalInsurance2016(TaxYearConfigurationData taxYearConfigurationData) : base(taxYearConfigurationData)
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
            decimal periodPT = TaxMath.PeriodRound(TaxMath.Factor(totalPT, weeksInPeriod, periods), weeksInPeriod),
                periodST = TaxMath.PeriodRound(TaxMath.Factor(totalST, weeksInPeriod, periods), weeksInPeriod),
                periodUEL = TaxMath.PeriodRound(TaxMath.Factor(totalUEL, weeksInPeriod, periods), weeksInPeriod),
                periodLEL = Math.Ceiling(TaxMath.Factor(totalLEL, weeksInPeriod, periods));

            var niCalc = new NationalInsuranceCalculation
            {
                EarningsUptoIncludingLEL = SubtractRound(gross, periodLEL, 0),
                EarningsAboveLELUptoIncludingPT = SubtractRound(gross, periodPT, periodLEL),
                EarningsAbovePTUptoIncludingST = SubtractRound(gross, periodST, periodPT),
                EarningsAboveSTUptoIncludingUEL = SubtractRound(gross, periodUEL, periodST),
                EarningsAboveUEL = SubtractRound(gross, gross, periodUEL)
            };

            niCalc.EmployeeNiGross += TaxMath.HmrcRound(niCalc.EarningsAbovePTUptoIncludingST * (niRates.EeC / 100));
            niCalc.EmployeeNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveSTUptoIncludingUEL * (niRates.EeD / 100));
            niCalc.EmployeeNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveUEL * (niRates.EeE / 100));

            niCalc.EmployerNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveSTUptoIncludingUEL * (niRates.ErD / 100));
            niCalc.EmployerNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveUEL * (niRates.ErE / 100));

            return niCalc;
        }
    }
}
