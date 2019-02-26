// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.

using Cedita.Payroll.Calculation.StatutoryPayments;

namespace Cedita.Payroll.Abstractions
{
    public interface IStatutoryCalculationEngineFactory
    {
        /// <summary>
        /// Creates an SSP Calculation Engine for a specific tax year
        /// </summary>
        /// <param name="taxYear">Tax Year</param>
        /// <returns>SSP Calculation Engine for given Tax Year</returns>
        IStatutorySickPayCalculationEngine CreateSspCalculationEngine(int taxYear);

        /// <summary>
        /// Creates an SMP Calculation Engine for a specific tax year
        /// </summary>
        /// <param name="taxYear">Tax Year</param>
        /// <returns>SMP Calculation Engine for given Tax Year</returns>
        IStatutoryMaternityPayCalculationEngine CreateSmpCalculationEngine(int taxYear);

        /// <summary>
        /// Creates an SPP Calculation Engine for a specific tax year
        /// </summary>
        /// <param name="taxYear">Tax Year</param>
        /// <returns>SPP Calculation Engine for given Tax Year</returns>
        IStatutoryPaternityPayCalculationEngine CreateSppCalculationEngine(int taxYear);
    }
}
