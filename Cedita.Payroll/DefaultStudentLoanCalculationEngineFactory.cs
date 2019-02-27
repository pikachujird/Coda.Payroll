// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Abstractions;
using Cedita.Payroll.Calculation;
using Cedita.Payroll.Calculation.StudentLoan;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Cedita.Payroll
{
    public class DefaultStudentLoanCalculationEngineFactory : IStudentLoanCalculationEngineFactory
    {
        protected readonly ITaxConfigurationDataProvider taxConfigurationDataProvider;

        public DefaultStudentLoanCalculationEngineFactory(ITaxConfigurationDataProvider taxConfigurationDataProvider)
        {
            this.taxConfigurationDataProvider = taxConfigurationDataProvider;
        }

        public IStudentLoanCalculationEngine CreateStudentLoanCalculationEngine(int taxYear) => new StudentLoanCalculationEngine(taxConfigurationDataProvider.GetTaxYearConfigurationData(taxYear));
    }
}
