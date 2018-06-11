// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.

namespace Cedita.Payroll.Abstractions
{
    public interface INiCalculationEngineFactory
    {
        /// <summary>
        /// Creates a NI Calculation Engine for a specific tax year
        /// </summary>
        /// <param name="taxYear">Tax Year</param>
        /// <returns>NI Calculation Engine for given Tax Year</returns>
        INiCalculationEngine CreateNiCalculationEngine(int taxYear);
    }
}
