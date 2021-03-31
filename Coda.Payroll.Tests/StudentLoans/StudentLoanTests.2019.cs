// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Coda.Payroll.Calculation;
using Coda.Payroll.Calculation.StudentLoan;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coda.Payroll.Tests
{
    public partial class StudentLoanTests
    {
        [TestCategory("Student Loan Tests"), TestMethod]
        public void StudentLoanPlan1ExactMethod2019()
        {
            Assert.AreEqual(0, TestShim(2019, StudentLoanPlan.Plan1, 375.24m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(2019, StudentLoanPlan.Plan1, 375.25m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(2019, StudentLoanPlan.Plan1, 375.35m, PayPeriods.Weekly));
            Assert.AreEqual(8, TestShim(2019, StudentLoanPlan.Plan1, 453.10m, PayPeriods.Weekly));
            Assert.AreEqual(116, TestShim(2019, StudentLoanPlan.Plan1, 1653.20m, PayPeriods.Weekly));
            Assert.AreEqual(157, TestShim(2019, StudentLoanPlan.Plan1, 2109m, PayPeriods.Weekly));

            Assert.AreEqual(0, TestShim(2019, StudentLoanPlan.Plan1, 739.37m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(2019, StudentLoanPlan.Plan1, 739.38m, PayPeriods.Fortnightly));
            Assert.AreEqual(4, TestShim(2019, StudentLoanPlan.Plan1, 772.80m, PayPeriods.Fortnightly));
            Assert.AreEqual(6, TestShim(2019, StudentLoanPlan.Plan1, 795m, PayPeriods.Fortnightly));
            Assert.AreEqual(16, TestShim(2019, StudentLoanPlan.Plan1, 906.10m, PayPeriods.Fortnightly));
            Assert.AreEqual(265, TestShim(2019, StudentLoanPlan.Plan1, 3673m, PayPeriods.Fortnightly));
            Assert.AreEqual(386, TestShim(2019, StudentLoanPlan.Plan1, 5018m, PayPeriods.Fortnightly));
            
            Assert.AreEqual(0, TestShim(2019, StudentLoanPlan.Plan1, 1467.64m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(2019, StudentLoanPlan.Plan1, 1467.65m, PayPeriods.FourWeekly));
            Assert.AreEqual(18, TestShim(2019, StudentLoanPlan.Plan1, 1656.60m, PayPeriods.FourWeekly));
            Assert.AreEqual(52, TestShim(2019, StudentLoanPlan.Plan1, 2035m, PayPeriods.FourWeekly));
            Assert.AreEqual(106, TestShim(2019, StudentLoanPlan.Plan1, 2635m, PayPeriods.FourWeekly));
            Assert.AreEqual(593, TestShim(2019, StudentLoanPlan.Plan1, 8046m, PayPeriods.FourWeekly));
            
            Assert.AreEqual(0, TestShim(2019, StudentLoanPlan.Plan1, 1589.02m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(2019, StudentLoanPlan.Plan1, 1589.03m, PayPeriods.Monthly));
            Assert.AreEqual(31, TestShim(2019, StudentLoanPlan.Plan1, 1923m, PayPeriods.Monthly));
            Assert.AreEqual(39, TestShim(2019, StudentLoanPlan.Plan1, 2011.25m, PayPeriods.Monthly));
            Assert.AreEqual(113, TestShim(2019, StudentLoanPlan.Plan1, 2834m, PayPeriods.Monthly));
            Assert.AreEqual(242, TestShim(2019, StudentLoanPlan.Plan1, 4267m, PayPeriods.Monthly));
            Assert.AreEqual(591, TestShim(2019, StudentLoanPlan.Plan1, 8145m, PayPeriods.Monthly));
        }

        [TestCategory("Student Loan Tests"), TestMethod]
        public void StudentLoanPlan2ExactMethod2019()
        {
            Assert.AreEqual(0, TestShim(2019, StudentLoanPlan.Plan2, 505.82m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(2019, StudentLoanPlan.Plan2, 505.83m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(2019, StudentLoanPlan.Plan2, 515.90m, PayPeriods.Weekly));
            Assert.AreEqual(13, TestShim(2019, StudentLoanPlan.Plan2, 640m, PayPeriods.Weekly));
            Assert.AreEqual(114, TestShim(2019, StudentLoanPlan.Plan2, 1765m, PayPeriods.Weekly));
            Assert.AreEqual(143, TestShim(2019, StudentLoanPlan.Plan2, 2090m, PayPeriods.Weekly));
            
            Assert.AreEqual(0, TestShim(2019, StudentLoanPlan.Plan2, 1000.53m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(2019, StudentLoanPlan.Plan2, 1000.54m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(2019, StudentLoanPlan.Plan2, 1011.55m, PayPeriods.Fortnightly));
            Assert.AreEqual(6, TestShim(2019, StudentLoanPlan.Plan2, 1057.00m, PayPeriods.Fortnightly));
            Assert.AreEqual(10, TestShim(2019, StudentLoanPlan.Plan2, 1101m, PayPeriods.Fortnightly));
            Assert.AreEqual(238, TestShim(2019, StudentLoanPlan.Plan2, 3635m, PayPeriods.Fortnightly));
            Assert.AreEqual(377, TestShim(2019, StudentLoanPlan.Plan2, 5179m, PayPeriods.Fortnightly));

            Assert.AreEqual(0, TestShim(2019, StudentLoanPlan.Plan2, 1989.95m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(2019, StudentLoanPlan.Plan2, 1989.96m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(2019, StudentLoanPlan.Plan2, 2000.96m, PayPeriods.FourWeekly));
            Assert.AreEqual(8, TestShim(2019, StudentLoanPlan.Plan2, 2067.80m, PayPeriods.FourWeekly));
            Assert.AreEqual(177, TestShim(2019, StudentLoanPlan.Plan2, 3950m, PayPeriods.FourWeekly));
            Assert.AreEqual(574, TestShim(2019, StudentLoanPlan.Plan2, 8360m, PayPeriods.FourWeekly));

            Assert.AreEqual(0, TestShim(2019, StudentLoanPlan.Plan2, 2154.86m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(2019, StudentLoanPlan.Plan2, 2154.87m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(2019, StudentLoanPlan.Plan2, 2165.95m, PayPeriods.Monthly));
            Assert.AreEqual(4, TestShim(2019, StudentLoanPlan.Plan2, 2188.40m, PayPeriods.Monthly));
            Assert.AreEqual(45, TestShim(2019, StudentLoanPlan.Plan2, 2644m, PayPeriods.Monthly));
            Assert.AreEqual(242, TestShim(2019, StudentLoanPlan.Plan2, 4836m, PayPeriods.Monthly));
            Assert.AreEqual(571, TestShim(2019, StudentLoanPlan.Plan2, 8490m, PayPeriods.Monthly));
        }

        [TestCategory("Student Loan Tests"), TestMethod]
        public void StudentLoanPostGradExactMethod2019()
        {
            Assert.AreEqual(0, TestShim(2019, StudentLoanPlan.PostGrad, 420.50m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(2019, StudentLoanPlan.PostGrad, 420.51m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(2019, StudentLoanPlan.PostGrad, 437.10m, PayPeriods.Weekly));
            Assert.AreEqual(13, TestShim(2019, StudentLoanPlan.PostGrad, 622m, PayPeriods.Weekly));
            Assert.AreEqual(114, TestShim(2019, StudentLoanPlan.PostGrad, 2305m, PayPeriods.Weekly));
            Assert.AreEqual(143, TestShim(2019, StudentLoanPlan.PostGrad, 2790m, PayPeriods.Weekly));

            Assert.AreEqual(0, TestShim(2019, StudentLoanPlan.PostGrad, 824.35m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(2019, StudentLoanPlan.PostGrad, 824.36m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(2019, StudentLoanPlan.PostGrad, 830m, PayPeriods.Fortnightly));
            Assert.AreEqual(6, TestShim(2019, StudentLoanPlan.PostGrad, 909m, PayPeriods.Fortnightly));
            Assert.AreEqual(10, TestShim(2019, StudentLoanPlan.PostGrad, 975m, PayPeriods.Fortnightly));
            Assert.AreEqual(238, TestShim(2019, StudentLoanPlan.PostGrad, 4780m, PayPeriods.Fortnightly));
            Assert.AreEqual(377, TestShim(2019, StudentLoanPlan.PostGrad, 7095m, PayPeriods.Fortnightly));

            Assert.AreEqual(0, TestShim(2019, StudentLoanPlan.PostGrad, 1632.04m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(2019, StudentLoanPlan.PostGrad, 1632.05m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(2019, StudentLoanPlan.PostGrad, 1640m, PayPeriods.FourWeekly));
            Assert.AreEqual(8, TestShim(2019, StudentLoanPlan.PostGrad, 1750m, PayPeriods.FourWeekly));
            Assert.AreEqual(177, TestShim(2019, StudentLoanPlan.PostGrad, 4570m, PayPeriods.FourWeekly));
            Assert.AreEqual(574, TestShim(2019, StudentLoanPlan.PostGrad, 11185m, PayPeriods.FourWeekly));

            Assert.AreEqual(0, TestShim(2019, StudentLoanPlan.PostGrad, 1766.66m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(2019, StudentLoanPlan.PostGrad, 1766.67m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(2019, StudentLoanPlan.PostGrad, 1770m, PayPeriods.Monthly));
            Assert.AreEqual(4, TestShim(2019, StudentLoanPlan.PostGrad, 1817m, PayPeriods.Monthly));
            Assert.AreEqual(45, TestShim(2019, StudentLoanPlan.PostGrad, 2500m, PayPeriods.Monthly));
            Assert.AreEqual(242, TestShim(2019, StudentLoanPlan.PostGrad, 5795m, PayPeriods.Monthly));
            Assert.AreEqual(571, TestShim(2019, StudentLoanPlan.PostGrad, 11267m, PayPeriods.Monthly));
        }
    }
}
