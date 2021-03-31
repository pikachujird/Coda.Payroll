// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.

using Coda.Payroll.Abstractions;
using Coda.Payroll.Configuration;
using System;

namespace Coda.Payroll.Calculation.NationalInsurance
{
    [CalculationEngineTaxYear(TaxYear = 2015)]
    public class NationalInsurance2015 : NationalInsuranceCalculationEngine
    {
        public NationalInsurance2015(TaxYearConfigurationData taxYearConfigurationData) : base(taxYearConfigurationData)
        {
        }

        public override NationalInsuranceCalculation CalculateNationalInsurance(decimal gross, char niCategory, PayPeriods payPeriods)
        {
            var niRates = TaxYearConfigurationData.NiRates[niCategory];

            var niCalc = new NationalInsuranceCalculation();
            var limitThresholds = GetLimitThresholdsForPeriods(payPeriods);

            // Employee NI Gross
            var lelToPt = SubtractRound(gross, limitThresholds.PrimaryThreshold, limitThresholds.LowerEarningsLimit);
            var ptToSt = SubtractRound(gross, limitThresholds.SecondaryThreshold, limitThresholds.PrimaryThreshold);
            var stToUap = SubtractRound(gross, limitThresholds.UpperAccrualPoint, limitThresholds.SecondaryThreshold);
            var uapToUel = SubtractRound(gross, limitThresholds.UpperEarningsLimit, limitThresholds.UpperAccrualPoint);
            var aboveUel = SubtractRound(gross, gross, limitThresholds.UpperEarningsLimit);

            niCalc.EmployeeNiGross = TaxMath.HmrcRound(ptToSt * (niRates.EeC / 100));
            niCalc.EmployeeNiGross += TaxMath.HmrcRound(stToUap * (niRates.EeD / 100));
            niCalc.EmployeeNiGross += TaxMath.HmrcRound(uapToUel * (niRates.EeE / 100));
            niCalc.EmployeeNiGross += TaxMath.HmrcRound(aboveUel * (niRates.EeF / 100));

            niCalc.EmployeeNiRebate = TaxMath.HmrcRound(lelToPt * (niRates.EeB / 100));

            // Employer NI Gross
            //niCalc.EmployerNiGross = TaxMath.HmrcRound(ptToSt * (niRates.ErC / 100));
            if (!(niCategory == 'I' || niCategory == 'K' || niCategory == 'V'))
                niCalc.EmployerNiGross += TaxMath.HmrcRound(stToUap * (niRates.ErD / 100));
            niCalc.EmployerNiGross += TaxMath.HmrcRound(uapToUel * (niRates.ErE / 100));
            niCalc.EmployerNiGross += TaxMath.HmrcRound(aboveUel * (niRates.ErF / 100));

            niCalc.EmployerNiRebate = TaxMath.HmrcRound(lelToPt * (niRates.ErB / 100));
            niCalc.EmployerNiRebate += TaxMath.HmrcRound(ptToSt * (niRates.ErC / 100));
            if ((niCategory == 'I' || niCategory == 'K' || niCategory == 'V'))
                niCalc.EmployerNiRebate += TaxMath.HmrcRound(stToUap * (niRates.ErD / 100));

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
                LowerEarningsLimit = Math.Ceiling(TaxMath.Factor(TaxYearConfigurationData.LowerEarningsLimit, weeksInPeriod, periods)),
            };
        }
    }
}
