// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Coda.Payroll.Configuration;
using System;

namespace Coda.Payroll.Calculation.NationalInsurance
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
            var niRates = TaxYearConfigurationData.NiRates[niCategory];

            // 'X' NI Code does not pay NI contributions
            if (niCategory == 'X')
            {
                gross = 0m;
            }

            var limitThresholds = GetLimitThresholdsForPeriods(payPeriods);
            
            var niCalc = new NationalInsuranceCalculation
            {
                EarningsUptoIncludingLEL = SubtractRound(gross, limitThresholds.LowerEarningsLimit, 0),
                EarningsAboveLELUptoIncludingPT = SubtractRound(gross, limitThresholds.PrimaryThreshold, limitThresholds.LowerEarningsLimit),
                EarningsAboveUEL = SubtractRound(gross, gross, limitThresholds.UpperEarningsLimit),
                EarningsAboveSTUpToIncludingPT = SubtractRound(gross, limitThresholds.PrimaryThreshold, limitThresholds.SecondaryThreshold),
                EarningsAbovePTUptoIncludingUEL = SubtractRound(gross, limitThresholds.UpperEarningsLimit, limitThresholds.PrimaryThreshold),
            };

            niCalc.EmployeeNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveSTUpToIncludingPT * (niRates.EeC / 100));
            niCalc.EmployeeNiGross += TaxMath.HmrcRound(niCalc.EarningsAbovePTUptoIncludingUEL * (niRates.EeD / 100));
            niCalc.EmployeeNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveUEL * (niRates.EeE / 100));

            niCalc.EmployerNiGross += TaxMath.HmrcRound((niCalc.EarningsAboveSTUpToIncludingPT + niCalc.EarningsAbovePTUptoIncludingUEL) * (niRates.ErD / 100));
            niCalc.EmployerNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveUEL * (niRates.ErE / 100));

            return niCalc;
        }
        
        protected override LimitThresholds CalculateLimitThresholdsForPeriods(PayPeriods payPeriods)
        {
            var factoring = TaxMath.GetFactoring(payPeriods);
            int periods = factoring.Periods,
                weeksInPeriod = factoring.WeeksInPeriod;

            // WTF. HMRC changed their rounding rules AGAIN in 2020. PeriodRound for the ST too.
            return new LimitThresholds
            {
                PrimaryThreshold = TaxMath.PeriodRound(TaxMath.Factor(TaxYearConfigurationData.PrimaryThreshold, weeksInPeriod, periods), weeksInPeriod),
                SecondaryThreshold = TaxMath.PeriodRound(TaxMath.Factor(TaxYearConfigurationData.SecondaryThreshold, weeksInPeriod, periods), weeksInPeriod),
                UpperEarningsLimit = Math.Ceiling(TaxMath.Factor(TaxYearConfigurationData.UpperEarningsLimit, weeksInPeriod, periods)),
                LowerEarningsLimit = Math.Ceiling(TaxMath.Factor(TaxYearConfigurationData.LowerEarningsLimit, weeksInPeriod, periods)),
            };
        }
    }
}
