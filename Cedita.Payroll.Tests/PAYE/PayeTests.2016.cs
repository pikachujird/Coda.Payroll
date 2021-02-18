// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cedita.Payroll.Tests
{
    public partial class PayeTests
    {
        [TestCategory("PAYE Tests"), TestMethod]
        public void PayeCalculations2016()
        {
            // General Tax Rate
            Assert.AreEqual(0m, LegacyShim(39.24m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(0.20m, LegacyShim(39.25m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(533.20m, LegacyShim(2705.24m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(533.40m, LegacyShim(2705.25m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(533.46m, LegacyShim(2705.26m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(4466.26m, LegacyShim(12538.24m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(4466.66m, LegacyShim(12538.25m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(4466.66m, LegacyShim(12538.26m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(4467.11m, LegacyShim(12539.25m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2016));

            Assert.AreEqual(123m, LegacyShim(624.82m, "45L", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(123.20m, LegacyShim(624.83m, "45L", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(123.32m, LegacyShim(624.84m, "45L", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(1030.52m, LegacyShim(2893.82m, "45L", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(1030.92m, LegacyShim(2893.83m, "45L", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(1030.94m, LegacyShim(2893.84m, "45L", PayPeriods.Weekly, 1, 0, 0, false, 2016));

            // Large Tax Code
            Assert.AreEqual(316.20m, LegacyShim(2000m, "501L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(253.20m, LegacyShim(2100m, "999L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(283m, LegacyShim(2250m, "1000L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(283m, LegacyShim(2250m, "1001L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(261m, LegacyShim(2612m, "1567L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(216.60m, LegacyShim(2750m, "1999L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(333m, LegacyShim(3333.33m, "2000L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(333m, LegacyShim(3333.33m, "2001L", PayPeriods.Monthly, 1, 0, 0, false, 2016));

            Assert.AreEqual(80.60m, LegacyShim(500m, "501L", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(129.72m, LegacyShim(825m, "999L", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(129.72m, LegacyShim(825m, "1000L", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(129.72m, LegacyShim(825m, "1001L", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(39.60m, LegacyShim(500m, "1567L", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(88m, LegacyShim(825m, "1999L", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(88m, LegacyShim(825m, "2000L", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(88.2m, LegacyShim(827m, "2001L", PayPeriods.Weekly, 1, 0, 0, false, 2016));

            // Tax Code L
            // Test 1
            Assert.AreEqual(5574.11m, LegacyShim(15000m, "45L", PayPeriods.Monthly, 1, 0, 0, true, 2016));
            Assert.AreEqual(48.2m, LegacyShim(280m, "45L", PayPeriods.Monthly, 2, 15000m, 5574.11m, true, 2016));
            Assert.AreEqual(-1044.31m, LegacyShim(280m, "45L", PayPeriods.Monthly, 3, 15280m, 5622.31m, false, 2016));
            // Test 2
            Assert.AreEqual(92.20m, LegacyShim(500m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(152.20m, LegacyShim(800m, "45L", PayPeriods.Monthly, 2, 500m, 92.20m, true, 2016));
            // Test 3
            Assert.AreEqual(94.20m, LegacyShim(471m, "BR", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(84.60m, LegacyShim(500m, "45L", PayPeriods.Monthly, 2, 471m, 94.20m, false, 2016));
            // Test 4
            Assert.AreEqual(92.20m, LegacyShim(500m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(125.40m, LegacyShim(627m, "BR", PayPeriods.Monthly, 2, 500m, 92.20m, true, 2016));
            // Test 5
            Assert.AreEqual(92.20m, LegacyShim(500m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(98.80m, LegacyShim(623.23m, "100L", PayPeriods.Monthly, 2, 500m, 92.20m, false, 2016));
            // Test 6
            Assert.AreEqual(83m, LegacyShim(500m, "100L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(-0.80m, LegacyShim(80m, "100L", PayPeriods.Monthly, 2, 500m, 83m, false, 2016));
            // Test 7
            Assert.AreEqual(96m, LegacyShim(500m, "100L", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(96.20m, LegacyShim(500m, "100L", PayPeriods.Weekly, 2, 500m, 96m, false, 2016));

            // Tax Code D0
            // Test 1
            Assert.AreEqual(5600m, LegacyShim(14000.53m, "D0", PayPeriods.Monthly, 1, 0, 0, true, 2016));
            Assert.AreEqual(480m, LegacyShim(1200m, "D0", PayPeriods.Monthly, 2, 14000.53m, 5600, true, 2016));
            // Test 2
            Assert.AreEqual(100m, LegacyShim(250m, "D0", PayPeriods.Weekly, 1, 0, 0, true, 2016));
            Assert.AreEqual(-34.80m, LegacyShim(250m, "450L", PayPeriods.Weekly, 2, 250m, 100m, false, 2016));
            // Test 3
            Assert.AreEqual(32.60m, LegacyShim(250m, "450L", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(100m, LegacyShim(250m, "D0", PayPeriods.Weekly, 2, 250m, 32.60m, true, 2016));
            // Test 4
            Assert.AreEqual(280m, LegacyShim(700.77m, "D0", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(6000m, LegacyShim(15000m, "D0", PayPeriods.Monthly, 2, 700.77m, 280m, false, 2016));
            Assert.AreEqual(6000m, LegacyShim(15000m, "D0", PayPeriods.Monthly, 3, 15700.77m, 6280m, false, 2016));
            Assert.AreEqual(6000m, LegacyShim(15000m, "D0", PayPeriods.Monthly, 4, 30700.77m, 12280m, false, 2016));
            // Test 5
            Assert.AreEqual(200m, LegacyShim(500.22m, "D0", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(240m, LegacyShim(600.37m, "D0", PayPeriods.Weekly, 2, 500.22m, 200m, false, 2016));
            Assert.AreEqual(320m, LegacyShim(799.90m, "D0", PayPeriods.Weekly, 3, 1100.59m, 440m, false, 2016));
            Assert.AreEqual(320.40m, LegacyShim(801.10m, "D0", PayPeriods.Weekly, 4, 1900.49m, 760m, false, 2016));

            // Tax Code D1
            // Test 1
            Assert.AreEqual(6300m, LegacyShim(14000.53m, "D1", PayPeriods.Monthly, 1, 0, 0, true, 2016));
            Assert.AreEqual(540m, LegacyShim(1200m, "D1", PayPeriods.Monthly, 2, 14000.53m, 6300, true, 2016));
            // Test 2
            Assert.AreEqual(112.50m, LegacyShim(250m, "D1", PayPeriods.Weekly, 1, 0, 0, true, 2016));
            Assert.AreEqual(-47.30m, LegacyShim(250m, "450L", PayPeriods.Weekly, 2, 250m, 112.50m, false, 2016));
            // Test 3
            Assert.AreEqual(32.60m, LegacyShim(250m, "450L", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(112.50m, LegacyShim(250m, "D1", PayPeriods.Weekly, 2, 250m, 32.60m, true, 2016));
            // Test 4
            Assert.AreEqual(315m, LegacyShim(700.77m, "D1", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(6750m, LegacyShim(15000m, "D1", PayPeriods.Monthly, 2, 700.77m, 315m, false, 2016));
            Assert.AreEqual(6750m, LegacyShim(15000m, "D1", PayPeriods.Monthly, 3, 15700.77m, 7065m, false, 2016));
            Assert.AreEqual(6750m, LegacyShim(15000m, "D1", PayPeriods.Monthly, 4, 30700.77m, 13815m, false, 2016));
            // Test 5
            Assert.AreEqual(225m, LegacyShim(500.22m, "D1", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(270m, LegacyShim(600.37m, "D1", PayPeriods.Weekly, 2, 500.22m, 225m, false, 2016));
            Assert.AreEqual(360m, LegacyShim(799.90m, "D1", PayPeriods.Weekly, 3, 1100.59m, 495m, false, 2016));
            Assert.AreEqual(360.45m, LegacyShim(801.10m, "D1", PayPeriods.Weekly, 4, 1900.49m, 855m, false, 2016));

            // Tax Code BR
            Assert.AreEqual(24m, LegacyShim(120m, "BR", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(24m, LegacyShim(120.99m, "BR", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(100m, LegacyShim(500m, "BR", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(3000m, LegacyShim(15000m, "BR", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            // Test 5
            Assert.AreEqual(134m, LegacyShim(670m, "BR", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(148m, LegacyShim(740m, "BR", PayPeriods.Monthly, 2, 670m, 134m, false, 2016));
            // Test 6
            Assert.AreEqual(110m, LegacyShim(550m, "BR", PayPeriods.Monthly, 1, 0, 0, true, 2016));
            Assert.AreEqual(110m, LegacyShim(550m, "BR", PayPeriods.Monthly, 2, 550m, 110m, true, 2016));
            // Test 7
            Assert.AreEqual(120m, LegacyShim(600.24m, "BR", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(166.4m, LegacyShim(1500m, "400L", PayPeriods.Monthly, 2, 600.24m, 120m, false, 2016));
            // Test 8
            Assert.AreEqual(233m, LegacyShim(1500m, "400L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(300m, LegacyShim(1500.33m, "BR", PayPeriods.Monthly, 2, 1500m, 233m, true, 2016));
            // Test 9
            Assert.AreEqual(115m, LegacyShim(575m, "BR", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(96m, LegacyShim(480m, "BR", PayPeriods.Weekly, 2, 575m, 115m, false, 2016));

            // Tax Code NT
            Assert.AreEqual(0m, LegacyShim(500m, "NT", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            // Test 2
            Assert.AreEqual(0m, LegacyShim(500m, "NT", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(133m, LegacyShim(1000m, "400L", PayPeriods.Monthly, 2, 500, 0, true, 2016));
            // Test 3
            Assert.AreEqual(87m, LegacyShim(770m, "400L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(-87m, LegacyShim(770m, "NT", PayPeriods.Monthly, 2, 770, 87, false, 2016));
            // Test 4
            Assert.AreEqual(0m, LegacyShim(770m, "NT", PayPeriods.Monthly, 1, 0, 0, true, 2016));
            Assert.AreEqual(33m, LegacyShim(500m, "400L", PayPeriods.Monthly, 2, 770, 0, true, 2016));
            // Test 5
            Assert.AreEqual(84.40m, LegacyShim(500m, "400L", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(0m, LegacyShim(770m, "NT", PayPeriods.Weekly, 2, 770, 84.40m, true, 2016));

            // Tax Code 0T
            // Test 1
            Assert.AreEqual(25m, LegacyShim(125m, "0T", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(200m, LegacyShim(1000m, "0T", PayPeriods.Monthly, 2, 125m, 25m, false, 2016));
            // Test 2
            Assert.AreEqual(170m, LegacyShim(850m, "0T", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(40.20m, LegacyShim(1050m, "508L", PayPeriods.Monthly, 2, 850m, 170m, false, 2016));
            // Test 3
            Assert.AreEqual(125m, LegacyShim(1050m, "508L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(210m, LegacyShim(1050m, "0T", PayPeriods.Monthly, 2, 1050m, 125m, true, 2016));
            // Test 4
            Assert.AreEqual(93m, LegacyShim(465m, "0T", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(97m, LegacyShim(485m, "0T", PayPeriods.Weekly, 2, 465m, 93m, false, 2016));
            // Test 5
            Assert.AreEqual(95m, LegacyShim(475m, "0T", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(95m, LegacyShim(475m, "0T", PayPeriods.Weekly, 2, 475, 95m, false, 2016));

            // Tax Code K
            // Test 1
            Assert.AreEqual(173.2m, LegacyShim(510m, "K427", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(198m, LegacyShim(633.22m, "K427", PayPeriods.Monthly, 2, 510m, 173.20m, false, 2016));
            // Test 2
            Assert.AreEqual(193.2m, LegacyShim(610m, "K427", PayPeriods.Monthly, 1, 0, 0, true, 2016));
            Assert.AreEqual(207.8m, LegacyShim(683.22m, "K427", PayPeriods.Monthly, 2, 610m, 193.20m, true, 2016));
            // Test 3
            Assert.AreEqual(173.20m, LegacyShim(510m, "K427", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(32.50m, LegacyShim(65m, "K427", PayPeriods.Monthly, 2, 510m, 173.20m, false, 2016));
            Assert.AreEqual(225.10m, LegacyShim(510m, "K427", PayPeriods.Monthly, 3, 575m, 205.70m, false, 2016));
            // Test 4
            Assert.AreEqual(189.60m, LegacyShim(600m, "K417", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(30.40m, LegacyShim(500m, "0T", PayPeriods.Monthly, 2, 600m, 189.60m, false, 2016));
            // Test 5
            Assert.AreEqual(150m, LegacyShim(750m, "0T", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(170.2m, LegacyShim(500m, "K421", PayPeriods.Monthly, 2, 750m, 150m, true, 2016));
            // Test 6
            Assert.AreEqual(5m, LegacyShim(15m, "K55", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(18.2m, LegacyShim(80m, "K55", PayPeriods.Weekly, 2, 15m, 5m, false, 2016));
            Assert.AreEqual(302.2m, LegacyShim(1500m, "K55", PayPeriods.Weekly, 3, 95m, 23.20m, false, 2016));

            // 50% Regulatory Limit (New for 2015/16 tests)
            // Test 1
            Assert.AreEqual(49.80m, LegacyShim(1000m, "900L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(224.60m, LegacyShim(449.22m, "45L", PayPeriods.Monthly, 2, 1000m, 49.80m, false, 2016));
            // Test 2
            Assert.AreEqual(49.80m, LegacyShim(1000m, "900L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(224.60m, LegacyShim(449.20m, "45L", PayPeriods.Monthly, 2, 1000m, 49.80m, false, 2016));
            // Test 3
            Assert.AreEqual(49.80m, LegacyShim(1000m, "900L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(224.59m, LegacyShim(449.18m, "45L", PayPeriods.Monthly, 2, 1000m, 49.80m, false, 2016));
            Assert.AreEqual(92.41m, LegacyShim(500m, "45L", PayPeriods.Monthly, 3, 1449.18m, 274.39m, false, 2016));
            // Test 4
            Assert.AreEqual(238.12m, LegacyShim(1000m, "500L", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(150m, LegacyShim(300m, "D0", PayPeriods.Weekly, 2, 1000m, 238.12m, false, 2016));
            Assert.AreEqual(400m, LegacyShim(1000m, "D0", PayPeriods.Weekly, 3, 1300m, 388.12m, true, 2016));
            // Test 5
            Assert.AreEqual(242.12m, LegacyShim(1000m, "450L", PayPeriods.Weekly, 1, 0, 0, true, 2016));
            Assert.AreEqual(500m, LegacyShim(1000m, "D1", PayPeriods.Weekly, 2, 1000m, 242.12m, false, 2016));
            Assert.AreEqual(250.40m, LegacyShim(500.80m, "D1", PayPeriods.Weekly, 3, 2000m, 742.12m, false, 2016));
            Assert.AreEqual(22632.48m, LegacyShim(50000m, "D1", PayPeriods.Weekly, 4, 2500.80m, 992.52m, false, 2016));

            // Weekly 20% Bandwidth Tests
            Assert.AreEqual(5.80m, LegacyShim(120m, "470L", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(5.80m, LegacyShim(120m, "470L", PayPeriods.Weekly, 2, 120m, 5.8m, false, 2016));
            Assert.AreEqual(6m, LegacyShim(120m, "470L", PayPeriods.Weekly, 3, 240m, 11.60m, false, 2016));
            Assert.AreEqual(5.80m, LegacyShim(120m, "470L", PayPeriods.Weekly, 4, 360m, 17.60m, false, 2016));
            Assert.AreEqual(6m, LegacyShim(120m, "470L", PayPeriods.Weekly, 5, 480m, 23.40m, false, 2016));
            Assert.AreEqual(5.80m, LegacyShim(120m, "470L", PayPeriods.Weekly, 6, 600m, 29.4m, false, 2016));
            Assert.AreEqual(6m, LegacyShim(120m, "470L", PayPeriods.Weekly, 7, 720m, 35.2m, false, 2016));
            Assert.AreEqual(5.80m, LegacyShim(120m, "470L", PayPeriods.Weekly, 8, 840m, 41.2m, false, 2016));

            // Weekly 40% Bandwidth Tests
            Assert.AreEqual(465.72m, LegacyShim(1500.63m, "145L", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(466.12m, LegacyShim(1500.63m, "145L", PayPeriods.Weekly, 2, 1500.63m * 1, 465.72m, false, 2016));
            Assert.AreEqual(465.72m, LegacyShim(1500.63m, "145L", PayPeriods.Weekly, 3, 1500.63m * 2, 931.84m, false, 2016));
            Assert.AreEqual(466.13m, LegacyShim(1500.63m, "145L", PayPeriods.Weekly, 4, 1500.63m * 3, 1397.56m, false, 2016));
            Assert.AreEqual(465.72m, LegacyShim(1500.63m, "145L", PayPeriods.Weekly, 5, 1500.63m * 4, 1863.69m, false, 2016));
            Assert.AreEqual(466.12m, LegacyShim(1500.63m, "145L", PayPeriods.Weekly, 6, 1500.63m * 5, 2329.41m, false, 2016));
            Assert.AreEqual(465.73m, LegacyShim(1500.63m, "145L", PayPeriods.Weekly, 7, 1500.63m * 6, 2795.53m, false, 2016));
            Assert.AreEqual(466.12m, LegacyShim(1500.63m, "145L", PayPeriods.Weekly, 8, 1500.63m * 7, 3261.26m, false, 2016));

            // Weekly 45% Bandwidth Tests
            Assert.AreEqual(1051.64m, LegacyShim(3010.77m, "412L", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(1051.64m, LegacyShim(3010.77m, "412L", PayPeriods.Weekly, 2, 3010.77m * 1, 1051.64m, false, 2016));
            Assert.AreEqual(1052.09m, LegacyShim(3010.77m, "412L", PayPeriods.Weekly, 3, 3010.77m * 2, 2103.28m, false, 2016));
            Assert.AreEqual(1051.64m, LegacyShim(3010.77m, "412L", PayPeriods.Weekly, 4, 3010.77m * 3, 3155.37m, false, 2016));
            Assert.AreEqual(1051.65m, LegacyShim(3010.77m, "412L", PayPeriods.Weekly, 5, 3010.77m * 4, 4207.01m, false, 2016));
            Assert.AreEqual(1052.09m, LegacyShim(3010.77m, "412L", PayPeriods.Weekly, 6, 3010.77m * 5, 5258.66m, false, 2016));
            Assert.AreEqual(1051.64m, LegacyShim(3010.77m, "412L", PayPeriods.Weekly, 7, 3010.77m * 6, 6310.75m, false, 2016));
            Assert.AreEqual(1051.64m, LegacyShim(3010.77m, "412L", PayPeriods.Weekly, 8, 3010.77m * 7, 7362.39m, false, 2016));

            // Weekly Variable Pay
            Assert.AreEqual(0m, LegacyShim(0, "500L", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(21.40m, LegacyShim(300m, "500L", PayPeriods.Weekly, 2, 0, 0, false, 2016));
            Assert.AreEqual(3681.62m, LegacyShim(10000m, "500L", PayPeriods.Weekly, 3, 300m, 21.40m, false, 2016));
            Assert.AreEqual(2299.04m, LegacyShim(5800m, "500L", PayPeriods.Weekly, 4, 10300m, 3703.02m, false, 2016));
            Assert.AreEqual(-265.50m, LegacyShim(100m, "500L", PayPeriods.Weekly, 5, 16100m, 6002.06m, false, 2016));
            Assert.AreEqual(1032.74m, LegacyShim(2985m, "500L", PayPeriods.Weekly, 6, 16200m, 5736.56m, false, 2016));
            Assert.AreEqual(125m, LegacyShim(250m, "10L", PayPeriods.Weekly, 7, 19185m, 6769.30m, false, 2016));
            Assert.AreEqual(88.28m, LegacyShim(500m, "10L", PayPeriods.Weekly, 8, 19435m, 6894.30m, false, 2016));

            // Weekly 50% Regulatory Limit
            Assert.AreEqual(0m, LegacyShim(5000m, "NT", PayPeriods.Weekly, 1, 0, 0, false, 2016));
            Assert.AreEqual(250m, LegacyShim(500m, "D0", PayPeriods.Weekly, 2, 5000m, 0, false, 2016));
            Assert.AreEqual(280m, LegacyShim(700m, "D0", PayPeriods.Weekly, 3, 5500m, 250m, true, 2016));
            Assert.AreEqual(400m, LegacyShim(800m, "D1", PayPeriods.Weekly, 4, 6200m, 530m, false, 2016));
            Assert.AreEqual(180m, LegacyShim(400m, "D1", PayPeriods.Weekly, 5, 7000m, 930m, true, 2016));
            Assert.AreEqual(250m, LegacyShim(500m, "BR", PayPeriods.Weekly, 6, 7400m, 1110m, false, 2016));
            Assert.AreEqual(250m, LegacyShim(500m, "BR", PayPeriods.Weekly, 7, 7900m, 1360m, false, 2016));
            Assert.AreEqual(100m, LegacyShim(500m, "BR", PayPeriods.Weekly, 8, 8400m, 1610m, true, 2016));
            Assert.AreEqual(100m, LegacyShim(500m, "0T", PayPeriods.Weekly, 9, 8900m, 1710m, true, 2016));
            Assert.AreEqual(2500m, LegacyShim(5000m, "0T", PayPeriods.Weekly, 10, 9400m, 1810m, false, 2016));
            Assert.AreEqual(1096.15m, LegacyShim(2500m, "0T", PayPeriods.Weekly, 11, 14400m, 4310m, false, 2016));
            Assert.AreEqual(76.92m, LegacyShim(500m, "0T", PayPeriods.Weekly, 12, 16900m, 5406.15m, false, 2016));

            // Monthly 20% Bandwidth Tests
            Assert.AreEqual(21.80m, LegacyShim(452m, "410L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(22m, LegacyShim(452m, "410L", PayPeriods.Monthly, 2, 452m * 1, 21.8m, false, 2016));
            Assert.AreEqual(21.80m, LegacyShim(452m, "410L", PayPeriods.Monthly, 3, 452m * 2, 43.8m, false, 2016));
            Assert.AreEqual(22m, LegacyShim(452m, "410L", PayPeriods.Monthly, 4, 452m * 3, 65.6m, false, 2016));
            Assert.AreEqual(21.80m, LegacyShim(452m, "410L", PayPeriods.Monthly, 5, 452m * 4, 87.6m, false, 2016));
            Assert.AreEqual(22m, LegacyShim(452m, "410L", PayPeriods.Monthly, 6, 452m * 5, 109.4m, false, 2016));
            Assert.AreEqual(22m, LegacyShim(452m, "410L", PayPeriods.Monthly, 7, 452m * 6, 131.4m, false, 2016));
            Assert.AreEqual(21.80m, LegacyShim(452m, "410L", PayPeriods.Monthly, 8, 452m * 7, 153.4m, false, 2016));
            Assert.AreEqual(22m, LegacyShim(452m, "410L", PayPeriods.Monthly, 9, 452m * 8, 175.2m, false, 2016));
            Assert.AreEqual(21.80m, LegacyShim(452m, "410L", PayPeriods.Monthly, 10, 452m * 9, 197.2m, false, 2016));
            Assert.AreEqual(22m, LegacyShim(452m, "410L", PayPeriods.Monthly, 11, 452m * 10, 219m, false, 2016));
            Assert.AreEqual(21.80m, LegacyShim(452m, "410L", PayPeriods.Monthly, 12, 452m * 11, 241m, false, 2016));

            // Monthly 40% Bandwidth Tests
            Assert.AreEqual(865.06m, LegacyShim(3856m, "430L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(865.47m, LegacyShim(3856m, "430L", PayPeriods.Monthly, 2, 3856m * 1, 865.06m, false, 2016));
            Assert.AreEqual(865.47m, LegacyShim(3856m, "430L", PayPeriods.Monthly, 3, 3856m * 2, 1730.53m, false, 2016));
            Assert.AreEqual(865.46m, LegacyShim(3856m, "430L", PayPeriods.Monthly, 4, 3856m * 3, 2596.00m, false, 2016));
            Assert.AreEqual(865.47m, LegacyShim(3856m, "430L", PayPeriods.Monthly, 5, 3856m * 4, 3461.46m, false, 2016));
            Assert.AreEqual(865.47m, LegacyShim(3856m, "430L", PayPeriods.Monthly, 6, 3856m * 5, 4326.93m, false, 2016));
            Assert.AreEqual(865.46m, LegacyShim(3856m, "430L", PayPeriods.Monthly, 7, 3856m * 6, 5192.40m, false, 2016));
            Assert.AreEqual(865.47m, LegacyShim(3856m, "430L", PayPeriods.Monthly, 8, 3856m * 7, 6057.86m, false, 2016));
            Assert.AreEqual(865.47m, LegacyShim(3856m, "430L", PayPeriods.Monthly, 9, 3856m * 8, 6923.33m, false, 2016));
            Assert.AreEqual(865.46m, LegacyShim(3856m, "430L", PayPeriods.Monthly, 10, 3856m * 9, 7788.80m, false, 2016));
            Assert.AreEqual(865.47m, LegacyShim(3856m, "430L", PayPeriods.Monthly, 11, 3856m * 10, 8654.26m, false, 2016));
            Assert.AreEqual(865.07m, LegacyShim(3856m, "430L", PayPeriods.Monthly, 12, 3856m * 11, 9519.73m, false, 2016));

            // Monthly 45% Bandwidth Tests
            Assert.AreEqual(5580.41m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(5580.42m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 2, 15000.81m * 1, 5580.41m, false, 2016));
            Assert.AreEqual(5580.42m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 3, 15000.81m * 2, 11160.83m, false, 2016));
            Assert.AreEqual(5580.41m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 4, 15000.81m * 3, 16741.25m, false, 2016));
            Assert.AreEqual(5580.42m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 5, 15000.81m * 4, 22321.66m, false, 2016));
            Assert.AreEqual(5580.42m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 6, 15000.81m * 5, 27902.08m, false, 2016));
            Assert.AreEqual(5580.41m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 7, 15000.81m * 6, 33482.50m, false, 2016));
            Assert.AreEqual(5580.42m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 8, 15000.81m * 7, 39062.91m, false, 2016));
            Assert.AreEqual(5580.42m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 9, 15000.81m * 8, 44643.33m, false, 2016));
            Assert.AreEqual(5580.41m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 10, 15000.81m * 9, 50223.75m, false, 2016));
            Assert.AreEqual(5580.42m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 11, 15000.81m * 10, 55804.16m, false, 2016));
            Assert.AreEqual(5580.42m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 12, 15000.81m * 11, 61384.58m, false, 2016));

            // Monthly Variable Pay
            Assert.AreEqual(49.80m, LegacyShim(1000m, "900L", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(224.59m, LegacyShim(449.18m, "45L", PayPeriods.Monthly, 2, 1000m, 49.80m, false, 2016));
            Assert.AreEqual(92.41m, LegacyShim(500.56m, "45L", PayPeriods.Monthly, 3, 1449.18m, 274.39m, false, 2016));
            Assert.AreEqual(-306.80m, LegacyShim(1500m, "944L", PayPeriods.Monthly, 4, 1949.74m, 366.80m, false, 2016));
            Assert.AreEqual(-57.40m, LegacyShim(500.77m, "944L", PayPeriods.Monthly, 5, 3449.74m, 60m, false, 2016));
            Assert.AreEqual(3042.60m, LegacyShim(16000.30m, "944L", PayPeriods.Monthly, 6, 3950.51m, 2.60m, false, 2016));
            Assert.AreEqual(996.66m, LegacyShim(5000m, "944L", PayPeriods.Monthly, 7, 19950.81m, 3045.20m, false, 2016));
            Assert.AreEqual(4592.27m, LegacyShim(13600.99m, "944L", PayPeriods.Monthly, 8, 24950.81m, 4041.86m, false, 2016));
            Assert.AreEqual(351.87m, LegacyShim(3000m, "944L", PayPeriods.Monthly, 9, 38551.80m, 8634.13m, false, 2016));
            Assert.AreEqual(-848.54m, LegacyShim(0m, "944L", PayPeriods.Monthly, 10, 41551.80m, 8986.00m, false, 2016));
            Assert.AreEqual(47921.37m, LegacyShim(120000m, "944L", PayPeriods.Monthly, 11, 41551.80m, 8137.46m, false, 2016));
            Assert.AreEqual(-1062.48m, LegacyShim(1000.46m, "944L", PayPeriods.Monthly, 12, 161551.80m, 56058.83m, false, 2016));

            // Monthly 50% Regulatory Limit
            Assert.AreEqual(0m, LegacyShim(5000m, "NT", PayPeriods.Monthly, 1, 0, 0, false, 2016));
            Assert.AreEqual(250m, LegacyShim(500m, "D0", PayPeriods.Monthly, 2, 5000m, 0, false, 2016));
            Assert.AreEqual(280m, LegacyShim(700m, "D0", PayPeriods.Monthly, 3, 5500m, 250m, true, 2016));
            Assert.AreEqual(400m, LegacyShim(800m, "D1", PayPeriods.Monthly, 4, 6200m, 530m, false, 2016));
            Assert.AreEqual(180m, LegacyShim(400m, "D1", PayPeriods.Monthly, 5, 7000m, 930m, true, 2016));
            Assert.AreEqual(250m, LegacyShim(500m, "BR", PayPeriods.Monthly, 6, 7400m, 1110m, false, 2016));
            Assert.AreEqual(250m, LegacyShim(500m, "BR", PayPeriods.Monthly, 7, 7900m, 1360m, false, 2016));
            Assert.AreEqual(100m, LegacyShim(500m, "BR", PayPeriods.Monthly, 8, 8400m, 1610m, true, 2016));
            Assert.AreEqual(100m, LegacyShim(500m, "0T", PayPeriods.Monthly, 9, 8900m, 1710m, true, 2016));
            Assert.AreEqual(1070m, LegacyShim(5000m, "0T", PayPeriods.Monthly, 10, 9400m, 1810m, false, 2016));
            Assert.AreEqual(500m, LegacyShim(2500m, "0T", PayPeriods.Monthly, 11, 14400m, 2880m, false, 2016));
            Assert.AreEqual(100m, LegacyShim(500m, "0T", PayPeriods.Monthly, 12, 16900m, 3380m, false, 2016));
        }
    }
}
