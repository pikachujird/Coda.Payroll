// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coda.Payroll.Tests
{
    public partial class PayeTests
    {
        [TestCategory("PAYE Tests"), TestMethod]
        public void ScottishRatePayeCumulativeCalculations2019()
        {
            var sets = new[]
            {
                new []
                {
                    new { Mode = PayPeriods.Monthly, Gross = 1155.26m, Code = "S1250L", Expected = 21.28m },
                    new { Mode = PayPeriods.Monthly, Gross = 1155.27m, Code = "S1250L", Expected = 21.47m },
                    new { Mode = PayPeriods.Monthly, Gross = 3692.26m, Code = "S1250L", Expected = 527.12m },
                    new { Mode = PayPeriods.Monthly, Gross = 8758.26m, Code = "S1250L", Expected = 1662.13m },
                    new { Mode = PayPeriods.Monthly, Gross = 52681.25m, Code = "S1250L", Expected = 20644.41m },
                    new { Mode = PayPeriods.Monthly, Gross = 50000m, Code = "S1250L", Expected = 21354.14m },
                    new { Mode = PayPeriods.Monthly, Gross = 15000m, Code = "S1250L", Expected = 5268.10m },
                    new { Mode = PayPeriods.Monthly, Gross = 14000.55m, Code = "S1250L", Expected = 4808.11m },
                    new { Mode = PayPeriods.Monthly, Gross = 12590.45m, Code = "SBR", Expected = -22500.16m },
                    new { Mode = PayPeriods.Monthly, Gross = 12245.45m, Code = "NT", Expected = -31806.60m },
                },
                new []
                {
                    new { Mode = PayPeriods.Weekly, Gross = 267.07m, Code = "S1250L", Expected = 4.94m },
                    new { Mode = PayPeriods.Weekly, Gross = 266.08m, Code = "S1250L", Expected = 4.94m },
                    new { Mode = PayPeriods.Weekly, Gross = 853.05m, Code = "S1250L", Expected = 121.73m },
                    new { Mode = PayPeriods.Weekly, Gross = 2021.09m, Code = "S1250L", Expected = 383.84m },
                    new { Mode = PayPeriods.Weekly, Gross = 12157.07m, Code = "S1250L", Expected = 4763.81m },
                    new { Mode = PayPeriods.Weekly, Gross = 15000m, Code = "S1250L", Expected = 6520.06m },
                    new { Mode = PayPeriods.Weekly, Gross = 242.84m, Code = "S1250L", Expected = -264.60m },
                    new { Mode = PayPeriods.Weekly, Gross = 243.83m, Code = "S1250L", Expected = -264.60m },
                    new { Mode = PayPeriods.Weekly, Gross = 632.84m, Code = "SBR", Expected = -4933.52m },
                    new { Mode = PayPeriods.Weekly, Gross = 2893.83m, Code = "NT", Expected = -6336.60m },
                }
            };

            foreach (var set in sets)
            {
                decimal gtd = 0, ttd = 0;
                int periodNum = 1;
                foreach (var period in set)
                {
                    Assert.AreEqual(period.Expected, LegacyShim(period.Gross, period.Code, period.Mode, periodNum, gtd, ttd, false, 2019));
                    gtd += period.Gross;
                    ttd += period.Expected;
                    periodNum++;
                }
            }
        }

        [TestCategory("PAYE Tests"), TestMethod]
        public void ScottishRatePayeWk1Calculations2019()
        {
            // Scottish WK1M1 Monthly
            Assert.AreEqual(0m, LegacyShim(39.24m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(0.19m, LegacyShim(39.25m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(753.67m, LegacyShim(3164.24m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(754.08m, LegacyShim(3164.25m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(4597.42m, LegacyShim(12539.24m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(4597.88m, LegacyShim(12539.25m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(19.80m, LegacyShim(99.99m, "SBR", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(20.79m, LegacyShim(99.99m, "SD0", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(40.59m, LegacyShim(99.99m, "SD1", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(45.54m, LegacyShim(99.99m, "SD2", PayPeriods.Monthly, 1, 0, 0, false, 2019));

            // Scottish WK1M1 Weekly
            Assert.AreEqual(0m, LegacyShim(29.05m, "S145L", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(0.19m, LegacyShim(29.06m, "S145L", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(174.27m, LegacyShim(750.06m, "S145L", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(174.27m, LegacyShim(750.07m, "S145L", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(1061.10m, LegacyShim(2913.06m, "S145L", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(1061.12m, LegacyShim(2913.07m, "S145L", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(20.20m, LegacyShim(101.99m, "SBR", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(21.21m, LegacyShim(101.99m, "SD0", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(41.41m, LegacyShim(101.99m, "SD1", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(46.46m, LegacyShim(101.99m, "SD2", PayPeriods.Weekly, 1, 0, 0, false, 2019));
        }
    }
}
