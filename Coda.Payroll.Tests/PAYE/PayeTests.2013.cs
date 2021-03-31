﻿// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coda.Payroll.Tests
{
    public partial class PayeTests
    {
        [TestCategory("PAYE Tests"), TestMethod]
        public void PayeCalculations2013()
        {
            Assert.AreEqual(43.60m, LegacyShim(400, "944L", PayPeriods.Weekly, 1, 0, 0, false, 2013));

            Assert.AreEqual(116.20m, LegacyShim(400, "K944", PayPeriods.Weekly, 1, 0, 0, false, 2013));
            Assert.AreEqual(118.40m, LegacyShim(400, "K1000", PayPeriods.Weekly, 1, 0, 0, false, 2013));
            Assert.AreEqual(190.48m, LegacyShim(400, "K2000", PayPeriods.Weekly, 1, 0, 0, false, 2013));
            Assert.AreEqual(200m, LegacyShim(400, "K3000", PayPeriods.Weekly, 1, 0, 0, false, 2013));
            Assert.AreEqual(200m, LegacyShim(400, "K4000", PayPeriods.Weekly, 1, 0, 0, false, 2013));

            Assert.AreEqual(80m, LegacyShim(400, "BR", PayPeriods.Weekly, 1, 0, 0, false, 2013));
            Assert.AreEqual(160m, LegacyShim(400, "D0", PayPeriods.Weekly, 1, 0, 0, false, 2013));
            Assert.AreEqual(180m, LegacyShim(400, "D1", PayPeriods.Weekly, 1, 0, 0, false, 2013));
            Assert.AreEqual(0m, LegacyShim(400, "NT", PayPeriods.Weekly, 1, 0, 0, false, 2013));

            Assert.AreEqual(5573.95m, LegacyShim(15000.00m, "45L", PayPeriods.Monthly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(48.20m, LegacyShim(280.00m, "45L", PayPeriods.Monthly, 2, 15000.00m, 5573.95m, true, 2013));
            Assert.AreEqual(-1044.65m, LegacyShim(280.00m, "45L", PayPeriods.Monthly, 3, 15280.00m, 5622.15m, false, 2013));
            Assert.AreEqual(92.20m, LegacyShim(500.00m, "45L", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(152.20m, LegacyShim(800.00m, "45L", PayPeriods.Monthly, 2, 500.00m, 92.20m, true, 2013));
            Assert.AreEqual(94.20m, LegacyShim(471.00m, "BR", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(84.60m, LegacyShim(500.00m, "45L", PayPeriods.Monthly, 2, 471.00m, 94.20m, false, 2013));
            Assert.AreEqual(92.20m, LegacyShim(500.00m, "45L", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(125.40m, LegacyShim(627.00m, "BR", PayPeriods.Monthly, 2, 500.00m, 92.20m, true, 2013));
            Assert.AreEqual(92.20m, LegacyShim(500.00m, "45L", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(98.80m, LegacyShim(623.23m, "100L", PayPeriods.Monthly, 2, 500.00m, 92.20m, false, 2013));
            Assert.AreEqual(83.00m, LegacyShim(500.00m, "100L", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(-0.80m, LegacyShim(80.00m, "100L", PayPeriods.Monthly, 2, 500.00m, 83.00m, false, 2013));
            Assert.AreEqual(96.00m, LegacyShim(500.00m, "100L", PayPeriods.Weekly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(96.20m, LegacyShim(500.00m, "100L", PayPeriods.Weekly, 2, 500.00m, 96.00m, false, 2013));
            Assert.AreEqual(5600.00m, LegacyShim(14000.53m, "D0", PayPeriods.Monthly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(480.00m, LegacyShim(1200.00m, "D0", PayPeriods.Monthly, 2, 14000.53m, 5600.00m, true, 2013));
            Assert.AreEqual(100.00m, LegacyShim(250.00m, "D0", PayPeriods.Weekly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(-34.80m, LegacyShim(250.00m, "450L", PayPeriods.Weekly, 2, 250.00m, 100.00m, false, 2013));
            Assert.AreEqual(32.60m, LegacyShim(250.00m, "450L", PayPeriods.Weekly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(100.00m, LegacyShim(250.00m, "D0", PayPeriods.Weekly, 2, 250.00m, 32.60m, true, 2013));
            Assert.AreEqual(280.00m, LegacyShim(700.77m, "D0", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(6000.00m, LegacyShim(15000.00m, "D0", PayPeriods.Monthly, 2, 700.77m, 280.00m, false, 2013));
            Assert.AreEqual(6000.00m, LegacyShim(15000.00m, "D0", PayPeriods.Monthly, 3, 15700.77m, 6280.00m, false, 2013));
            Assert.AreEqual(6000.00m, LegacyShim(15000.00m, "D0", PayPeriods.Monthly, 4, 30700.77m, 12280.00m, false, 2013));
            Assert.AreEqual(200.00m, LegacyShim(500.22m, "D0", PayPeriods.Weekly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(240.00m, LegacyShim(600.37m, "D0", PayPeriods.Weekly, 2, 500.22m, 200.00m, false, 2013));
            Assert.AreEqual(320.00m, LegacyShim(799.90m, "D0", PayPeriods.Weekly, 3, 1100.59m, 440.00m, false, 2013));
            Assert.AreEqual(320.40m, LegacyShim(801.10m, "D0", PayPeriods.Weekly, 4, 1900.49m, 760.00m, false, 2013));
            Assert.AreEqual(6300.00m, LegacyShim(14000.53m, "D1", PayPeriods.Monthly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(540.00m, LegacyShim(1200.00m, "D1", PayPeriods.Monthly, 2, 14000.53m, 6300.00m, true, 2013));
            Assert.AreEqual(112.50m, LegacyShim(250.00m, "D1", PayPeriods.Weekly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(-47.30m, LegacyShim(250.00m, "450L", PayPeriods.Weekly, 2, 250.00m, 112.50m, false, 2013));
            Assert.AreEqual(32.60m, LegacyShim(250.00m, "450L", PayPeriods.Weekly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(112.50m, LegacyShim(250.00m, "D1", PayPeriods.Weekly, 2, 250.00m, 32.60m, true, 2013));
            Assert.AreEqual(315.00m, LegacyShim(700.77m, "D1", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(6750.00m, LegacyShim(15000.00m, "D1", PayPeriods.Monthly, 2, 700.77m, 315.00m, false, 2013));
            Assert.AreEqual(6750.00m, LegacyShim(15000.00m, "D1", PayPeriods.Monthly, 3, 15700.77m, 7065.00m, false, 2013));
            Assert.AreEqual(6750.00m, LegacyShim(15000.00m, "D1", PayPeriods.Monthly, 4, 30700.77m, 13815.00m, false, 2013));
            Assert.AreEqual(225.00m, LegacyShim(500.22m, "D1", PayPeriods.Weekly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(270.00m, LegacyShim(600.37m, "D1", PayPeriods.Weekly, 2, 500.22m, 225.00m, false, 2013));
            Assert.AreEqual(360.00m, LegacyShim(799.90m, "D1", PayPeriods.Weekly, 3, 1100.59m, 495.00m, false, 2013));
            Assert.AreEqual(360.45m, LegacyShim(801.10m, "D1", PayPeriods.Weekly, 4, 1900.49m, 855.00m, false, 2013));
            Assert.AreEqual(24.00m, LegacyShim(120.00m, "BR", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(24.00m, LegacyShim(120.99m, "BR", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(100.00m, LegacyShim(500.00m, "BR", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(3000.00m, LegacyShim(15000.00m, "BR", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(134.00m, LegacyShim(670.00m, "BR", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(148.00m, LegacyShim(740.00m, "BR", PayPeriods.Monthly, 2, 670.00m, 134.00m, false, 2013));
            Assert.AreEqual(110.00m, LegacyShim(550.00m, "BR", PayPeriods.Monthly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(110.00m, LegacyShim(550.00m, "BR", PayPeriods.Monthly, 2, 550.00m, 110.00m, true, 2013));
            Assert.AreEqual(120.00m, LegacyShim(600.24m, "BR", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(166.40m, LegacyShim(1500.00m, "400L", PayPeriods.Monthly, 2, 600.24m, 120.00m, false, 2013));
            Assert.AreEqual(233.00m, LegacyShim(1500.00m, "400L", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(300.00m, LegacyShim(1500.33m, "BR", PayPeriods.Monthly, 2, 1500.00m, 233.00m, true, 2013));
            Assert.AreEqual(115.00m, LegacyShim(575.00m, "BR", PayPeriods.Weekly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(96.00m, LegacyShim(480.00m, "BR", PayPeriods.Weekly, 2, 575.00m, 115.00m, false, 2013));
            Assert.AreEqual(0.00m, LegacyShim(500.00m, "NT", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(0.00m, LegacyShim(500.00m, "NT", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(133.00m, LegacyShim(1000.00m, "400L", PayPeriods.Monthly, 2, 500.00m, 0.00m, true, 2013));
            Assert.AreEqual(87.00m, LegacyShim(770.00m, "400L", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(-87.00m, LegacyShim(770.00m, "NT", PayPeriods.Monthly, 2, 770.00m, 87.00m, false, 2013));
            Assert.AreEqual(0.00m, LegacyShim(770.00m, "NT", PayPeriods.Monthly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(33.00m, LegacyShim(500.00m, "400L", PayPeriods.Monthly, 2, 770.00m, 0.00m, true, 2013));
            Assert.AreEqual(84.40m, LegacyShim(500.00m, "400L", PayPeriods.Weekly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(0.00m, LegacyShim(770.00m, "NT", PayPeriods.Weekly, 2, 500.00m, 84.40m, true, 2013));
            Assert.AreEqual(25.00m, LegacyShim(125.00m, "0T", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(200.00m, LegacyShim(1000.00m, "0T", PayPeriods.Monthly, 2, 125.00m, 25.00m, false, 2013));
            Assert.AreEqual(170.00m, LegacyShim(850.00m, "0T", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(40.20m, LegacyShim(1050.00m, "508L", PayPeriods.Monthly, 2, 850.00m, 170.00m, false, 2013));
            Assert.AreEqual(125.00m, LegacyShim(1050.00m, "508L", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(210.00m, LegacyShim(1050.00m, "0T", PayPeriods.Monthly, 2, 1050.00m, 125.00m, true, 2013));
            Assert.AreEqual(93.00m, LegacyShim(465.00m, "0T", PayPeriods.Weekly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(97.00m, LegacyShim(485.00m, "0T", PayPeriods.Weekly, 2, 465.00m, 93.00m, false, 2013));
            Assert.AreEqual(95.00m, LegacyShim(475.00m, "0T", PayPeriods.Weekly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(95.00m, LegacyShim(475.00m, "0T", PayPeriods.Weekly, 2, 475.00m, 95.00m, true, 2013));
            Assert.AreEqual(173.20m, LegacyShim(510.00m, "K427", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(198.00m, LegacyShim(633.22m, "K427", PayPeriods.Monthly, 2, 510.00m, 173.20m, false, 2013));
            Assert.AreEqual(193.20m, LegacyShim(610.00m, "K427", PayPeriods.Monthly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(207.80m, LegacyShim(683.22m, "K427", PayPeriods.Monthly, 2, 610.00m, 193.20m, true, 2013));
            Assert.AreEqual(173.20m, LegacyShim(510.00m, "K427", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(32.50m, LegacyShim(65.00m, "K427", PayPeriods.Monthly, 2, 510.00m, 173.20m, false, 2013));
            Assert.AreEqual(225.10m, LegacyShim(510.00m, "K427", PayPeriods.Monthly, 3, 575.00m, 205.70m, false, 2013));
            Assert.AreEqual(189.60m, LegacyShim(600.00m, "K417", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(30.40m, LegacyShim(500.00m, "0T", PayPeriods.Monthly, 2, 600.00m, 189.60m, false, 2013));
            Assert.AreEqual(150.00m, LegacyShim(750.00m, "0T", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(170.20m, LegacyShim(500.00m, "K421", PayPeriods.Monthly, 2, 750.00m, 150.00m, true, 2013));
            Assert.AreEqual(5.00m, LegacyShim(15.00m, "K55", PayPeriods.Weekly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(18.20m, LegacyShim(80.00m, "K55", PayPeriods.Weekly, 2, 15.00m, 5.00m, false, 2013));
            Assert.AreEqual(302.20m, LegacyShim(1500.00m, "K55", PayPeriods.Weekly, 3, 95.00m, 23.20m, false, 2013));
            Assert.AreEqual(5.80m, LegacyShim(120.00m, "470L", PayPeriods.Weekly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(5.80m, LegacyShim(120.00m, "470L", PayPeriods.Weekly, 2, 120.00m, 5.80m, false, 2013));
            Assert.AreEqual(6.00m, LegacyShim(120.00m, "470L", PayPeriods.Weekly, 3, 240.00m, 11.60m, false, 2013));
            Assert.AreEqual(5.80m, LegacyShim(120.00m, "470L", PayPeriods.Weekly, 4, 360.00m, 17.60m, false, 2013));
            Assert.AreEqual(6.00m, LegacyShim(120.00m, "470L", PayPeriods.Weekly, 5, 480.00m, 23.40m, false, 2013));
            Assert.AreEqual(5.80m, LegacyShim(120.00m, "470L", PayPeriods.Weekly, 6, 600.00m, 29.40m, false, 2013));
            Assert.AreEqual(6.00m, LegacyShim(120.00m, "470L", PayPeriods.Weekly, 7, 720.00m, 35.20m, false, 2013));
            Assert.AreEqual(5.80m, LegacyShim(120.00m, "470L", PayPeriods.Weekly, 8, 840.00m, 41.20m, false, 2013));
            Assert.AreEqual(465.68m, LegacyShim(1500.63m, "145L", PayPeriods.Weekly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(466.08m, LegacyShim(1500.63m, "145L", PayPeriods.Weekly, 2, 1500.63m, 465.68m, false, 2013));
            Assert.AreEqual(465.69m, LegacyShim(1500.63m, "145L", PayPeriods.Weekly, 3, 3001.26m, 931.76m, false, 2013));
            Assert.AreEqual(466.08m, LegacyShim(1500.63m, "145L", PayPeriods.Weekly, 4, 4501.89m, 1397.45m, false, 2013));
            Assert.AreEqual(465.69m, LegacyShim(1500.63m, "145L", PayPeriods.Weekly, 5, 6002.52m, 1863.53m, false, 2013));
            Assert.AreEqual(466.08m, LegacyShim(1500.63m, "145L", PayPeriods.Weekly, 6, 7503.15m, 2329.22m, false, 2013));
            Assert.AreEqual(465.69m, LegacyShim(1500.63m, "145L", PayPeriods.Weekly, 7, 9003.78m, 2795.30m, false, 2013));
            Assert.AreEqual(466.08m, LegacyShim(1500.63m, "145L", PayPeriods.Weekly, 8, 10504.41m, 3260.99m, false, 2013));
            Assert.AreEqual(1051.60m, LegacyShim(3010.77m, "412L", PayPeriods.Weekly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(1051.60m, LegacyShim(3010.77m, "412L", PayPeriods.Weekly, 2, 3010.77m, 1051.60m, false, 2013));
            Assert.AreEqual(1052.06m, LegacyShim(3010.77m, "412L", PayPeriods.Weekly, 3, 6021.54m, 2103.20m, false, 2013));
            Assert.AreEqual(1051.60m, LegacyShim(3010.77m, "412L", PayPeriods.Weekly, 4, 9032.31m, 3155.26m, false, 2013));
            Assert.AreEqual(1051.60m, LegacyShim(3010.77m, "412L", PayPeriods.Weekly, 5, 12043.08m, 4206.86m, false, 2013));
            Assert.AreEqual(1052.06m, LegacyShim(3010.77m, "412L", PayPeriods.Weekly, 6, 15053.85m, 5258.46m, false, 2013));
            Assert.AreEqual(1051.60m, LegacyShim(3010.77m, "412L", PayPeriods.Weekly, 7, 18064.62m, 6310.52m, false, 2013));
            Assert.AreEqual(1051.61m, LegacyShim(3010.77m, "412L", PayPeriods.Weekly, 8, 21075.39m, 7362.12m, false, 2013));
            Assert.AreEqual(0.00m, LegacyShim(0.00m, "500L", PayPeriods.Weekly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(21.40m, LegacyShim(300.00m, "500L", PayPeriods.Weekly, 2, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(3681.51m, LegacyShim(10000.00m, "500L", PayPeriods.Weekly, 3, 300.00m, 21.40m, false, 2013));
            Assert.AreEqual(2299.00m, LegacyShim(5800.00m, "500L", PayPeriods.Weekly, 4, 10300.00m, 3702.91m, false, 2013));
            Assert.AreEqual(-265.55m, LegacyShim(100.00m, "500L", PayPeriods.Weekly, 5, 16100.00m, 6001.91m, false, 2013));
            Assert.AreEqual(1032.71m, LegacyShim(2985.00m, "500L", PayPeriods.Weekly, 6, 16200.00m, 5736.36m, false, 2013));
            Assert.AreEqual(393.12m, LegacyShim(1550.00m, "500L", PayPeriods.Weekly, 7, 19185.00m, 6769.07m, false, 2013));
            Assert.AreEqual(-141.52m, LegacyShim(50.00m, "500L", PayPeriods.Weekly, 8, 20735.00m, 7162.19m, false, 2013));
            Assert.AreEqual(21.80m, LegacyShim(452.00m, "410L", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(22.00m, LegacyShim(452.00m, "410L", PayPeriods.Monthly, 2, 452.00m, 21.80m, false, 2013));
            Assert.AreEqual(21.80m, LegacyShim(452.00m, "410L", PayPeriods.Monthly, 3, 904.00m, 43.80m, false, 2013));
            Assert.AreEqual(22.00m, LegacyShim(452.00m, "410L", PayPeriods.Monthly, 4, 1356.00m, 65.60m, false, 2013));
            Assert.AreEqual(21.80m, LegacyShim(452.00m, "410L", PayPeriods.Monthly, 5, 1808.00m, 87.60m, false, 2013));
            Assert.AreEqual(22.00m, LegacyShim(452.00m, "410L", PayPeriods.Monthly, 6, 2260.00m, 109.40m, false, 2013));
            Assert.AreEqual(22.00m, LegacyShim(452.00m, "410L", PayPeriods.Monthly, 7, 2712.00m, 131.40m, false, 2013));
            Assert.AreEqual(21.80m, LegacyShim(452.00m, "410L", PayPeriods.Monthly, 8, 3164.00m, 153.40m, false, 2013));
            Assert.AreEqual(22.00m, LegacyShim(452.00m, "410L", PayPeriods.Monthly, 9, 3616.00m, 175.20m, false, 2013));
            Assert.AreEqual(21.80m, LegacyShim(452.00m, "410L", PayPeriods.Monthly, 10, 4068.00m, 197.20m, false, 2013));
            Assert.AreEqual(22.00m, LegacyShim(452.00m, "410L", PayPeriods.Monthly, 11, 4520.00m, 219.00m, false, 2013));
            Assert.AreEqual(21.80m, LegacyShim(452.00m, "410L", PayPeriods.Monthly, 12, 4972.00m, 241.00m, false, 2013));
            Assert.AreEqual(864.90m, LegacyShim(3856.00m, "430L", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(865.30m, LegacyShim(3856.00m, "430L", PayPeriods.Monthly, 2, 3856.00m, 864.90m, false, 2013));
            Assert.AreEqual(865.30m, LegacyShim(3856.00m, "430L", PayPeriods.Monthly, 3, 7712.00m, 1730.20m, false, 2013));
            Assert.AreEqual(865.30m, LegacyShim(3856.00m, "430L", PayPeriods.Monthly, 4, 11568.00m, 2595.50m, false, 2013));
            Assert.AreEqual(865.30m, LegacyShim(3856.00m, "430L", PayPeriods.Monthly, 5, 15424.00m, 3460.80m, false, 2013));
            Assert.AreEqual(865.30m, LegacyShim(3856.00m, "430L", PayPeriods.Monthly, 6, 19280.00m, 4326.10m, false, 2013));
            Assert.AreEqual(865.30m, LegacyShim(3856.00m, "430L", PayPeriods.Monthly, 7, 23136.00m, 5191.40m, false, 2013));
            Assert.AreEqual(865.30m, LegacyShim(3856.00m, "430L", PayPeriods.Monthly, 8, 26992.00m, 6056.70m, false, 2013));
            Assert.AreEqual(865.30m, LegacyShim(3856.00m, "430L", PayPeriods.Monthly, 9, 30848.00m, 6922.00m, false, 2013));
            Assert.AreEqual(865.30m, LegacyShim(3856.00m, "430L", PayPeriods.Monthly, 10, 34704.00m, 7787.30m, false, 2013));
            Assert.AreEqual(865.30m, LegacyShim(3856.00m, "430L", PayPeriods.Monthly, 11, 38560.00m, 8652.60m, false, 2013));
            Assert.AreEqual(864.90m, LegacyShim(3856.00m, "430L", PayPeriods.Monthly, 12, 42416.00m, 9517.90m, false, 2013));
            Assert.AreEqual(5580.25m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(5580.25m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 2, 15000.81m, 5580.25m, false, 2013));
            Assert.AreEqual(5580.25m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 3, 30001.62m, 11160.50m, false, 2013));
            Assert.AreEqual(5580.25m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 4, 45002.43m, 16740.75m, false, 2013));
            Assert.AreEqual(5580.25m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 5, 60003.24m, 22321.00m, false, 2013));
            Assert.AreEqual(5580.25m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 6, 75004.05m, 27901.25m, false, 2013));
            Assert.AreEqual(5580.25m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 7, 90004.86m, 33481.50m, false, 2013));
            Assert.AreEqual(5580.25m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 8, 105005.67m, 39061.75m, false, 2013));
            Assert.AreEqual(5580.25m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 9, 120006.48m, 44642.00m, false, 2013));
            Assert.AreEqual(5580.25m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 10, 135007.29m, 50222.25m, false, 2013));
            Assert.AreEqual(5580.25m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 11, 150008.10m, 55802.50m, false, 2013));
            Assert.AreEqual(5580.25m, LegacyShim(15000.81m, "30L", PayPeriods.Monthly, 12, 165008.91m, 61382.75m, false, 2013));
            Assert.AreEqual(242.40m, LegacyShim(2000.00m, "944L", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(-157.40m, LegacyShim(0.00m, "944L", PayPeriods.Monthly, 2, 2000.00m, 242.40m, false, 2013));
            Assert.AreEqual(4869.30m, LegacyShim(16750.00m, "944L", PayPeriods.Monthly, 3, 2000.00m, 85.00m, false, 2013));
            Assert.AreEqual(-248.30m, LegacyShim(1500.00m, "944L", PayPeriods.Monthly, 4, 18750.00m, 4954.30m, false, 2013));
            Assert.AreEqual(-648.70m, LegacyShim(500.00m, "944L", PayPeriods.Monthly, 5, 20250.00m, 4706.00m, false, 2013));
            Assert.AreEqual(-608.30m, LegacyShim(600.00m, "944L", PayPeriods.Monthly, 6, 20750.00m, 4057.30m, false, 2013));
            Assert.AreEqual(-41.40m, LegacyShim(1200.00m, "944L", PayPeriods.Monthly, 7, 21350.00m, 3449.00m, false, 2013));
            Assert.AreEqual(4264.40m, LegacyShim(13600.00m, "944L", PayPeriods.Monthly, 8, 22550.00m, 3407.60m, false, 2013));
            Assert.AreEqual(351.70m, LegacyShim(3000.00m, "944L", PayPeriods.Monthly, 9, 36150.00m, 7672.00m, false, 2013));
            Assert.AreEqual(-848.70m, LegacyShim(0.00m, "944L", PayPeriods.Monthly, 10, 39150.00m, 8023.70m, false, 2013));
            Assert.AreEqual(351.70m, LegacyShim(3000.00m, "944L", PayPeriods.Monthly, 11, 39150.00m, 7175.00m, false, 2013));
            Assert.AreEqual(-448.70m, LegacyShim(1000.00m, "944L", PayPeriods.Monthly, 12, 42150.00m, 7526.70m, false, 2013));
            Assert.AreEqual(0.00m, LegacyShim(39.00m, "45L", PayPeriods.Monthly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(0.20m, LegacyShim(39.25m, "45L", PayPeriods.Monthly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(533.40m, LegacyShim(2706.24m, "45L", PayPeriods.Monthly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(533.60m, LegacyShim(2706.25m, "45L", PayPeriods.Monthly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(533.70m, LegacyShim(2706.26m, "45L", PayPeriods.Monthly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(4466.10m, LegacyShim(12538.24m, "45L", PayPeriods.Monthly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(4466.50m, LegacyShim(12538.25m, "45L", PayPeriods.Monthly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(4466.50m, LegacyShim(12538.26m, "45L", PayPeriods.Monthly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(4466.95m, LegacyShim(12539.25m, "45L", PayPeriods.Monthly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(123.00m, LegacyShim(624.82m, "45L", PayPeriods.Weekly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(123.20m, LegacyShim(624.83m, "45L", PayPeriods.Weekly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(123.28m, LegacyShim(624.84m, "45L", PayPeriods.Weekly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(123.68m, LegacyShim(625.83m, "45L", PayPeriods.Weekly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(1030.48m, LegacyShim(2893.82m, "45L", PayPeriods.Weekly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(1030.88m, LegacyShim(2893.83m, "45L", PayPeriods.Weekly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(1030.90m, LegacyShim(2893.84m, "45L", PayPeriods.Weekly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(316.20m, LegacyShim(2000.00m, "501L", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(253.20m, LegacyShim(2100.00m, "999L", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(283.00m, LegacyShim(2250.00m, "1000L", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(283.00m, LegacyShim(2250.00m, "1001L", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(261.00m, LegacyShim(2612.00m, "1567L", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(216.60m, LegacyShim(2750.00m, "1999L", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(333.00m, LegacyShim(3333.33m, "2000L", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(333.00m, LegacyShim(3333.33m, "2001L", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(80.60m, LegacyShim(500.00m, "501L", PayPeriods.Weekly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(129.68m, LegacyShim(825.00m, "999L", PayPeriods.Weekly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(129.68m, LegacyShim(825.00m, "1000L", PayPeriods.Weekly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(129.68m, LegacyShim(825.00m, "1001L", PayPeriods.Weekly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(39.60m, LegacyShim(500.00m, "1567L", PayPeriods.Weekly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(88.00m, LegacyShim(825.00m, "1999L", PayPeriods.Weekly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(88.00m, LegacyShim(825.00m, "2000L", PayPeriods.Weekly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(88.20m, LegacyShim(827.00m, "2001L", PayPeriods.Weekly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(32.00m, LegacyShim(160.00m, "BR", PayPeriods.Weekly, 1, 0.00m, 0.00m, true, 2013));
            Assert.AreEqual(392.20m, LegacyShim(2000.00m, "45L", PayPeriods.Monthly, 1, 0.00m, 0.00m, false, 2013));
            Assert.AreEqual(-7.60m, LegacyShim(0.00m, "45L", PayPeriods.Monthly, 2, 2000.00m, 392.20m, false, 2013));
            Assert.AreEqual(5468.90m, LegacyShim(16750.00m, "45L", PayPeriods.Monthly, 3, 2000.00m, 384.60m, false, 2013));
            Assert.AreEqual(51.30m, LegacyShim(1500.00m, "45L", PayPeriods.Monthly, 4, 18750.00m, 5853.50m, false, 2013));
            Assert.AreEqual(-349.10m, LegacyShim(500.00m, "45L", PayPeriods.Monthly, 5, 20250.00m, 5904.80m, false, 2013));
            Assert.AreEqual(-308.70m, LegacyShim(600.00m, "45L", PayPeriods.Monthly, 6, 20750.00m, 5555.70m, false, 2013));
            Assert.AreEqual(-68.70m, LegacyShim(1200.00m, "45L", PayPeriods.Monthly, 7, 21350.00m, 5247.00m, false, 2013));
            Assert.AreEqual(4891.30m, LegacyShim(13600.00m, "45L", PayPeriods.Monthly, 8, 22550.00m, 5178.30m, false, 2013));
            Assert.AreEqual(650.90m, LegacyShim(3000.00m, "45L", PayPeriods.Monthly, 9, 36150.00m, 10069.60m, false, 2013));
            Assert.AreEqual(-548.70m, LegacyShim(0.00m, "45L", PayPeriods.Monthly, 10, 39150.00m, 10720.50m, false, 2013));
            Assert.AreEqual(651.30m, LegacyShim(3000.00m, "45L", PayPeriods.Monthly, 11, 39150.00m, 10171.80m, false, 2013));
            Assert.AreEqual(-148.70m, LegacyShim(1000.00m, "45L", PayPeriods.Monthly, 12, 42150.00m, 10823.10m, false, 2013));
        }
    }
}
