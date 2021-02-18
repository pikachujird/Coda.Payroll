// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Abstractions;
using Cedita.Payroll.Calculation;
using Cedita.Payroll.Calculation.StudentLoan;
using Cedita.Payroll.Configuration.Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cedita.Payroll.Tests
{
    [TestClass]
    public partial class StudentLoanTests
    {
        protected EmbeddedTaxConfigurationDataProvider DataProvider = new EmbeddedTaxConfigurationDataProvider();
        protected readonly IStudentLoanCalculationEngineFactory studentLoanFactory;

        public StudentLoanTests()
        {
            studentLoanFactory = new DefaultStudentLoanCalculationEngineFactory(DataProvider);
        }


        protected decimal TestShim(int year, StudentLoanPlan plan, decimal gross, PayPeriods periods)
        {
            var studentLoanCalculationEngine = studentLoanFactory.CreateStudentLoanCalculationEngine(year);
            return studentLoanCalculationEngine.CalculateStudentLoanDeduction(plan, gross, periods).StudentLoanDeduction;
        }
    }
}
