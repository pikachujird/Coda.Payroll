// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Calculation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cedita.Payroll.Tests
{
    public partial class StudentLoanTests
    {
        [TestCategory("Student Loan Tests"), TestMethod]
        public void StudentLoanPlan1ExactMethod2016()
        {
            Assert.AreEqual(0, TestShim(2016, StudentLoanPlan.Plan1, 347.55m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(2016, StudentLoanPlan.Plan1, 347.56m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(2016, StudentLoanPlan.Plan1, 358.64m, PayPeriods.Weekly));
            Assert.AreEqual(10, TestShim(2016, StudentLoanPlan.Plan1, 450, PayPeriods.Weekly));
            Assert.AreEqual(118, TestShim(2016, StudentLoanPlan.Plan1, 1650, PayPeriods.Weekly));
            Assert.AreEqual(158, TestShim(2016, StudentLoanPlan.Plan1, 2100, PayPeriods.Weekly));

            Assert.AreEqual(0, TestShim(2016, StudentLoanPlan.Plan1, 683.99m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(2016, StudentLoanPlan.Plan1, 684, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(2016, StudentLoanPlan.Plan1, 695.1m, PayPeriods.Fortnightly));
            Assert.AreEqual(9, TestShim(2016, StudentLoanPlan.Plan1, 775, PayPeriods.Fortnightly));
            Assert.AreEqual(19, TestShim(2016, StudentLoanPlan.Plan1, 888, PayPeriods.Fortnightly));
            Assert.AreEqual(268, TestShim(2016, StudentLoanPlan.Plan1, 3654, PayPeriods.Fortnightly));
            Assert.AreEqual(389, TestShim(2016, StudentLoanPlan.Plan1, 5000, PayPeriods.Fortnightly));
            
            Assert.AreEqual(0, TestShim(2016, StudentLoanPlan.Plan1, 1356.87m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(2016, StudentLoanPlan.Plan1, 1356.88m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(2016, StudentLoanPlan.Plan1, 1367.98m, PayPeriods.FourWeekly));
            Assert.AreEqual(23, TestShim(2016, StudentLoanPlan.Plan1, 1610, PayPeriods.FourWeekly));
            Assert.AreEqual(111, TestShim(2016, StudentLoanPlan.Plan1, 2588.91m, PayPeriods.FourWeekly));
            Assert.AreEqual(598, TestShim(2016, StudentLoanPlan.Plan1, 8000, PayPeriods.FourWeekly));
            
            Assert.AreEqual(0, TestShim(2016, StudentLoanPlan.Plan1, 1469.02m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(2016, StudentLoanPlan.Plan1, 1469.03m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(2016, StudentLoanPlan.Plan1, 1480.13m, PayPeriods.Monthly));
            Assert.AreEqual(45, TestShim(2016, StudentLoanPlan.Plan1, 1964.71m, PayPeriods.Monthly));
            Assert.AreEqual(119, TestShim(2016, StudentLoanPlan.Plan1, 2791, PayPeriods.Monthly));
            Assert.AreEqual(248, TestShim(2016, StudentLoanPlan.Plan1, 4222, PayPeriods.Monthly));
            Assert.AreEqual(597, TestShim(2016, StudentLoanPlan.Plan1, 8100, PayPeriods.Monthly));
        }

        [TestCategory("Student Loan Tests"), TestMethod]
        public void StudentLoanPlan2ExactMethod2016()
        {
            Assert.AreEqual(0, TestShim(2016, StudentLoanPlan.Plan2, 414.95m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(2016, StudentLoanPlan.Plan2, 414.96m, PayPeriods.Weekly));
            Assert.AreEqual(1, TestShim(2016, StudentLoanPlan.Plan2, 426.06m, PayPeriods.Weekly));
            Assert.AreEqual(13, TestShim(2016, StudentLoanPlan.Plan2, 550, PayPeriods.Weekly));
            Assert.AreEqual(114, TestShim(2016, StudentLoanPlan.Plan2, 1675, PayPeriods.Weekly));
            Assert.AreEqual(143, TestShim(2016, StudentLoanPlan.Plan2, 2000, PayPeriods.Weekly));
            
            Assert.AreEqual(0, TestShim(2016, StudentLoanPlan.Plan2, 818.80m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(2016, StudentLoanPlan.Plan2, 818.81m, PayPeriods.Fortnightly));
            Assert.AreEqual(1, TestShim(2016, StudentLoanPlan.Plan2, 829.91m, PayPeriods.Fortnightly));
            Assert.AreEqual(6, TestShim(2016, StudentLoanPlan.Plan2, 875, PayPeriods.Fortnightly));
            Assert.AreEqual(10, TestShim(2016, StudentLoanPlan.Plan2, 919, PayPeriods.Fortnightly));
            Assert.AreEqual(238, TestShim(2016, StudentLoanPlan.Plan2, 3456, PayPeriods.Fortnightly));
            Assert.AreEqual(377, TestShim(2016, StudentLoanPlan.Plan2, 5000, PayPeriods.Fortnightly));

            Assert.AreEqual(0, TestShim(2016, StudentLoanPlan.Plan2, 1626.49m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(2016, StudentLoanPlan.Plan2, 1626.50m, PayPeriods.FourWeekly));
            Assert.AreEqual(1, TestShim(2016, StudentLoanPlan.Plan2, 1637.60m, PayPeriods.FourWeekly));
            Assert.AreEqual(8, TestShim(2016, StudentLoanPlan.Plan2, 1712, PayPeriods.FourWeekly));
            Assert.AreEqual(177, TestShim(2016, StudentLoanPlan.Plan2, 3588.91m, PayPeriods.FourWeekly));
            Assert.AreEqual(574, TestShim(2016, StudentLoanPlan.Plan2, 8000, PayPeriods.FourWeekly));

            Assert.AreEqual(0, TestShim(2016, StudentLoanPlan.Plan2, 1761.11m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(2016, StudentLoanPlan.Plan2, 1761.12m, PayPeriods.Monthly));
            Assert.AreEqual(1, TestShim(2016, StudentLoanPlan.Plan2, 1772.22m, PayPeriods.Monthly));
            Assert.AreEqual(4, TestShim(2016, StudentLoanPlan.Plan2, 1795, PayPeriods.Monthly));
            Assert.AreEqual(45, TestShim(2016, StudentLoanPlan.Plan2, 2250, PayPeriods.Monthly));
            Assert.AreEqual(242, TestShim(2016, StudentLoanPlan.Plan2, 4444, PayPeriods.Monthly));
            Assert.AreEqual(571, TestShim(2016, StudentLoanPlan.Plan2, 8100, PayPeriods.Monthly));
        }
    }
}
