// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cedita.Payroll.Tests
{
    public partial class NiTests
    {
        [TestCategory("NI Tests"), TestMethod]
        public void NationalInsurance2014()
        {
            // A
            var niCode = 'A';
            Assert.AreEqual(0.00m, TestShim(153.04m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.02m, TestShim(153.05m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(159.19m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(159.21m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(168.22m, TestShim(805.04m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(168.23m, TestShim(805.05m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(168.26m, TestShim(805.29m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(168.27m, TestShim(805.30m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(227.47m, TestShim(1180.00m, niCode, PayPeriods.Weekly, 2014));

            Assert.AreEqual(0.00m, TestShim(306.04m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(0.02m, TestShim(306.05m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(318.37m, TestShim(1540.04m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(318.39m, TestShim(1540.05m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(336.69m, TestShim(1611.04m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(336.70m, TestShim(1611.05m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(336.73m, TestShim(1611.29m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(336.74m, TestShim(1611.30m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(484.26m, TestShim(2545.00m, niCode, PayPeriods.Fortnightly, 2014));

            Assert.AreEqual(0.00m, TestShim(612.04m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(0.02m, TestShim(612.05m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(636.74m, TestShim(3080.04m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(636.76m, TestShim(3080.05m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(673.12m, TestShim(3221.04m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(673.13m, TestShim(3221.05m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(673.16m, TestShim(3221.29m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(673.17m, TestShim(3221.30m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(930.50m, TestShim(4850.00m, niCode, PayPeriods.FourWeekly, 2014));

            Assert.AreEqual(0.00m, TestShim(663.04m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(0.02m, TestShim(663.05m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(689.89m, TestShim(3337.04m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(689.91m, TestShim(3337.05m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(729.11m, TestShim(3489.04m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(729.12m, TestShim(3489.05m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(729.15m, TestShim(3489.29m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(729.16m, TestShim(3489.30m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(1046.85m, TestShim(5500.00m, niCode, PayPeriods.Monthly, 2014));

            // B
            niCode = 'B';
            Assert.AreEqual(0.00m, TestShim(153.04m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.01m, TestShim(153.05m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.01m, TestShim(153.10m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.02m, TestShim(153.11m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(121.24m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(121.25m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(121.25m, TestShim(770.10m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(121.26m, TestShim(770.11m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(128.12m, TestShim(805.04m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(128.13m, TestShim(805.05m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(128.16m, TestShim(805.29m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(128.17m, TestShim(805.30m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(187.37m, TestShim(1180.00m, niCode, PayPeriods.Weekly, 2014));

            Assert.AreEqual(0.00m, TestShim(306.04m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(0.01m, TestShim(306.05m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(0.01m, TestShim(306.10m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(0.02m, TestShim(306.11m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(242.48m, TestShim(1540.04m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(242.49m, TestShim(1540.05m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(242.49m, TestShim(1540.10m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(242.50m, TestShim(1540.11m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(256.43m, TestShim(1611.04m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(256.44m, TestShim(1611.05m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(256.47m, TestShim(1611.29m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(256.48m, TestShim(1611.30m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(404.00m, TestShim(2545.00m, niCode, PayPeriods.Fortnightly, 2014));

            Assert.AreEqual(0.00m, TestShim(612.04m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(0.01m, TestShim(612.05m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(0.01m, TestShim(612.10m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(0.02m, TestShim(612.11m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(484.96m, TestShim(3080.04m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(484.97m, TestShim(3080.05m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(484.97m, TestShim(3080.10m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(484.98m, TestShim(3080.11m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(512.67m, TestShim(3221.04m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(512.68m, TestShim(3221.05m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(512.71m, TestShim(3221.29m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(512.72m, TestShim(3221.30m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(770.05m, TestShim(4850.00m, niCode, PayPeriods.FourWeekly, 2014));

            Assert.AreEqual(0.00m, TestShim(663.04m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(0.01m, TestShim(663.05m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(0.01m, TestShim(663.10m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(0.02m, TestShim(663.11m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(525.44m, TestShim(3337.04m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(525.45m, TestShim(3337.05m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(525.45m, TestShim(3337.10m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(525.46m, TestShim(3337.11m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(555.31m, TestShim(3489.04m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(555.32m, TestShim(3489.05m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(555.35m, TestShim(3489.29m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(555.36m, TestShim(3489.30m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(873.05m, TestShim(5500.00m, niCode, PayPeriods.Monthly, 2014));

            // C
            niCode = 'C';
            Assert.AreEqual(0.00m, TestShim(153.04m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.01m, TestShim(153.05m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(85.15m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(85.16m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(89.98m, TestShim(805.04m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(89.99m, TestShim(805.05m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(141.73m, TestShim(1180.00m, niCode, PayPeriods.Weekly, 2014));

            Assert.AreEqual(0.00m, TestShim(306.04m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(0.01m, TestShim(306.05m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(170.29m, TestShim(1540.04m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(170.30m, TestShim(1540.05m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(180.09m, TestShim(1611.04m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(180.10m, TestShim(1611.05m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(308.98m, TestShim(2545.00m, niCode, PayPeriods.Fortnightly, 2014));

            Assert.AreEqual(0.00m, TestShim(612.04m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(0.01m, TestShim(612.05m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(340.58m, TestShim(3080.04m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(340.59m, TestShim(3080.05m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(360.04m, TestShim(3221.04m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(360.05m, TestShim(3221.05m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(584.84m, TestShim(4850.00m, niCode, PayPeriods.FourWeekly, 2014));

            Assert.AreEqual(0.00m, TestShim(663.04m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(0.01m, TestShim(663.05m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(369.01m, TestShim(3337.04m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(369.02m, TestShim(3337.05m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(389.99m, TestShim(3489.04m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(390.00m, TestShim(3489.05m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(667.51m, TestShim(5500.00m, niCode, PayPeriods.Monthly, 2014));

            // D
            niCode = 'D';
            Assert.AreEqual(0.00m, TestShim(111.17m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(-0.01m, TestShim(111.18m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(-0.01m, TestShim(111.42m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(-0.02m, TestShim(111.43m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(-2.02m, TestShim(153.04m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(-2.00m, TestShim(153.06m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(127.55m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(127.57m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(136.58m, TestShim(805.04m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(136.59m, TestShim(805.05m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(136.62m, TestShim(805.29m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(136.63m, TestShim(805.30m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(195.83m, TestShim(1180.00m, niCode, PayPeriods.Weekly, 2014));

            Assert.AreEqual(0.00m, TestShim(222.17m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(-0.01m, TestShim(222.18m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(-0.01m, TestShim(222.42m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(-0.02m, TestShim(222.43m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(-4.04m, TestShim(306.05m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(-4.02m, TestShim(306.06m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(255.10m, TestShim(1540.04m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(255.12m, TestShim(1540.05m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(273.42m, TestShim(1611.04m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(273.43m, TestShim(1611.05m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(273.46m, TestShim(1611.29m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(273.47m, TestShim(1611.30m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(420.99m, TestShim(2545.00m, niCode, PayPeriods.Fortnightly, 2014));

            Assert.AreEqual(0.00m, TestShim(444.17m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(-0.01m, TestShim(444.18m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(-0.01m, TestShim(444.42m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(-0.02m, TestShim(444.43m, niCode, PayPeriods.FourWeekly, 2014));
           Assert.AreEqual(-8.06m, TestShim(612.05m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(-8.04m, TestShim(612.06m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(510.22m, TestShim(3080.04m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(510.24m, TestShim(3080.05m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(546.60m, TestShim(3221.04m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(546.61m, TestShim(3221.05m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(546.64m, TestShim(3221.29m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(546.65m, TestShim(3221.30m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(803.98m, TestShim(4850.00m, niCode, PayPeriods.FourWeekly, 2014));

            Assert.AreEqual(0.00m, TestShim(481.17m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(-0.01m, TestShim(481.18m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(-0.01m, TestShim(481.42m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(-0.02m, TestShim(481.43m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(-8.74m, TestShim(663.05m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(-8.72m, TestShim(663.06m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(552.80m, TestShim(3337.04m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(552.82m, TestShim(3337.05m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(592.02m, TestShim(3489.04m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(592.03m, TestShim(3489.05m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(592.06m, TestShim(3489.29m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(592.07m, TestShim(3489.30m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(909.76m, TestShim(5500.00m, niCode, PayPeriods.Monthly, 2014));

            // E
            niCode = 'E';
            Assert.AreEqual(0.00m, TestShim(111.17m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(-0.01m, TestShim(111.18m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(-1.43m, TestShim(153.05m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(-1.42m, TestShim(153.06m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(-1.42m, TestShim(153.10m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(-1.41m, TestShim(153.11m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(98.83m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(98.84m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(98.84m, TestShim(770.10m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(98.85m, TestShim(770.11m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(105.71m, TestShim(805.04m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(105.72m, TestShim(805.05m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(105.75m, TestShim(805.29m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(105.76m, TestShim(805.30m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(164.96m, TestShim(1180.00m, niCode, PayPeriods.Weekly, 2014));

            Assert.AreEqual(0.00m, TestShim(222.17m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(-0.01m, TestShim(222.18m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(-2.86m, TestShim(306.05m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(-2.85m, TestShim(306.06m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(-2.85m, TestShim(306.10m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(-2.84m, TestShim(306.11m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(197.67m, TestShim(1540.04m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(197.68m, TestShim(1540.05m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(197.68m, TestShim(1540.10m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(197.69m, TestShim(1540.11m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(211.62m, TestShim(1611.04m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(211.63m, TestShim(1611.05m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(211.66m, TestShim(1611.29m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(211.67m, TestShim(1611.30m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(359.19m, TestShim(2545.00m, niCode, PayPeriods.Fortnightly, 2014));

            Assert.AreEqual(0.00m, TestShim(444.17m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(-0.01m, TestShim(444.18m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(-5.71m, TestShim(612.05m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(-5.70m, TestShim(612.06m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(-5.70m, TestShim(612.10m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(-5.69m, TestShim(612.11m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(395.34m, TestShim(3080.04m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(395.35m, TestShim(3080.05m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(395.35m, TestShim(3080.10m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(395.36m, TestShim(3080.11m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(423.05m, TestShim(3221.04m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(423.06m, TestShim(3221.05m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(423.09m, TestShim(3221.29m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(423.10m, TestShim(3221.30m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(680.43m, TestShim(4850.00m, niCode, PayPeriods.FourWeekly, 2014));

            Assert.AreEqual(0.00m, TestShim(481.17m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(-0.01m, TestShim(481.18m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(-6.19m, TestShim(663.05m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(-6.18m, TestShim(663.06m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(-6.18m, TestShim(663.10m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(-6.17m, TestShim(663.11m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(428.34m, TestShim(3337.04m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(428.35m, TestShim(3337.05m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(428.35m, TestShim(3337.10m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(428.36m, TestShim(3337.11m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(458.21m, TestShim(3489.04m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(458.22m, TestShim(3489.05m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(458.25m, TestShim(3489.29m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(458.26m, TestShim(3489.30m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(775.95m, TestShim(5500.00m, niCode, PayPeriods.Monthly, 2014));

            // J
            niCode = 'J';
            Assert.AreEqual(0.00m, TestShim(153.04m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.01m, TestShim(153.05m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.04m, TestShim(153.29m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.05m, TestShim(153.30m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(97.49m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(97.50m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(97.53m, TestShim(770.29m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(97.54m, TestShim(770.30m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(103.02m, TestShim(805.04m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(103.03m, TestShim(805.05m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(103.06m, TestShim(805.29m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(103.07m, TestShim(805.30m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(162.27m, TestShim(1180.00m, niCode, PayPeriods.Weekly, 2014));

            Assert.AreEqual(0.00m, TestShim(306.04m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(0.01m, TestShim(306.05m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(0.04m, TestShim(306.29m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(0.05m, TestShim(306.30m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(194.97m, TestShim(1540.04m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(194.98m, TestShim(1540.05m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(195.01m, TestShim(1540.29m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(195.02m, TestShim(1540.30m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(206.19m, TestShim(1611.04m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(206.20m, TestShim(1611.05m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(206.23m, TestShim(1611.29m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(206.24m, TestShim(1611.30m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(353.76m, TestShim(2545.00m, niCode, PayPeriods.Fortnightly, 2014));

            Assert.AreEqual(0.00m, TestShim(612.04m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(0.01m, TestShim(612.05m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(0.04m, TestShim(612.29m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(0.05m, TestShim(612.30m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(389.94m, TestShim(3080.04m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(389.95m, TestShim(3080.05m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(389.98m, TestShim(3080.29m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(389.99m, TestShim(3080.30m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(412.22m, TestShim(3221.04m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(412.23m, TestShim(3221.05m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(412.26m, TestShim(3221.29m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(412.27m, TestShim(3221.30m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(669.60m, TestShim(4850.00m, niCode, PayPeriods.FourWeekly, 2014));

            Assert.AreEqual(0.00m, TestShim(663.04m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(0.01m, TestShim(663.05m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(0.04m, TestShim(663.29m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(0.05m, TestShim(663.30m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(422.49m, TestShim(3337.04m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(422.50m, TestShim(3337.05m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(422.53m, TestShim(3337.29m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(422.54m, TestShim(3337.30m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(446.51m, TestShim(3489.04m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(446.52m, TestShim(3489.05m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(446.55m, TestShim(3489.29m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(446.56m, TestShim(3489.30m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(764.25m, TestShim(5500.00m, niCode, PayPeriods.Monthly, 2014));

            //L
            niCode = 'L';
            Assert.AreEqual(0.00m, TestShim(111.17m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(-0.01m, TestShim(111.18m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(-0.01m, TestShim(111.42m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(-0.02m, TestShim(111.43m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(-2.02m, TestShim(153.05m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(-2.01m, TestShim(153.06m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(-1.99m, TestShim(153.29m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(-1.98m, TestShim(153.30m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(74.49m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(74.50m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(74.53m, TestShim(770.29m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(74.54m, TestShim(770.30m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(80.02m, TestShim(805.04m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(80.03m, TestShim(805.05m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(80.06m, TestShim(805.29m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(80.07m, TestShim(805.30m, niCode, PayPeriods.Weekly, 2014));
            Assert.AreEqual(139.27m, TestShim(1180.00m, niCode, PayPeriods.Weekly, 2014));

            Assert.AreEqual(0.00m, TestShim(222.17m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(-0.01m, TestShim(222.18m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(-0.01m, TestShim(222.42m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(-0.02m, TestShim(222.43m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(-4.04m, TestShim(306.05m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(-4.03m, TestShim(306.06m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(-4.01m, TestShim(306.29m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(-4.00m, TestShim(306.30m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(148.98m, TestShim(1540.04m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(148.99m, TestShim(1540.05m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(149.02m, TestShim(1540.29m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(149.03m, TestShim(1540.30m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(160.20m, TestShim(1611.04m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(160.21m, TestShim(1611.05m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(160.24m, TestShim(1611.29m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(160.25m, TestShim(1611.30m, niCode, PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(307.77m, TestShim(2545.00m, niCode, PayPeriods.Fortnightly, 2014));

            Assert.AreEqual(0.00m, TestShim(444.17m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(-0.01m, TestShim(444.18m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(-0.01m, TestShim(444.42m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(-0.02m, TestShim(444.43m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(-8.06m, TestShim(612.05m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(-8.05m, TestShim(612.06m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(-8.03m, TestShim(612.29m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(-8.02m, TestShim(612.30m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(297.97m, TestShim(3080.04m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(297.98m, TestShim(3080.05m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(298.01m, TestShim(3080.29m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(298.02m, TestShim(3080.30m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(320.25m, TestShim(3221.04m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(320.26m, TestShim(3221.05m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(320.29m, TestShim(3221.29m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(320.30m, TestShim(3221.30m, niCode, PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(577.63m, TestShim(4850.00m, niCode, PayPeriods.FourWeekly, 2014));

            Assert.AreEqual(0.00m, TestShim(481.17m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(-0.01m, TestShim(481.18m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(-0.01m, TestShim(481.42m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(-0.02m, TestShim(481.43m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(-8.74m, TestShim(663.05m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(-8.73m, TestShim(663.06m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(-8.71m, TestShim(663.29m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(-8.70m, TestShim(663.30m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(322.84m, TestShim(3337.04m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(322.85m, TestShim(3337.05m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(322.88m, TestShim(3337.29m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(322.89m, TestShim(3337.30m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(346.86m, TestShim(3489.04m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(346.87m, TestShim(3489.05m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(346.90m, TestShim(3489.29m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(346.91m, TestShim(3489.30m, niCode, PayPeriods.Monthly, 2014));
            Assert.AreEqual(664.60m, TestShim(5500.00m, niCode, PayPeriods.Monthly, 2014));
        }
    }
}
