// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Calculation;
using Cedita.Payroll.Calculation.StudentLoan;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cedita.Payroll.Tests
{
    public partial class StudentLoanTests
    {
        [TestCategory("Student Loan Tests"), TestMethod]
        public void StudentLoanPlan1ExactMethod2021()
        {
            Assert.AreEqual(0, TestShim(2021, StudentLoanPlan.Plan1, 393.7m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan1, 393.71m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan1, 393.81m, PayPeriods.Weekly));
            Assert.AreEqual(13, TestShim(2021, StudentLoanPlan.Plan1, 527.04m, PayPeriods.Weekly));
            Assert.AreEqual(114, TestShim(2021, StudentLoanPlan.Plan1, 1649.26m, PayPeriods.Weekly));
            Assert.AreEqual(143, TestShim(2021, StudentLoanPlan.Plan1, 1971.58m, PayPeriods.Weekly));
            
            Assert.AreEqual(0, TestShim(2021, StudentLoanPlan.Plan1, 776.3m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan1, 776.31m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan1, 776.41m, PayPeriods.Fortnightly));
            Assert.AreEqual(6, TestShim(2021, StudentLoanPlan.Plan1, 831.86m, PayPeriods.Fortnightly));
            Assert.AreEqual(10, TestShim(2021, StudentLoanPlan.Plan1, 876.31m, PayPeriods.Fortnightly));
            Assert.AreEqual(238, TestShim(2021, StudentLoanPlan.Plan1, 3409.64m, PayPeriods.Fortnightly));
            Assert.AreEqual(377, TestShim(2021, StudentLoanPlan.Plan1, 4954.08m, PayPeriods.Fortnightly));
            
            Assert.AreEqual(0, TestShim(2021, StudentLoanPlan.Plan1, 1541.49m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan1, 1541.5m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan1, 1541.6m, PayPeriods.FourWeekly));
            Assert.AreEqual(8, TestShim(2021, StudentLoanPlan.Plan1, 1619.27m, PayPeriods.FourWeekly));
            Assert.AreEqual(177, TestShim(2021, StudentLoanPlan.Plan1, 3497.05m, PayPeriods.FourWeekly));
            Assert.AreEqual(574, TestShim(2021, StudentLoanPlan.Plan1, 7908.16m, PayPeriods.FourWeekly));
            
            Assert.AreEqual(0, TestShim(2021, StudentLoanPlan.Plan1, 1669.02m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan1, 1669.03m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan1, 1669.13m, PayPeriods.Monthly));
            Assert.AreEqual(4, TestShim(2021, StudentLoanPlan.Plan1, 1702.36m, PayPeriods.Monthly));
            Assert.AreEqual(45, TestShim(2021, StudentLoanPlan.Plan1, 2158.02m, PayPeriods.Monthly));
            Assert.AreEqual(242, TestShim(2021, StudentLoanPlan.Plan1, 4346.8m, PayPeriods.Monthly));
            Assert.AreEqual(571, TestShim(2021, StudentLoanPlan.Plan1, 8002.36m, PayPeriods.Monthly));
        }

        [TestCategory("Student Loan Tests"), TestMethod]
        public void StudentLoanPlan2ExactMethod2021()
        {
            Assert.AreEqual(0, TestShim(2021, StudentLoanPlan.Plan2, 536.01m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan2, 536.02m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan2, 536.12m, PayPeriods.Weekly));
            Assert.AreEqual(13, TestShim(2021, StudentLoanPlan.Plan2, 669.35m, PayPeriods.Weekly));
            Assert.AreEqual(114, TestShim(2021, StudentLoanPlan.Plan2, 1791.57m, PayPeriods.Weekly));
            Assert.AreEqual(143, TestShim(2021, StudentLoanPlan.Plan2, 2113.89m, PayPeriods.Weekly));
            
            Assert.AreEqual(0, TestShim(2021, StudentLoanPlan.Plan2, 1060.91m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan2, 1060.92m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan2, 1061.02m, PayPeriods.Fortnightly));
            Assert.AreEqual(6, TestShim(2021, StudentLoanPlan.Plan2, 1116.47m, PayPeriods.Fortnightly));
            Assert.AreEqual(10, TestShim(2021, StudentLoanPlan.Plan2, 1160.92m, PayPeriods.Fortnightly));
            Assert.AreEqual(238, TestShim(2021, StudentLoanPlan.Plan2, 3694.25m, PayPeriods.Fortnightly));
            Assert.AreEqual(377, TestShim(2021, StudentLoanPlan.Plan2, 5238.69m, PayPeriods.Fortnightly));
            
            Assert.AreEqual(0, TestShim(2021, StudentLoanPlan.Plan2, 2110.72m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan2, 2110.73m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan2, 2110.83m, PayPeriods.FourWeekly));
            Assert.AreEqual(8, TestShim(2021, StudentLoanPlan.Plan2, 2188.5m, PayPeriods.FourWeekly));
            Assert.AreEqual(177, TestShim(2021, StudentLoanPlan.Plan2, 4066.28m, PayPeriods.FourWeekly));
            Assert.AreEqual(574, TestShim(2021, StudentLoanPlan.Plan2, 8477.39m, PayPeriods.FourWeekly));
            
            Assert.AreEqual(0, TestShim(2021, StudentLoanPlan.Plan2, 2285.69m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan2, 2285.7m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan2, 2285.8m, PayPeriods.Monthly));
            Assert.AreEqual(4, TestShim(2021, StudentLoanPlan.Plan2, 2319.03m, PayPeriods.Monthly));
            Assert.AreEqual(45, TestShim(2021, StudentLoanPlan.Plan2, 2774.69m, PayPeriods.Monthly));
            Assert.AreEqual(242, TestShim(2021, StudentLoanPlan.Plan2, 4963.47m, PayPeriods.Monthly));
            Assert.AreEqual(571, TestShim(2021, StudentLoanPlan.Plan2, 8619.03m, PayPeriods.Monthly));
        }

        [TestCategory("Student Loan Tests"), TestMethod]
        public void StudentLoanPlan4ExactMethod2021()
        {
            Assert.AreEqual(0, TestShim(2021, StudentLoanPlan.Plan4, 491.87m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan4, 491.88m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan4, 491.98m, PayPeriods.Weekly));
            Assert.AreEqual(13, TestShim(2021, StudentLoanPlan.Plan4, 625.21m, PayPeriods.Weekly));
            Assert.AreEqual(114, TestShim(2021, StudentLoanPlan.Plan4, 1747.43m, PayPeriods.Weekly));
            Assert.AreEqual(143, TestShim(2021, StudentLoanPlan.Plan4, 2069.75m, PayPeriods.Weekly));
            
            Assert.AreEqual(0, TestShim(2021, StudentLoanPlan.Plan4, 972.64m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan4, 972.65m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan4, 972.75m, PayPeriods.Fortnightly));
            Assert.AreEqual(6, TestShim(2021, StudentLoanPlan.Plan4, 1028.2m, PayPeriods.Fortnightly));
            Assert.AreEqual(10, TestShim(2021, StudentLoanPlan.Plan4, 1072.65m, PayPeriods.Fortnightly));
            Assert.AreEqual(238, TestShim(2021, StudentLoanPlan.Plan4, 3605.98m, PayPeriods.Fortnightly));
            Assert.AreEqual(377, TestShim(2021, StudentLoanPlan.Plan4, 5150.42m, PayPeriods.Fortnightly));
            
            Assert.AreEqual(0, TestShim(2021, StudentLoanPlan.Plan4, 1934.18m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan4, 1934.19m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan4, 1934.29m, PayPeriods.FourWeekly));
            Assert.AreEqual(8, TestShim(2021, StudentLoanPlan.Plan4, 2011.96m, PayPeriods.FourWeekly));
            Assert.AreEqual(177, TestShim(2021, StudentLoanPlan.Plan4, 3889.74m, PayPeriods.FourWeekly));
            Assert.AreEqual(574, TestShim(2021, StudentLoanPlan.Plan4, 8300.85m, PayPeriods.FourWeekly));
            
            Assert.AreEqual(0, TestShim(2021, StudentLoanPlan.Plan4, 2094.44m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan4, 2094.45m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.Plan4, 2094.55m, PayPeriods.Monthly));
            Assert.AreEqual(4, TestShim(2021, StudentLoanPlan.Plan4, 2127.78m, PayPeriods.Monthly));
            Assert.AreEqual(45, TestShim(2021, StudentLoanPlan.Plan4, 2583.44m, PayPeriods.Monthly));
            Assert.AreEqual(242, TestShim(2021, StudentLoanPlan.Plan4, 4772.22m, PayPeriods.Monthly));
            Assert.AreEqual(571, TestShim(2021, StudentLoanPlan.Plan4, 8427.78m, PayPeriods.Monthly));
        }

        [TestCategory("Student Loan Tests"), TestMethod]
        public void StudentLoanPostGradExactMethod2021()
        {
            Assert.AreEqual(0, TestShim(2021, StudentLoanPlan.PostGrad, 420.50m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.PostGrad, 420.51m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.PostGrad, 437.10m, PayPeriods.Weekly));
            Assert.AreEqual(13, TestShim(2021, StudentLoanPlan.PostGrad, 622m, PayPeriods.Weekly));
            Assert.AreEqual(114, TestShim(2021, StudentLoanPlan.PostGrad, 2305m, PayPeriods.Weekly));
            Assert.AreEqual(143, TestShim(2021, StudentLoanPlan.PostGrad, 2790m, PayPeriods.Weekly));

            Assert.AreEqual(0, TestShim(2021, StudentLoanPlan.PostGrad, 824.35m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.PostGrad, 824.36m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.PostGrad, 830m, PayPeriods.Fortnightly));
            Assert.AreEqual(6, TestShim(2021, StudentLoanPlan.PostGrad, 909m, PayPeriods.Fortnightly));
            Assert.AreEqual(10, TestShim(2021, StudentLoanPlan.PostGrad, 975m, PayPeriods.Fortnightly));
            Assert.AreEqual(238, TestShim(2021, StudentLoanPlan.PostGrad, 4780m, PayPeriods.Fortnightly));
            Assert.AreEqual(377, TestShim(2021, StudentLoanPlan.PostGrad, 7095m, PayPeriods.Fortnightly));

            Assert.AreEqual(0, TestShim(2021, StudentLoanPlan.PostGrad, 1632.04m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.PostGrad, 1632.05m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.PostGrad, 1640m, PayPeriods.FourWeekly));
            Assert.AreEqual(8, TestShim(2021, StudentLoanPlan.PostGrad, 1750m, PayPeriods.FourWeekly));
            Assert.AreEqual(177, TestShim(2021, StudentLoanPlan.PostGrad, 4570m, PayPeriods.FourWeekly));
            Assert.AreEqual(574, TestShim(2021, StudentLoanPlan.PostGrad, 11185m, PayPeriods.FourWeekly));

            Assert.AreEqual(0, TestShim(2021, StudentLoanPlan.PostGrad, 1766.66m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.PostGrad, 1766.67m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(2021, StudentLoanPlan.PostGrad, 1770m, PayPeriods.Monthly));
            Assert.AreEqual(4, TestShim(2021, StudentLoanPlan.PostGrad, 1817m, PayPeriods.Monthly));
            Assert.AreEqual(45, TestShim(2021, StudentLoanPlan.PostGrad, 2500m, PayPeriods.Monthly));
            Assert.AreEqual(242, TestShim(2021, StudentLoanPlan.PostGrad, 5795m, PayPeriods.Monthly));
            Assert.AreEqual(571, TestShim(2021, StudentLoanPlan.PostGrad, 11267m, PayPeriods.Monthly));
        }
    }
}
