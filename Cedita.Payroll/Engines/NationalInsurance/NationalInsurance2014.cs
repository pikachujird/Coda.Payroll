// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Models.TaxYearSpecifics;
using System;

namespace Cedita.Payroll.Engines.NationalInsurance
{
    [EngineApplicableTaxYear(TaxYearStartYear = 2014)]
    public class NationalInsurance2014 : NationalInsuranceCalculationEngine
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
                periodLEL = TaxMath.PeriodRound(TaxMath.Factor(totalLEL, factoring.WeeksInPeriod, factoring.Periods), factoring.WeeksInPeriod);

#pragma warning disable IDE0017 // Simplify object initialization
            var niCalc = new NationalInsuranceCalculation();
#pragma warning restore IDE0017 // Simplify object initialization
                               // Employee NI Gross
            niCalc.EmployeeNiGross = TaxMath.HmrcRound(SubtractRound(gross, periodUAP, periodPT) * (niRates.EeD / 100));
            niCalc.EmployeeNiGross += TaxMath.HmrcRound(SubtractRound(gross, periodUEL, periodUAP) * (niRates.EeE / 100));
            niCalc.EmployeeNiGross += TaxMath.HmrcRound(SubtractRound(gross, gross, periodUEL) * (niRates.EeF / 100));

            niCalc.EmployeeNiRebate = TaxMath.HmrcRound(SubtractRound(gross, periodST, periodLEL) * (niRates.EeB / 100));
            niCalc.EmployeeNiRebate += TaxMath.HmrcRound(SubtractRound(gross, periodPT, periodST) * (niRates.EeC / 100));

            // Employer NI Gross
            niCalc.EmployerNiGross = TaxMath.HmrcRound(SubtractRound(gross, periodPT, periodST) * (niRates.ErC / 100));
            niCalc.EmployerNiGross += TaxMath.HmrcRound(SubtractRound(gross, periodUAP, periodPT) * (niRates.ErD / 100));
            niCalc.EmployerNiGross += TaxMath.HmrcRound(SubtractRound(gross, periodUEL, periodUAP) * (niRates.ErE / 100));
            niCalc.EmployerNiGross += TaxMath.HmrcRound(SubtractRound(gross, gross, periodUEL) * (niRates.ErF / 100));

            niCalc.EmployerNiRebate = TaxMath.HmrcRound(SubtractRound(gross, periodST, periodLEL) * (niRates.ErB / 100));

            return niCalc;
        }
    }
}
