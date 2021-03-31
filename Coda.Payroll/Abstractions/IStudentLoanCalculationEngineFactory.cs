// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.

namespace Coda.Payroll.Abstractions
{
    public interface IStudentLoanCalculationEngineFactory
    {
        /// <summary>
        /// Creates a Student Loan Calculation Engine for a specific tax year
        /// </summary>
        /// <param name="taxYear">Tax Year</param>
        /// <returns>Student Loan Calculation Engine for given Tax Year</returns>
        IStudentLoanCalculationEngine CreateStudentLoanCalculationEngine(int taxYear);
    }
}
