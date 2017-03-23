// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.

using Cedita.Payroll.Models.TaxYearSpecifics;
using System;

namespace Cedita.Payroll.Engines.NationalInsurance
{
    [EngineApplicableTaxYear(TaxYearStartYear = 2015)]
    public class NationalInsurance2015 : NationalInsuranceCalculationEngine
    {
        public override NationalInsuranceCalculation CalculateNationalInsurance(decimal gross, char niCategory, PayPeriods periods)
        {
            var totalPT = TaxYearSpecificProvider.GetSpecificValue<decimal>(TaxYearSpecificValues.PrimaryThreshold);
            var totalST = TaxYearSpecificProvider.GetSpecificValue<decimal>(TaxYearSpecificValues.SecondaryThreshold);
            var totalUAP = TaxYearSpecificProvider.GetSpecificValue<decimal>(TaxYearSpecificValues.UpperAccrualPoint);
            var totalUEL = TaxYearSpecificProvider.GetSpecificValue<decimal>(TaxYearSpecificValues.UpperEarningsLimit);
            var totalLEL = TaxYearSpecificProvider.GetSpecificValue<decimal>(TaxYearSpecificValues.LowerEarningsLimit);
            var niRates = TaxYearSpecificProvider.GetCodeSpecifics(niCategory);

            var factoring = TaxMath.GetFactoring(periods);
            decimal periodPT = TaxMath.PeriodRound(TaxMath.Factor(totalPT, factoring.WeeksInPeriod, factoring.Periods), factoring.WeeksInPeriod),
                periodST = TaxMath.PeriodRound(TaxMath.Factor(totalST, factoring.WeeksInPeriod, factoring.Periods), factoring.WeeksInPeriod),
                periodUAP = TaxMath.PeriodRound(TaxMath.Factor(totalUAP, factoring.WeeksInPeriod, factoring.Periods), factoring.WeeksInPeriod),
                periodUEL = TaxMath.PeriodRound(TaxMath.Factor(totalUEL, factoring.WeeksInPeriod, factoring.Periods), factoring.WeeksInPeriod),
                periodLEL = Math.Ceiling(TaxMath.Factor(totalLEL, factoring.WeeksInPeriod, factoring.Periods));

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
