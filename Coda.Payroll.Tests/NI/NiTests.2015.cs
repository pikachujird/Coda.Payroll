// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coda.Payroll.Tests
{
    public partial class NiTests
    {
        [TestCategory("NI Tests"), TestMethod]
        public void NationalInsurance2015()
        {
            // A
            var niCode = 'A';
            Assert.AreEqual(0.00m, TestShim(155.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.01m, TestShim(155.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.12m, TestShim(156.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.14m, TestShim(156.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(158.53m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(158.55m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(170.14m, TestShim(815.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(170.15m, TestShim(815.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(170.18m, TestShim(815.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(170.19m, TestShim(815.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(227.81m, TestShim(1180.00m, niCode, PayPeriods.Weekly, 2015));

            Assert.AreEqual(0.00m, TestShim(310.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(0.01m, TestShim(310.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(0.24m, TestShim(312.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(0.26m, TestShim(312.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(317.06m, TestShim(1540.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(317.08m, TestShim(1540.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(340.54m, TestShim(1631.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(340.55m, TestShim(1631.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(340.58m, TestShim(1631.29m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(340.59m, TestShim(1631.30m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(484.95m, TestShim(2545m, niCode, PayPeriods.Fortnightly, 2015));

            Assert.AreEqual(0.00m, TestShim(620.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(0.01m, TestShim(620.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(0.48m, TestShim(624.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(0.50m, TestShim(624.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(634.13m, TestShim(3080.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(634.15m, TestShim(3080.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(680.83m, TestShim(3261.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(680.84m, TestShim(3261.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(680.87m, TestShim(3261.29m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(680.88m, TestShim(3261.30m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(931.89m, TestShim(4850m, niCode, PayPeriods.FourWeekly, 2015));
            
            Assert.AreEqual(0.00m, TestShim(672.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(0.01m, TestShim(672.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(0.48m, TestShim(676.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(0.50m, TestShim(676.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(687.02m, TestShim(3337.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(687.04m, TestShim(3337.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(737.33m, TestShim(3532.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(737.34m, TestShim(3532.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(737.37m, TestShim(3532.29m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(737.38m, TestShim(3532.30m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(1048.27m, TestShim(5500m, niCode, PayPeriods.Monthly, 2015));

            // B
            niCode = 'B';
            Assert.AreEqual(0.00m, TestShim(155.10m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.01m, TestShim(155.11m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.06m, TestShim(156.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.07m, TestShim(156.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(120.71m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(120.72m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(120.72m, TestShim(770.10m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(120.73m, TestShim(770.11m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(129.55m, TestShim(815.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(129.56m, TestShim(815.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(129.59m, TestShim(815.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(129.60m, TestShim(815.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(187.22m, TestShim(1180m, niCode, PayPeriods.Weekly, 2015));

            Assert.AreEqual(0.00m, TestShim(310.10m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(0.01m, TestShim(310.11m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(0.12m, TestShim(312.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(0.13m, TestShim(312.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(241.42m, TestShim(1540.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(241.43m, TestShim(1540.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(241.43m, TestShim(1540.10m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(241.44m, TestShim(1540.11m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(259.30m, TestShim(1631.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(259.31m, TestShim(1631.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(259.34m, TestShim(1631.29m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(259.35m, TestShim(1631.30m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(403.71m, TestShim(2545m, niCode, PayPeriods.Fortnightly, 2015));

            Assert.AreEqual(0.00m, TestShim(620.10m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(0.01m, TestShim(620.11m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(0.23m, TestShim(624.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(0.24m, TestShim(624.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(482.84m, TestShim(3080.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(482.85m, TestShim(3080.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(482.85m, TestShim(3080.10m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(482.86m, TestShim(3080.11m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(518.41m, TestShim(3261.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(518.42m, TestShim(3261.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(518.45m, TestShim(3261.29m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(518.46m, TestShim(3261.30m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(769.47m, TestShim(4850m, niCode, PayPeriods.FourWeekly, 2015));

            Assert.AreEqual(0.00m, TestShim(672.10m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(0.01m, TestShim(672.11m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(0.23m, TestShim(676.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(0.24m, TestShim(676.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(523.12m, TestShim(3337.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(523.13m, TestShim(3337.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(523.13m, TestShim(3337.10m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(523.14m, TestShim(3337.11m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(561.44m, TestShim(3532.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(561.45m, TestShim(3532.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(561.48m, TestShim(3532.29m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(561.49m, TestShim(3532.30m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(872.38m, TestShim(5500m, niCode, PayPeriods.Monthly, 2015));

            // C
            niCode = 'C';
            Assert.AreEqual(0.00m, TestShim(156.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.01m, TestShim(156.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(84.73m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(84.74m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(90.94m, TestShim(815.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(90.95m, TestShim(815.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(141.31m, TestShim(1180m, niCode, PayPeriods.Weekly, 2015));

            Assert.AreEqual(0.00m, TestShim(312.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(0.01m, TestShim(312.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(169.46m, TestShim(1540.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(169.47m, TestShim(1540.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(182.02m, TestShim(1631.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(182.03m, TestShim(1631.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(308.15m, TestShim(2545m, niCode, PayPeriods.Fortnightly, 2015));

            Assert.AreEqual(0.00m, TestShim(624.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(0.01m, TestShim(624.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(338.93m, TestShim(3080.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(338.94m, TestShim(3080.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(363.91m, TestShim(3261.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(363.92m, TestShim(3261.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(583.19m, TestShim(4850m, niCode, PayPeriods.FourWeekly, 2015));

            Assert.AreEqual(0.00m, TestShim(676.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(0.01m, TestShim(676.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(367.22m, TestShim(3337.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(367.23m, TestShim(3337.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(394.13m, TestShim(3532.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(394.14m, TestShim(3532.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(665.71m, TestShim(5500m, niCode, PayPeriods.Monthly, 2015));

            // D
            niCode = 'D';
            Assert.AreEqual(0.00m, TestShim(112.17m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(112.18m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(112.42m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.02m, TestShim(112.43m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.06m, TestShim(155.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.05m, TestShim(155.06m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-1.98m, TestShim(156.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-1.96m, TestShim(156.06m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(126.96m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(126.98m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(138.57m, TestShim(815.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(138.58m, TestShim(815.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(138.61m, TestShim(815.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(138.62m, TestShim(815.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(196.24m, TestShim(1180m, niCode, PayPeriods.Weekly, 2015));

            Assert.AreEqual(0.00m, TestShim(224.17m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-0.01m, TestShim(224.18m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-0.01m, TestShim(224.42m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-0.02m, TestShim(224.43m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-4.12m, TestShim(310.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-4.11m, TestShim(310.06m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-3.98m, TestShim(312.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-3.96m, TestShim(312.06m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(253.90m, TestShim(1540.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(253.92m, TestShim(1540.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(277.38m, TestShim(1631.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(277.39m, TestShim(1631.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(277.42m, TestShim(1631.29m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(277.43m, TestShim(1631.30m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(421.79m, TestShim(2545m, niCode, PayPeriods.Fortnightly, 2015));

            Assert.AreEqual(0.00m, TestShim(448.17m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(448.18m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(448.42m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-0.02m, TestShim(448.43m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-8.26m, TestShim(620.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-8.25m, TestShim(620.06m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-7.98m, TestShim(624.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-7.96m, TestShim(624.06m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(507.78m, TestShim(3080.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(507.80m, TestShim(3080.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(554.48m, TestShim(3261.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(554.49m, TestShim(3261.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(554.52m, TestShim(3261.29m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(554.53m, TestShim(3261.30m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(805.54m, TestShim(4850m, niCode, PayPeriods.FourWeekly, 2015));

            Assert.AreEqual(0.00m, TestShim(486.17m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-0.01m, TestShim(486.18m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-0.01m, TestShim(486.42m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-0.02m, TestShim(486.43m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-8.92m, TestShim(672.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-8.91m, TestShim(672.06m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-8.64m, TestShim(676.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-8.62m, TestShim(676.06m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(550.17m, TestShim(3337.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(550.19m, TestShim(3337.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(600.48m, TestShim(3532.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(600.49m, TestShim(3532.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(600.52m, TestShim(3532.29m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(600.53m, TestShim(3532.30m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(911.42m, TestShim(5500m, niCode, PayPeriods.Monthly, 2015));

            // E
            niCode = 'E';
            Assert.AreEqual(0.00m, TestShim(112.17m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(112.18m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-1.46m, TestShim(155.10m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-1.45m, TestShim(155.11m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-1.43m, TestShim(156.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-1.42m, TestShim(156.06m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(98.35m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(98.36m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(98.36m, TestShim(770.10m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(98.37m, TestShim(770.11m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(107.19m, TestShim(815.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(107.20m, TestShim(815.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(107.23m, TestShim(815.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(107.24m, TestShim(815.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(164.86m, TestShim(1180m, niCode, PayPeriods.Weekly, 2015));

            Assert.AreEqual(0.00m, TestShim(224.17m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-0.01m, TestShim(224.18m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-2.92m, TestShim(310.10m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-2.91m, TestShim(310.11m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-2.87m, TestShim(312.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-2.86m, TestShim(312.06m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(196.68m, TestShim(1540.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(196.69m, TestShim(1540.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(196.69m, TestShim(1540.10m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(196.70m, TestShim(1540.11m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(214.56m, TestShim(1631.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(214.57m, TestShim(1631.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(214.60m, TestShim(1631.29m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(214.61m, TestShim(1631.30m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(358.97m, TestShim(2545m, niCode, PayPeriods.Fortnightly, 2015));

            Assert.AreEqual(0.00m, TestShim(448.17m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(448.18m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-5.85m, TestShim(620.10m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-5.84m, TestShim(620.11m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-5.76m, TestShim(624.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-5.75m, TestShim(624.06m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(393.34m, TestShim(3080.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(393.35m, TestShim(3080.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(393.35m, TestShim(3080.10m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(393.36m, TestShim(3080.11m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(428.91m, TestShim(3261.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(428.92m, TestShim(3261.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(428.95m, TestShim(3261.29m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(428.96m, TestShim(3261.30m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(679.97m, TestShim(4850m, niCode, PayPeriods.FourWeekly, 2015));

            Assert.AreEqual(0.00m, TestShim(486.17m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-0.01m, TestShim(486.18m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-6.32m, TestShim(672.10m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-6.31m, TestShim(672.11m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-6.23m, TestShim(676.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-6.22m, TestShim(676.06m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(426.18m, TestShim(3337.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(426.19m, TestShim(3337.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(426.19m, TestShim(3337.10m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(426.20m, TestShim(3337.11m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(464.50m, TestShim(3532.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(464.51m, TestShim(3532.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(464.54m, TestShim(3532.29m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(464.55m, TestShim(3532.30m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(775.44m, TestShim(5500m, niCode, PayPeriods.Monthly, 2015));

            // I
            niCode = 'I';
            Assert.AreEqual(0.00m, TestShim(112.17m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(112.18m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(112.42m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.02m, TestShim(112.43m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.06m, TestShim(155.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.05m, TestShim(155.06m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-1.96m, TestShim(156.17m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-1.97m, TestShim(156.18m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(15.58m, TestShim(400m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(42.22m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(42.23m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(47.62m, TestShim(815.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(47.63m, TestShim(815.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(47.66m, TestShim(815.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(47.67m, TestShim(815.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(105.29m, TestShim(1180m, niCode, PayPeriods.Weekly, 2015));

            Assert.AreEqual(0.00m, TestShim(224.17m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-0.01m, TestShim(224.18m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-0.01m, TestShim(224.42m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-0.02m, TestShim(224.43m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-4.12m, TestShim(310.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-4.11m, TestShim(310.06m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-3.96m, TestShim(312.17m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-3.97m, TestShim(312.18m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(31.16m, TestShim(800m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(84.44m, TestShim(1540.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(84.45m, TestShim(1540.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(95.36m, TestShim(1631.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(95.37m, TestShim(1631.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(95.40m, TestShim(1631.29m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(95.41m, TestShim(1631.30m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(239.77m, TestShim(2545m, niCode, PayPeriods.Fortnightly, 2015));

            Assert.AreEqual(0.00m, TestShim(448.17m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(448.18m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(448.42m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-0.02m, TestShim(448.43m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-8.26m, TestShim(620.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-8.25m, TestShim(620.06m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-7.96m, TestShim(624.17m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-7.97m, TestShim(624.18m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(62.30m, TestShim(1600m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(168.86m, TestShim(3080.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(168.87m, TestShim(3080.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(190.58m, TestShim(3261.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(190.59m, TestShim(3261.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(190.62m, TestShim(3261.29m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(190.63m, TestShim(3261.30m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(441.64m, TestShim(4850m, niCode, PayPeriods.FourWeekly, 2015));

            Assert.AreEqual(0.00m, TestShim(486.17m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-0.01m, TestShim(486.18m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-0.01m, TestShim(486.42m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-0.02m, TestShim(486.43m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-8.92m, TestShim(672.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-8.91m, TestShim(672.06m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-8.62m, TestShim(676.17m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-8.63m, TestShim(676.18m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(43.48m, TestShim(1400m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(182.96m, TestShim(3337.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(182.97m, TestShim(3337.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(206.36m, TestShim(3532.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(206.37m, TestShim(3532.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(206.40m, TestShim(3532.29m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(206.41m, TestShim(3532.30m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(517.30m, TestShim(5500m, niCode, PayPeriods.Monthly, 2015));

            // J
            niCode = 'J';
            Assert.AreEqual(0.00m, TestShim(155.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.01m, TestShim(155.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.02m, TestShim(156.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.03m, TestShim(156.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(97.03m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(97.04m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(97.07m, TestShim(770.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(97.08m, TestShim(770.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(104.14m, TestShim(815.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(104.15m, TestShim(815.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(104.18m, TestShim(815.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(104.19m, TestShim(815.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(161.81m, TestShim(1180m, niCode, PayPeriods.Weekly, 2015));

            Assert.AreEqual(0.00m, TestShim(310.29m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(0.01m, TestShim(310.30m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(0.04m, TestShim(312.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(0.05m, TestShim(312.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(194.06m, TestShim(1540.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(194.07m, TestShim(1540.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(194.10m, TestShim(1540.29m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(194.11m, TestShim(1540.30m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(208.44m, TestShim(1631.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(208.45m, TestShim(1631.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(208.48m, TestShim(1631.29m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(208.49m, TestShim(1631.30m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(352.85m, TestShim(2545m, niCode, PayPeriods.Fortnightly, 2015));

            Assert.AreEqual(0.00m, TestShim(620.29m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(0.01m, TestShim(620.30m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(0.08m, TestShim(624.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(0.09m, TestShim(624.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(388.13m, TestShim(3080.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(388.14m, TestShim(3080.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(388.17m, TestShim(3080.29m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(388.18m, TestShim(3080.30m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(416.73m, TestShim(3261.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(416.74m, TestShim(3261.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(416.77m, TestShim(3261.29m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(416.78m, TestShim(3261.30m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(667.79m, TestShim(4850m, niCode, PayPeriods.FourWeekly, 2015));

            Assert.AreEqual(0.00m, TestShim(672.29m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(0.01m, TestShim(672.30m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(0.08m, TestShim(676.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(0.09m, TestShim(676.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(420.52m, TestShim(3337.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(420.53m, TestShim(3337.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(420.56m, TestShim(3337.29m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(420.57m, TestShim(3337.30m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(451.33m, TestShim(3532.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(451.34m, TestShim(3532.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(451.37m, TestShim(3532.29m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(451.38m, TestShim(3532.30m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(762.27m, TestShim(5500m, niCode, PayPeriods.Monthly, 2015));

            // I
            niCode = 'K';
            Assert.AreEqual(0.00m, TestShim(112.17m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(112.18m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(112.42m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.02m, TestShim(112.43m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.07m, TestShim(155.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.06m, TestShim(155.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.07m, TestShim(156.17m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.08m, TestShim(156.18m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-5.49m, TestShim(400m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-10.67m, TestShim(770.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-10.66m, TestShim(770.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-9.77m, TestShim(815.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-9.76m, TestShim(815.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-9.73m, TestShim(815.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-9.72m, TestShim(815.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(47.90m, TestShim(1180m, niCode, PayPeriods.Weekly, 2015));

            Assert.AreEqual(0.00m, TestShim(224.17m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-0.01m, TestShim(224.18m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-0.01m, TestShim(224.42m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-0.02m, TestShim(224.43m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-4.13m, TestShim(310.29m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-4.12m, TestShim(310.30m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-4.15m, TestShim(312.17m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-4.16m, TestShim(312.18m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-10.98m, TestShim(800m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-21.34m, TestShim(1540.29m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-21.33m, TestShim(1540.30m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-19.52m, TestShim(1631.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-19.51m, TestShim(1631.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-19.48m, TestShim(1631.29m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-19.47m, TestShim(1631.30m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(124.89m, TestShim(2545m, niCode, PayPeriods.Fortnightly, 2015));

            Assert.AreEqual(0.00m, TestShim(448.17m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(448.18m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(448.42m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-0.02m, TestShim(448.43m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-8.27m, TestShim(620.29m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-8.26m, TestShim(620.30m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-8.32m, TestShim(624.17m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-8.33m, TestShim(624.18m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-21.98m, TestShim(1600m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-42.70m, TestShim(3080.29m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-42.69m, TestShim(3080.30m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-39.08m, TestShim(3261.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-39.07m, TestShim(3261.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-39.04m, TestShim(3261.29m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-39.03m, TestShim(3261.30m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(211.98m, TestShim(4850m, niCode, PayPeriods.FourWeekly, 2015));

            Assert.AreEqual(0.00m, TestShim(486.17m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-0.01m, TestShim(486.18m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-0.01m, TestShim(486.42m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-0.02m, TestShim(486.43m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-8.93m, TestShim(672.29m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-8.92m, TestShim(672.30m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-8.98m, TestShim(676.17m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-8.99m, TestShim(676.18m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-19.12m, TestShim(1400m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-46.23m, TestShim(3337.29m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-46.22m, TestShim(3337.30m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-42.33m, TestShim(3532.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-42.32m, TestShim(3532.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-42.29m, TestShim(3532.29m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-42.28m, TestShim(3532.30m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(268.61m, TestShim(5500m, niCode, PayPeriods.Monthly, 2015));

            // L
            niCode = 'L';
            Assert.AreEqual(0.00m, TestShim(112.17m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(112.18m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(112.42m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.02m, TestShim(112.43m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.07m, TestShim(155.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.06m, TestShim(155.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.07m, TestShim(156.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.06m, TestShim(156.06m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(74.07m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(74.08m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(74.11m, TestShim(770.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(74.12m, TestShim(770.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(81.18m, TestShim(815.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(81.19m, TestShim(815.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(81.22m, TestShim(815.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(81.23m, TestShim(815.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(138.85m, TestShim(1180m, niCode, PayPeriods.Weekly, 2015));

            Assert.AreEqual(0.00m, TestShim(224.17m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-0.01m, TestShim(224.18m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-0.01m, TestShim(224.42m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-0.02m, TestShim(224.43m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-4.13m, TestShim(310.29m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-4.12m, TestShim(310.30m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-4.15m, TestShim(312.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(-4.14m, TestShim(312.06m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(148.12m, TestShim(1540.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(148.13m, TestShim(1540.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(148.16m, TestShim(1540.29m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(148.17m, TestShim(1540.30m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(162.50m, TestShim(1631.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(162.51m, TestShim(1631.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(162.54m, TestShim(1631.29m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(162.55m, TestShim(1631.30m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(306.91m, TestShim(2545m, niCode, PayPeriods.Fortnightly, 2015));

            Assert.AreEqual(0.00m, TestShim(448.17m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(448.18m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(448.42m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-0.02m, TestShim(448.43m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-8.27m, TestShim(620.29m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-8.26m, TestShim(620.30m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-8.32m, TestShim(624.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(-8.31m, TestShim(624.06m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(296.22m, TestShim(3080.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(296.23m, TestShim(3080.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(296.26m, TestShim(3080.29m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(296.27m, TestShim(3080.30m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(324.82m, TestShim(3261.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(324.83m, TestShim(3261.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(324.86m, TestShim(3261.29m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(324.87m, TestShim(3261.30m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(575.88m, TestShim(4850m, niCode, PayPeriods.FourWeekly, 2015));

            Assert.AreEqual(0.00m, TestShim(486.17m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-0.01m, TestShim(486.18m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-0.01m, TestShim(486.42m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-0.02m, TestShim(486.43m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-8.93m, TestShim(672.29m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-8.92m, TestShim(672.30m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-8.98m, TestShim(676.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(-8.97m, TestShim(676.06m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(320.98m, TestShim(3337.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(320.99m, TestShim(3337.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(321.02m, TestShim(3337.29m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(321.03m, TestShim(3337.30m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(351.79m, TestShim(3532.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(351.80m, TestShim(3532.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(351.83m, TestShim(3532.29m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(351.84m, TestShim(3532.30m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(662.73m, TestShim(5500m, niCode, PayPeriods.Monthly, 2015));

            // M
            niCode = 'M';
            Assert.AreEqual(0.00m, TestShim(155.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.01m, TestShim(155.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(73.80m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(73.81m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(79.20m, TestShim(815.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(79.21m, TestShim(815.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(79.24m, TestShim(815.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(79.25m, TestShim(815.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(136.87m, TestShim(1180m, niCode, PayPeriods.Weekly, 2015));

            Assert.AreEqual(0.00m, TestShim(310.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(0.01m, TestShim(310.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(147.60m, TestShim(1540.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(147.61m, TestShim(1540.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(158.52m, TestShim(1631.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(158.53m, TestShim(1631.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(158.56m, TestShim(1631.29m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(158.57m, TestShim(1631.30m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(302.93m, TestShim(2545m, niCode, PayPeriods.Fortnightly, 2015));

            Assert.AreEqual(0.00m, TestShim(620.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(0.01m, TestShim(620.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(295.20m, TestShim(3080.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(295.21m, TestShim(3080.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(316.92m, TestShim(3261.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(316.93m, TestShim(3261.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(316.96m, TestShim(3261.29m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(316.97m, TestShim(3261.30m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(567.98m, TestShim(4850m, niCode, PayPeriods.FourWeekly, 2015));

            Assert.AreEqual(0.00m, TestShim(672.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(0.01m, TestShim(672.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(319.80m, TestShim(3337.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(319.81m, TestShim(3337.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(343.20m, TestShim(3532.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(343.21m, TestShim(3532.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(343.24m, TestShim(3532.29m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(343.25m, TestShim(3532.30m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(654.14m, TestShim(5500m, niCode, PayPeriods.Monthly, 2015));

            // Z
            niCode = 'Z';
            Assert.AreEqual(0.00m, TestShim(155.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.01m, TestShim(155.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(12.30m, TestShim(770.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(12.31m, TestShim(770.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(13.20m, TestShim(815.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(13.21m, TestShim(815.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(13.24m, TestShim(815.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(13.25m, TestShim(815.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(70.87m, TestShim(1180m, niCode, PayPeriods.Weekly, 2015));

            Assert.AreEqual(0.00m, TestShim(310.29m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(0.01m, TestShim(310.30m, niCode, PayPeriods.Fortnightly, 2015));         
            Assert.AreEqual(24.60m, TestShim(1540.29m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(24.61m, TestShim(1540.30m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(26.42m, TestShim(1631.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(26.43m, TestShim(1631.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(26.46m, TestShim(1631.29m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(26.47m, TestShim(1631.30m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(170.83m, TestShim(2545m, niCode, PayPeriods.Fortnightly, 2015));

            Assert.AreEqual(0.00m, TestShim(620.29m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(0.01m, TestShim(620.30m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(49.20m, TestShim(3080.29m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(49.21m, TestShim(3080.30m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(52.82m, TestShim(3261.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(52.83m, TestShim(3261.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(52.86m, TestShim(3261.29m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(52.87m, TestShim(3261.30m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(303.88m, TestShim(4850m, niCode, PayPeriods.FourWeekly, 2015));

            Assert.AreEqual(0.00m, TestShim(672.29m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(0.01m, TestShim(672.30m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(53.30m, TestShim(3337.29m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(53.31m, TestShim(3337.30m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(57.20m, TestShim(3532.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(57.21m, TestShim(3532.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(57.24m, TestShim(3532.29m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(57.25m, TestShim(3532.30m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(368.14m, TestShim(5500m, niCode, PayPeriods.Monthly, 2015));
        }
    }
}
