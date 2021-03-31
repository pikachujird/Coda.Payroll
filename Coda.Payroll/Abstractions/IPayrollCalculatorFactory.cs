// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.

namespace Coda.Payroll.Abstractions
{
    public interface IPayrollCalculatorFactory
    {
        /// <summary>
        /// Creates a Payroll Calculator for the year that the current date falls in
        /// </summary>
        /// <returns>Payroll Calculator for current Tax Year</returns>
        IPayrollCalculator CreatePayrollCalculator();

        /// <summary>
        /// Creates a Payroll Calculator for a specific tax year
        /// </summary>
        /// <param name="taxYear">Tax Year</param>
        /// <returns>Payroll Calculator for given Tax Year</returns>
        IPayrollCalculator CreatePayrollCalculator(int taxYear);
    }
}
