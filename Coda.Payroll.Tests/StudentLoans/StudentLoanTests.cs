// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Coda.Payroll.Abstractions;
using Coda.Payroll.Calculation;
using Coda.Payroll.Calculation.StudentLoan;
using Coda.Payroll.Configuration.Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coda.Payroll.Tests
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
