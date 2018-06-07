// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.

namespace Cedita.Payroll.Engines.NationalInsurance
{
    public interface INiCalculationEngine
    {
        NationalInsuranceCalculation CalculateNationalInsurance(decimal gross, char niCategory, PayPeriods periods);
    }
}
