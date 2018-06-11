// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Abstractions;
using System;

namespace Cedita.Payroll
{
    public class DefaultPayrollCalculatorFactory : IPayrollCalculatorFactory
    {
        public IPayrollCalculator CreatePayrollCalculator()
        {
            // Get the current tax year
            var taxDate = DateTime.Now.GetTaxPeriod();
            var taxYear = taxDate.Year;

            return CreatePayrollCalculator(taxYear);
        }

        public IPayrollCalculator CreatePayrollCalculator(int taxYear)
        {
            throw new System.NotImplementedException();
        }
    }
}
