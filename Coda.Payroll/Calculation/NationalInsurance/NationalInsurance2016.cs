// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Coda.Payroll.Configuration;
using System;

namespace Coda.Payroll.Calculation.NationalInsurance
{
    [CalculationEngineTaxYear(TaxYear = 2016)]
    public class NationalInsurance2016 : NationalInsurance2014
    {
        public NationalInsurance2016(TaxYearConfigurationData taxYearConfigurationData) : base(taxYearConfigurationData)
        {
        }

        public override NationalInsuranceCalculation CalculateNationalInsurance(decimal gross, char niCategory, PayPeriods payPeriods)
        {
            var niRates = TaxYearConfigurationData.NiRates[niCategory];

            var limitThresholds = GetLimitThresholdsForPeriods(payPeriods);
            
            var niCalc = new NationalInsuranceCalculation
            {
                EarningsUptoIncludingLEL = SubtractRound(gross, limitThresholds.LowerEarningsLimit, 0),
                EarningsAboveLELUptoIncludingPT = SubtractRound(gross, limitThresholds.PrimaryThreshold, limitThresholds.LowerEarningsLimit),
                EarningsAbovePTUptoIncludingST = SubtractRound(gross, limitThresholds.SecondaryThreshold, limitThresholds.PrimaryThreshold),
                EarningsAboveSTUptoIncludingUEL = SubtractRound(gross, limitThresholds.UpperEarningsLimit, limitThresholds.SecondaryThreshold),
                EarningsAboveUEL = SubtractRound(gross, gross, limitThresholds.UpperEarningsLimit)
            };

            niCalc.EmployeeNiGross += TaxMath.HmrcRound(niCalc.EarningsAbovePTUptoIncludingST * (niRates.EeC / 100));
            niCalc.EmployeeNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveSTUptoIncludingUEL * (niRates.EeD / 100));
            niCalc.EmployeeNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveUEL * (niRates.EeE / 100));

            niCalc.EmployerNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveSTUptoIncludingUEL * (niRates.ErD / 100));
            niCalc.EmployerNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveUEL * (niRates.ErE / 100));

            return niCalc;
        }
        
        protected override LimitThresholds CalculateLimitThresholdsForPeriods(PayPeriods payPeriods)
        {
            var factoring = TaxMath.GetFactoring(payPeriods);
            int periods = factoring.Periods,
                weeksInPeriod = factoring.WeeksInPeriod;

            return new LimitThresholds
            {
                PrimaryThreshold = TaxMath.PeriodRound(TaxMath.Factor(TaxYearConfigurationData.PrimaryThreshold, weeksInPeriod, periods), weeksInPeriod),
                SecondaryThreshold = TaxMath.PeriodRound(TaxMath.Factor(TaxYearConfigurationData.SecondaryThreshold, weeksInPeriod, periods), weeksInPeriod),
                UpperEarningsLimit = TaxMath.PeriodRound(TaxMath.Factor(TaxYearConfigurationData.UpperEarningsLimit, weeksInPeriod, periods), weeksInPeriod),
                LowerEarningsLimit = Math.Ceiling(TaxMath.Factor(TaxYearConfigurationData.LowerEarningsLimit, weeksInPeriod, periods)),
            };
        }
    }
}
