// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Calculation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cedita.Payroll.Tests
{
    [TestClass]
    public partial class StudentLoanTests
    {
        //protected StudentLoans CalculationEngine { get; set; }

        protected decimal TestShim(int year, StudentLoanPlan plan, decimal gross, PayPeriods periods)
        {
            return 0;
            /*if (CalculationEngine == null) {
                CalculationEngine = new StudentLoans();
                CalculationEngine.SetTaxYearSpecificsProvider(new JsonTaxYearSpecificProvider());
            }
            CalculationEngine.SetTaxYear(year);

            return CalculationEngine.CalculateStudentLoanDeduction(plan, gross, periods).StudentLoanDeduction;*/
        }
    }
}
