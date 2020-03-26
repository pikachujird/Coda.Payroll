// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Configuration;
using System;

namespace Cedita.Payroll.Calculation.NationalInsurance
{
    [CalculationEngineTaxYear(TaxYear = 2020)]
    public class NationalInsurance2020 : NationalInsurance2017
    {
        public NationalInsurance2020(TaxYearConfigurationData taxYearConfigurationData) : base(taxYearConfigurationData)
        {
        }

        public override NationalInsuranceCalculation CalculateNationalInsurance(decimal gross, char niCategory, PayPeriods payPeriods)
        {
            // The ST is back! But lower than PT.
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
            
            // WTF. HMRC changed their rounding rules AGAIN in 2020. PeriodRound for the ST too.
            decimal periodPT = TaxMath.PeriodRound(TaxMath.Factor(totalPT, weeksInPeriod, periods), weeksInPeriod),
                periodST = TaxMath.PeriodRound(TaxMath.Factor(totalST, weeksInPeriod, periods), weeksInPeriod),
                periodUEL = Math.Ceiling(TaxMath.Factor(totalUEL, weeksInPeriod, periods)),
                periodLEL = Math.Ceiling(TaxMath.Factor(totalLEL, weeksInPeriod, periods));

            var niCalc = new NationalInsuranceCalculation
            {
                EarningsUptoIncludingLEL = SubtractRound(gross, periodLEL, 0),
                EarningsAboveLELUptoIncludingPT = SubtractRound(gross, periodPT, periodLEL),
                EarningsAboveUEL = SubtractRound(gross, gross, periodUEL),
                EarningsAboveSTUpToIncludingPT = SubtractRound(gross, periodPT, periodST),
                EarningsAbovePTUptoIncludingUEL = SubtractRound(gross, periodUEL, periodPT),
            };

            niCalc.EmployeeNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveSTUpToIncludingPT * (niRates.EeC / 100));
            niCalc.EmployeeNiGross += TaxMath.HmrcRound(niCalc.EarningsAbovePTUptoIncludingUEL * (niRates.EeD / 100));
            niCalc.EmployeeNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveUEL * (niRates.EeE / 100));

            niCalc.EmployerNiGross += TaxMath.HmrcRound((niCalc.EarningsAboveSTUpToIncludingPT + niCalc.EarningsAbovePTUptoIncludingUEL) * (niRates.ErD / 100));
            niCalc.EmployerNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveUEL * (niRates.ErE / 100));

            return niCalc;
        }
    }
}
