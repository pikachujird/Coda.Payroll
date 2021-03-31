// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Coda.Payroll.Abstractions;
using Coda.Payroll.Configuration;
using System;

namespace Coda.Payroll.Calculation.NationalInsurance
{
    [CalculationEngineTaxYear(TaxYear = 2014)]
    public class NationalInsurance2014 : NationalInsuranceCalculationEngine
    {
        public NationalInsurance2014(TaxYearConfigurationData taxYearConfigurationData) : base(taxYearConfigurationData)
        {
        }

        public override NationalInsuranceCalculation CalculateNationalInsurance(decimal gross, char niCategory, PayPeriods payPeriods)
        {
            var niRates = TaxYearConfigurationData.NiRates[niCategory];
            var limitThresholds = GetLimitThresholdsForPeriods(payPeriods);

#pragma warning disable IDE0017 // Simplify object initialization
            var niCalc = new NationalInsuranceCalculation();
#pragma warning restore IDE0017 // Simplify object initialization
            // Employee NI Gross
            niCalc.EmployeeNiGross = TaxMath.HmrcRound(SubtractRound(gross, limitThresholds.UpperAccrualPoint, limitThresholds.PrimaryThreshold) * (niRates.EeD / 100));
            niCalc.EmployeeNiGross += TaxMath.HmrcRound(SubtractRound(gross, limitThresholds.UpperEarningsLimit, limitThresholds.UpperAccrualPoint) * (niRates.EeE / 100));
            niCalc.EmployeeNiGross += TaxMath.HmrcRound(SubtractRound(gross, gross, limitThresholds.UpperEarningsLimit) * (niRates.EeF / 100));

            niCalc.EmployeeNiRebate = TaxMath.HmrcRound(SubtractRound(gross, limitThresholds.SecondaryThreshold, limitThresholds.LowerEarningsLimit) * (niRates.EeB / 100));
            niCalc.EmployeeNiRebate += TaxMath.HmrcRound(SubtractRound(gross, limitThresholds.PrimaryThreshold, limitThresholds.SecondaryThreshold) * (niRates.EeC / 100));

            // Employer NI Gross
            niCalc.EmployerNiGross = TaxMath.HmrcRound(SubtractRound(gross, limitThresholds.PrimaryThreshold, limitThresholds.SecondaryThreshold) * (niRates.ErC / 100));
            niCalc.EmployerNiGross += TaxMath.HmrcRound(SubtractRound(gross, limitThresholds.UpperAccrualPoint, limitThresholds.PrimaryThreshold) * (niRates.ErD / 100));
            niCalc.EmployerNiGross += TaxMath.HmrcRound(SubtractRound(gross, limitThresholds.UpperEarningsLimit, limitThresholds.UpperAccrualPoint) * (niRates.ErE / 100));
            niCalc.EmployerNiGross += TaxMath.HmrcRound(SubtractRound(gross, gross, limitThresholds.UpperEarningsLimit) * (niRates.ErF / 100));

            niCalc.EmployerNiRebate = TaxMath.HmrcRound(SubtractRound(gross, limitThresholds.SecondaryThreshold, limitThresholds.LowerEarningsLimit) * (niRates.ErB / 100));

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
                UpperAccrualPoint = TaxMath.PeriodRound(TaxMath.Factor(TaxYearConfigurationData.UpperAccrualPoint, weeksInPeriod, periods), weeksInPeriod),
                UpperEarningsLimit = TaxMath.PeriodRound(TaxMath.Factor(TaxYearConfigurationData.UpperEarningsLimit, weeksInPeriod, periods), weeksInPeriod),
                LowerEarningsLimit = TaxMath.PeriodRound(TaxMath.Factor(TaxYearConfigurationData.LowerEarningsLimit, weeksInPeriod, periods), weeksInPeriod),
            };
        }
    }
}
