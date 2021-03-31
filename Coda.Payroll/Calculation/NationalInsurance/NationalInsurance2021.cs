// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Coda.Payroll.Configuration;
using System;

namespace Coda.Payroll.Calculation.NationalInsurance
{
    [CalculationEngineTaxYear(TaxYear = 2021)]
    public class NationalInsurance2021 : NationalInsurance2020
    {
        public NationalInsurance2021(TaxYearConfigurationData taxYearConfigurationData) : base(taxYearConfigurationData)
        {
        }

        protected override LimitThresholds CalculateLimitThresholdsForPeriods(PayPeriods payPeriods)
        {
            var factoring = TaxMath.GetFactoring(payPeriods);
            int periods = factoring.Periods,
                weeksInPeriod = factoring.WeeksInPeriod;

            // WTF. Of course, changed again, just for fun.
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
