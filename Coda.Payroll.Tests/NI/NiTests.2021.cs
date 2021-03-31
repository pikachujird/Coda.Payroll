// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coda.Payroll.Tests
{
    public partial class NiTests
    {
        [TestCategory("NI Tests"), TestMethod]
        public void NationalInsurance2021()
        {
            // A
            var niCode = 'A';
            Assert.AreEqual(0m, TestShim(170.04m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0.01m, TestShim(170.05m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0.01m, TestShim(170.11m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0.02m, TestShim(170.12m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(1.93m, TestShim(184.01m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(1.94m, TestShim(184.04m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(1.95m, TestShim(184.05m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(203.93m, TestShim(966.96m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(203.94m, TestShim(966.97m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(203.99m, TestShim(967.29m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(204m, TestShim(967.3m, niCode, PayPeriods.Weekly, 2021));

            Assert.AreEqual(0m, TestShim(340.04m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0.01m, TestShim(340.05m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0.01m, TestShim(340.11m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0.02m, TestShim(340.12m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(3.86m, TestShim(368.01m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(3.87m, TestShim(368.04m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(3.88m, TestShim(368.05m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(407.88m, TestShim(1933.96m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(407.89m, TestShim(1933.97m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(407.93m, TestShim(1934.29m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(407.94m, TestShim(1934.3m, niCode, PayPeriods.Fortnightly, 2021));

            Assert.AreEqual(0m, TestShim(680.04m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0.01m, TestShim(680.05m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0.01m, TestShim(680.11m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0.02m, TestShim(680.12m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(7.73m, TestShim(736.01m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(7.73m, TestShim(736.04m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(7.74m, TestShim(736.05m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(815.51m, TestShim(3866.96m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(815.52m, TestShim(3866.97m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(815.57m, TestShim(3867.29m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(815.58m, TestShim(3867.3m, niCode, PayPeriods.FourWeekly, 2021));

            Assert.AreEqual(0m, TestShim(737.04m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0.01m, TestShim(737.05m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0.01m, TestShim(737.11m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0.02m, TestShim(737.12m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(8.28m, TestShim(797.01m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(8.28m, TestShim(797.04m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(8.3m, TestShim(797.05m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(883.4m, TestShim(4188.96m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(883.41m, TestShim(4188.97m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(883.46m, TestShim(4189.29m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(883.47m, TestShim(4189.3m, niCode, PayPeriods.Monthly, 2021));

            niCode = 'B';
            Assert.AreEqual(0m, TestShim(170.04m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0.01m, TestShim(170.05m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0.01m, TestShim(170.11m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0.02m, TestShim(170.12m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(1.93m, TestShim(184.01m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(1.94m, TestShim(184.04m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(1.94m, TestShim(184.05m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(155.78m, TestShim(966.96m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(155.78m, TestShim(966.97m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(155.83m, TestShim(967.29m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(155.84m, TestShim(967.3m, niCode, PayPeriods.Weekly, 2021));

            Assert.AreEqual(0m, TestShim(340.04m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0.01m, TestShim(340.05m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0.01m, TestShim(340.11m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0.02m, TestShim(340.12m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(3.86m, TestShim(368.01m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(3.87m, TestShim(368.04m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(3.87m, TestShim(368.05m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(311.58m, TestShim(1933.96m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(311.58m, TestShim(1933.97m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(311.62m, TestShim(1934.29m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(311.63m, TestShim(1934.3m, niCode, PayPeriods.Fortnightly, 2021));

            Assert.AreEqual(0m, TestShim(680.04m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0.01m, TestShim(680.05m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0.01m, TestShim(680.11m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0.02m, TestShim(680.12m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(7.73m, TestShim(736.01m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(7.73m, TestShim(736.04m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(7.73m, TestShim(736.05m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(622.96m, TestShim(3866.96m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(622.96m, TestShim(3866.97m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(623.01m, TestShim(3867.29m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(623.02m, TestShim(3867.3m, niCode, PayPeriods.FourWeekly, 2021));

            Assert.AreEqual(0m, TestShim(737.04m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0.01m, TestShim(737.05m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0.01m, TestShim(737.11m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0.02m, TestShim(737.12m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(8.28m, TestShim(797.01m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(8.28m, TestShim(797.04m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(8.29m, TestShim(797.05m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(674.8m, TestShim(4188.96m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(674.8m, TestShim(4188.97m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(674.85m, TestShim(4189.29m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(674.86m, TestShim(4189.3m, niCode, PayPeriods.Monthly, 2021));

            niCode = 'C';
            Assert.AreEqual(0m, TestShim(170.04m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0.01m, TestShim(170.05m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0.01m, TestShim(170.11m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0.02m, TestShim(170.12m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(1.93m, TestShim(184.01m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(1.94m, TestShim(184.04m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(1.94m, TestShim(184.05m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(109.98m, TestShim(966.96m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(109.98m, TestShim(966.97m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(110.03m, TestShim(967.29m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(110.03m, TestShim(967.3m, niCode, PayPeriods.Weekly, 2021));

            Assert.AreEqual(0m, TestShim(340.04m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0.01m, TestShim(340.05m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0.01m, TestShim(340.11m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0.02m, TestShim(340.12m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(3.86m, TestShim(368.01m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(3.87m, TestShim(368.04m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(3.87m, TestShim(368.05m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(219.97m, TestShim(1933.96m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(219.97m, TestShim(1933.97m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(220.01m, TestShim(1934.29m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(220.01m, TestShim(1934.3m, niCode, PayPeriods.Fortnightly, 2021));

            Assert.AreEqual(0m, TestShim(680.04m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0.01m, TestShim(680.05m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0.01m, TestShim(680.11m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0.02m, TestShim(680.12m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(7.73m, TestShim(736.01m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(7.73m, TestShim(736.04m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(7.73m, TestShim(736.05m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(439.8m, TestShim(3866.96m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(439.8m, TestShim(3866.97m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(439.85m, TestShim(3867.29m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(439.85m, TestShim(3867.3m, niCode, PayPeriods.FourWeekly, 2021));

            Assert.AreEqual(0m, TestShim(737.04m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0.01m, TestShim(737.05m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0.01m, TestShim(737.11m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0.02m, TestShim(737.12m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(8.28m, TestShim(797.01m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(8.28m, TestShim(797.04m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(8.29m, TestShim(797.05m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(476.37m, TestShim(4188.96m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(476.37m, TestShim(4188.97m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(476.42m, TestShim(4189.29m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(476.42m, TestShim(4189.3m, niCode, PayPeriods.Monthly, 2021));

            niCode = 'H';
            Assert.AreEqual(0m, TestShim(170.04m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0m, TestShim(170.05m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0m, TestShim(170.11m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0m, TestShim(170.12m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0m, TestShim(184.01m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0m, TestShim(184.04m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0.01m, TestShim(184.05m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(93.95m, TestShim(966.96m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(93.96m, TestShim(966.97m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(94m, TestShim(967.29m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(94.01m, TestShim(967.3m, niCode, PayPeriods.Weekly, 2021));

            Assert.AreEqual(0m, TestShim(340.04m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0m, TestShim(340.05m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0m, TestShim(340.11m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0m, TestShim(340.12m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0m, TestShim(368.01m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0m, TestShim(368.04m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0.01m, TestShim(368.05m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(187.91m, TestShim(1933.96m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(187.92m, TestShim(1933.97m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(187.96m, TestShim(1934.29m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(187.97m, TestShim(1934.3m, niCode, PayPeriods.Fortnightly, 2021));

            Assert.AreEqual(0m, TestShim(680.04m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0m, TestShim(680.05m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0m, TestShim(680.11m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0m, TestShim(680.12m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0m, TestShim(736.01m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0m, TestShim(736.04m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0.01m, TestShim(736.05m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(375.71m, TestShim(3866.96m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(375.72m, TestShim(3866.97m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(375.76m, TestShim(3867.29m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(375.77m, TestShim(3867.3m, niCode, PayPeriods.FourWeekly, 2021));

            Assert.AreEqual(0m, TestShim(737.04m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0m, TestShim(737.05m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0m, TestShim(737.11m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0m, TestShim(737.12m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0m, TestShim(797.01m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0m, TestShim(797.04m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0.01m, TestShim(797.05m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(407.03m, TestShim(4188.96m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(407.04m, TestShim(4188.97m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(407.08m, TestShim(4189.29m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(407.09m, TestShim(4189.3m, niCode, PayPeriods.Monthly, 2021));

            niCode = 'J';
            Assert.AreEqual(0m, TestShim(170.04m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0.01m, TestShim(170.05m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0.01m, TestShim(170.11m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0.02m, TestShim(170.12m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(1.93m, TestShim(184.01m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(1.94m, TestShim(184.04m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(1.94m, TestShim(184.05m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(125.64m, TestShim(966.96m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(125.64m, TestShim(966.97m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(125.69m, TestShim(967.29m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(125.7m, TestShim(967.3m, niCode, PayPeriods.Weekly, 2021));

            Assert.AreEqual(0m, TestShim(340.04m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0.01m, TestShim(340.05m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0.01m, TestShim(340.11m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0.02m, TestShim(340.12m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(3.86m, TestShim(368.01m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(3.87m, TestShim(368.04m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(3.87m, TestShim(368.05m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(251.29m, TestShim(1933.96m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(251.29m, TestShim(1933.97m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(251.33m, TestShim(1934.29m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(251.34m, TestShim(1934.3m, niCode, PayPeriods.Fortnightly, 2021));

            Assert.AreEqual(0m, TestShim(680.04m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0.01m, TestShim(680.05m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0.01m, TestShim(680.11m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0.02m, TestShim(680.12m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(7.73m, TestShim(736.01m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(7.73m, TestShim(736.04m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(7.73m, TestShim(736.05m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(502.42m, TestShim(3866.96m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(502.42m, TestShim(3866.97m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(502.47m, TestShim(3867.29m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(502.48m, TestShim(3867.3m, niCode, PayPeriods.FourWeekly, 2021));

            Assert.AreEqual(0m, TestShim(737.04m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0.01m, TestShim(737.05m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0.01m, TestShim(737.11m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0.02m, TestShim(737.12m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(8.28m, TestShim(797.01m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(8.28m, TestShim(797.04m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(8.29m, TestShim(797.05m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(544.21m, TestShim(4188.96m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(544.21m, TestShim(4188.97m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(544.26m, TestShim(4189.29m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(544.27m, TestShim(4189.3m, niCode, PayPeriods.Monthly, 2021));

            niCode = 'M';
            Assert.AreEqual(0m, TestShim(170.04m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0m, TestShim(170.05m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0m, TestShim(170.11m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0m, TestShim(170.12m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0m, TestShim(184.01m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0m, TestShim(184.04m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0.01m, TestShim(184.05m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(93.95m, TestShim(966.96m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(93.96m, TestShim(966.97m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(94m, TestShim(967.29m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(94.01m, TestShim(967.3m, niCode, PayPeriods.Weekly, 2021));

            Assert.AreEqual(0m, TestShim(340.04m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0m, TestShim(340.05m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0m, TestShim(340.11m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0m, TestShim(340.12m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0m, TestShim(368.01m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0m, TestShim(368.04m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0.01m, TestShim(368.05m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(187.91m, TestShim(1933.96m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(187.92m, TestShim(1933.97m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(187.96m, TestShim(1934.29m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(187.97m, TestShim(1934.3m, niCode, PayPeriods.Fortnightly, 2021));

            Assert.AreEqual(0m, TestShim(680.04m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0m, TestShim(680.05m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0m, TestShim(680.11m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0m, TestShim(680.12m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0m, TestShim(736.01m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0m, TestShim(736.04m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0.01m, TestShim(736.05m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(375.71m, TestShim(3866.96m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(375.72m, TestShim(3866.97m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(375.76m, TestShim(3867.29m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(375.77m, TestShim(3867.3m, niCode, PayPeriods.FourWeekly, 2021));

            Assert.AreEqual(0m, TestShim(737.04m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0m, TestShim(737.05m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0m, TestShim(737.11m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0m, TestShim(737.12m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0m, TestShim(797.01m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0m, TestShim(797.04m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0.01m, TestShim(797.05m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(407.03m, TestShim(4188.96m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(407.04m, TestShim(4188.97m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(407.08m, TestShim(4189.29m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(407.09m, TestShim(4189.3m, niCode, PayPeriods.Monthly, 2021));

            niCode = 'Z';
            Assert.AreEqual(0m, TestShim(170.04m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0m, TestShim(170.05m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0m, TestShim(170.11m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0m, TestShim(170.12m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0m, TestShim(184.01m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0m, TestShim(184.04m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0m, TestShim(184.05m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(15.66m, TestShim(966.96m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(15.66m, TestShim(966.97m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(15.7m, TestShim(967.29m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(15.71m, TestShim(967.3m, niCode, PayPeriods.Weekly, 2021));

            Assert.AreEqual(0m, TestShim(340.04m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0m, TestShim(340.05m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0m, TestShim(340.11m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0m, TestShim(340.12m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0m, TestShim(368.01m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0m, TestShim(368.04m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0m, TestShim(368.05m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(31.32m, TestShim(1933.96m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(31.32m, TestShim(1933.97m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(31.36m, TestShim(1934.29m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(31.37m, TestShim(1934.3m, niCode, PayPeriods.Fortnightly, 2021));

            Assert.AreEqual(0m, TestShim(680.04m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0m, TestShim(680.05m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0m, TestShim(680.11m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0m, TestShim(680.12m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0m, TestShim(736.01m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0m, TestShim(736.04m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0m, TestShim(736.05m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(62.62m, TestShim(3866.96m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(62.62m, TestShim(3866.97m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(62.66m, TestShim(3867.29m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(62.67m, TestShim(3867.3m, niCode, PayPeriods.FourWeekly, 2021));

            Assert.AreEqual(0m, TestShim(737.04m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0m, TestShim(737.05m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0m, TestShim(737.11m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0m, TestShim(737.12m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0m, TestShim(797.01m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0m, TestShim(797.04m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0m, TestShim(797.05m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(67.84m, TestShim(4188.96m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(67.84m, TestShim(4188.97m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(67.88m, TestShim(4189.29m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(67.89m, TestShim(4189.3m, niCode, PayPeriods.Monthly, 2021));

            // X Codes
            niCode = 'X';
            Assert.AreEqual(0m, TestShim(162.29m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0m, TestShim(162.30m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0m, TestShim(892.04m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0m, TestShim(892.05m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0m, TestShim(892.29m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0m, TestShim(892.30m, niCode, PayPeriods.Weekly, 2021));
            Assert.AreEqual(0m, TestShim(1180m, niCode, PayPeriods.Weekly, 2021));

            Assert.AreEqual(0m, TestShim(324.29m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0m, TestShim(324.30m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0m, TestShim(1783.04m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0m, TestShim(1783.05m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0m, TestShim(1783.29m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0m, TestShim(1783.30m, niCode, PayPeriods.Fortnightly, 2021));
            Assert.AreEqual(0m, TestShim(2545m, niCode, PayPeriods.Fortnightly, 2021));

            Assert.AreEqual(0m, TestShim(648.29m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0m, TestShim(648.30m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0m, TestShim(3566.04m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0m, TestShim(3566.05m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0m, TestShim(3566.29m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0m, TestShim(3566.30m, niCode, PayPeriods.FourWeekly, 2021));
            Assert.AreEqual(0m, TestShim(4850m, niCode, PayPeriods.FourWeekly, 2021));

            Assert.AreEqual(0m, TestShim(702.29m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0m, TestShim(702.30m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0m, TestShim(3863.04m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0m, TestShim(3863.05m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0m, TestShim(3863.29m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0m, TestShim(3863.30m, niCode, PayPeriods.Monthly, 2021));
            Assert.AreEqual(0m, TestShim(5500m, niCode, PayPeriods.Monthly, 2021));

            // Ensure the UEL/LEL Figures are all zero for X Code
            var niResult = GetCalculationResult(600m, niCode, PayPeriods.Weekly, 2021);
            Assert.AreEqual(0m, niResult.EarningsUptoIncludingLEL);
            Assert.AreEqual(0m, niResult.EarningsAboveUEL);
            Assert.AreEqual(0m, niResult.EarningsAboveSTUptoIncludingUEL);
            Assert.AreEqual(0m, niResult.EarningsAbovePTUptoIncludingST);
            Assert.AreEqual(0m, niResult.EarningsAboveLELUptoIncludingPT);
        }
    }
}