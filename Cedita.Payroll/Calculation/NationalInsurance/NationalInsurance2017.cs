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
                EarningsAboveSTUptoIncludingUEL = SubtractRound(gross, limitThresholds.UpperEarningsLimit, limitThresholds.PrimaryThreshold),
                EarningsAboveUEL = SubtractRound(gross, gross, limitThresholds.UpperEarningsLimit)
            };

            niCalc.EmployeeNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveSTUptoIncludingUEL * (niRates.EeC / 100));
            niCalc.EmployeeNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveUEL * (niRates.EeD / 100));

            niCalc.EmployerNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveSTUptoIncludingUEL * (niRates.ErC / 100));
            niCalc.EmployerNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveUEL * (niRates.ErD / 100));

            return niCalc;
        }
        
        protected override LimitThresholds CalculateLimitThresholdsForPeriods(PayPeriods payPeriods)
        {
            var factoring = TaxMath.GetFactoring(payPeriods);
            int periods = factoring.Periods,
                weeksInPeriod = factoring.WeeksInPeriod;

            // WTF. UEL must round 865.3846 to 866. But PT must round 680.3333 to 680. This isn't sane.
            return new LimitThresholds
            {
                PrimaryThreshold = TaxMath.PeriodRound(TaxMath.Factor(TaxYearConfigurationData.PrimaryThreshold, weeksInPeriod, periods), weeksInPeriod),
                UpperEarningsLimit = Math.Ceiling(TaxMath.Factor(TaxYearConfigurationData.UpperEarningsLimit, weeksInPeriod, periods)),
                LowerEarningsLimit = Math.Ceiling(TaxMath.Factor(TaxYearConfigurationData.LowerEarningsLimit, weeksInPeriod, periods)),
            };
        }
    }
}
