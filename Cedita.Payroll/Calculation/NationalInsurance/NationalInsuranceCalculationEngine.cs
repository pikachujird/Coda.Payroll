// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Abstractions;
using Cedita.Payroll.Configuration;
using System;
using System.Collections.Generic;

namespace Cedita.Payroll.Calculation.NationalInsurance
{
    public abstract class NationalInsuranceCalculationEngine : INiCalculationEngine
    {
        protected readonly TaxYearConfigurationData TaxYearConfigurationData;

        protected readonly Dictionary<PayPeriods, LimitThresholds> LimitThresholdCache = new();

        public NationalInsuranceCalculationEngine(TaxYearConfigurationData taxYearConfigurationData)
        {
            this.TaxYearConfigurationData = taxYearConfigurationData;
        }

        public abstract NationalInsuranceCalculation CalculateNationalInsurance(decimal gross, char niCategory, PayPeriods payPeriods);

        protected virtual decimal SubtractRound(decimal gross, decimal limit, decimal subtract)
        {
            var subtractFrom = TaxMath.Smallest(gross, limit);
            var subtracted = subtractFrom - subtract;
            subtracted = Math.Round(subtracted, 2, MidpointRounding.AwayFromZero);
            return TaxMath.PositiveOnly(subtracted);
        }

        protected virtual LimitThresholds GetLimitThresholdsForPeriods(PayPeriods payPeriods)
        {
            if (LimitThresholdCache.ContainsKey(payPeriods))
            {
                return LimitThresholdCache[payPeriods];
            }

            var limitThresholds = CalculateLimitThresholdsForPeriods(payPeriods);
            
            LimitThresholdCache.Add(payPeriods, limitThresholds);

            return limitThresholds;
        }
        
        protected abstract LimitThresholds CalculateLimitThresholdsForPeriods(PayPeriods payPeriods);

        protected record LimitThresholds
        {
            public decimal PrimaryThreshold { get; init; }
            public decimal SecondaryThreshold { get; init; }
            public decimal UpperAccrualPoint { get; init; }
            public decimal UpperEarningsLimit { get; init; }
            public decimal LowerEarningsLimit { get; init; }
        }
    }
}
