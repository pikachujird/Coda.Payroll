// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.

using Cedita.Payroll.Abstractions;
using Cedita.Payroll.Configuration;
using System;

namespace Cedita.Payroll.Calculation.NationalInsurance
{
    [CalculationEngineTaxYear(TaxYear = 2015)]
    public class NationalInsurance2015 : NationalInsuranceCalculationEngine
    {
        public NationalInsurance2015(TaxYearConfigurationData taxYearConfigurationData) : base(taxYearConfigurationData)
        {
        }

        public override NationalInsuranceCalculation CalculateNationalInsurance(decimal gross, char niCategory, PayPeriods payPeriods)
        {
            var totalPT = taxYearConfigurationData.PrimaryThreshold;
            var totalST = taxYearConfigurationData.SecondaryThreshold;
            var totalUAP = taxYearConfigurationData.UpperAccrualPoint;
            var totalUEL = taxYearConfigurationData.UpperEarningsLimit;
            var totalLEL = taxYearConfigurationData.LowerEarningsLimit;
            var niRates = taxYearConfigurationData.NiRates[niCategory];

            var factoring = TaxMath.GetFactoring(payPeriods);
            int periods = factoring.Periods,
                weeksInPeriod = factoring.WeeksInPeriod;
            decimal periodPT = TaxMath.PeriodRound(TaxMath.Factor(totalPT, weeksInPeriod, periods), weeksInPeriod),
                periodST = TaxMath.PeriodRound(TaxMath.Factor(totalST, weeksInPeriod, periods), weeksInPeriod),
                periodUAP = TaxMath.PeriodRound(TaxMath.Factor(totalUAP, weeksInPeriod, periods), weeksInPeriod),
                periodUEL = TaxMath.PeriodRound(TaxMath.Factor(totalUEL, weeksInPeriod, periods), weeksInPeriod),
                periodLEL = Math.Ceiling(TaxMath.Factor(totalLEL, weeksInPeriod, periods));

            var niCalc = new NationalInsuranceCalculation();

            // Employee NI Gross
            var lelToPt = SubtractRound(gross, periodPT, periodLEL);
            var ptToSt = SubtractRound(gross, periodST, periodPT);
            var stToUap = SubtractRound(gross, periodUAP, periodST);
            var uapToUel = SubtractRound(gross, periodUEL, periodUAP);
            var aboveUel = SubtractRound(gross, gross, periodUEL);

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
    }
}
