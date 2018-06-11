// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.

namespace Cedita.Payroll.Abstractions
{
    public interface IPayeCalculationEngineFactory
    {
        /// <summary>
        /// Creates a PAYE Calculation Engine for a specific tax year
        /// </summary>
        /// <param name="taxYear">Tax Year</param>
        /// <returns>Payroll Calculation Engine for given Tax Year</returns>
        IPayeCalculationEngine CreatePayeCalculationEngine(int taxYear);
    }
}
