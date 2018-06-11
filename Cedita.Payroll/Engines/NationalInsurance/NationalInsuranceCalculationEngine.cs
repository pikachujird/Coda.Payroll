// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Abstractions;
using System;

namespace Cedita.Payroll.Engines.NationalInsurance
{
    public abstract class NationalInsuranceCalculationEngine : INiCalculationEngine
    {
        public abstract NationalInsuranceCalculation CalculateNationalInsurance(decimal gross, char niCategory, PayPeriods payPeriods);

        protected virtual decimal SubtractRound(decimal gross, decimal limit, decimal subtract)
        {
            var subtractFrom = TaxMath.Smallest(gross, limit);
            var subtracted = subtractFrom - subtract;
            subtracted = Math.Round(subtracted, 2, MidpointRounding.AwayFromZero);
            return TaxMath.PositiveOnly(subtracted);
        }
    }
}
