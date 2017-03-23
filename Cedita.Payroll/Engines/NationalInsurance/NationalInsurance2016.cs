// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Models.TaxYearSpecifics;
using System;

namespace Cedita.Payroll.Engines.NationalInsurance
{
    [EngineApplicableTaxYear(TaxYearStartYear = 2016)]
    public class NationalInsurance2016 : NationalInsurance2014
    {
        public override NationalInsuranceCalculation CalculateNationalInsurance(decimal gross, char niCategory, PayPeriods periods)
        {
            var totalPT = TaxYearSpecificProvider.GetSpecificValue<decimal>(TaxYearSpecificValues.PrimaryThreshold);
            var totalST = TaxYearSpecificProvider.GetSpecificValue<decimal>(TaxYearSpecificValues.SecondaryThreshold);
            var totalUEL = TaxYearSpecificProvider.GetSpecificValue<decimal>(TaxYearSpecificValues.UpperEarningsLimit);
            var totalLEL = TaxYearSpecificProvider.GetSpecificValue<decimal>(TaxYearSpecificValues.LowerEarningsLimit);
            var totalUST = TaxYearSpecificProvider.GetSpecificValue<decimal>(TaxYearSpecificValues.UpperSecondaryThreshold);
            var totalAUST = TaxYearSpecificProvider.GetSpecificValue<decimal>(TaxYearSpecificValues.ApprenticeUpperSecondaryThreshold);

            var niRates = TaxYearSpecificProvider.GetCodeSpecifics(niCategory);

            var factoring = TaxMath.GetFactoring(periods);
            decimal periodPT = TaxMath.PeriodRound(TaxMath.Factor(totalPT, factoring.WeeksInPeriod, factoring.Periods), factoring.WeeksInPeriod),
                periodST = TaxMath.PeriodRound(TaxMath.Factor(totalST, factoring.WeeksInPeriod, factoring.Periods), factoring.WeeksInPeriod),
                periodUEL = TaxMath.PeriodRound(TaxMath.Factor(totalUEL, factoring.WeeksInPeriod, factoring.Periods), factoring.WeeksInPeriod),
                periodLEL = Math.Ceiling(TaxMath.Factor(totalLEL, factoring.WeeksInPeriod, factoring.Periods));

            var niCalc = new NationalInsuranceCalculation
            {
                EarningsUptoIncludingLEL = SubtractRound(gross, periodLEL, 0),
                EarningsAboveLELUptoIncludingPT = SubtractRound(gross, periodPT, periodLEL),
                EarningsAbovePTUptoIncludingST = SubtractRound(gross, periodST, periodPT),
                EarningsAboveSTUptoIncludingUEL = SubtractRound(gross, periodUEL, periodST),
                EarningsAboveUEL = SubtractRound(gross, gross, periodUEL)
            };

            niCalc.EmployeeNiGross += TaxMath.HmrcRound(niCalc.EarningsAbovePTUptoIncludingST * (niRates.EeC / 100));
            niCalc.EmployeeNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveSTUptoIncludingUEL * (niRates.EeD / 100));
            niCalc.EmployeeNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveUEL * (niRates.EeE / 100));

            niCalc.EmployerNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveSTUptoIncludingUEL * (niRates.ErD / 100));
            niCalc.EmployerNiGross += TaxMath.HmrcRound(niCalc.EarningsAboveUEL * (niRates.ErE / 100));

            return niCalc;
        }
    }
}
