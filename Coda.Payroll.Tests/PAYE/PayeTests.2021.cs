// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coda.Payroll.Tests
{
    public partial class PayeTests
    {
        [TestCategory("PAYE Tests"), TestMethod]
        public void PayeCumulativeCalculations2021()
        {
            var sets = new[]
            {
                new []
                {
                    new { Mode = PayPeriods.Monthly, Gross = 1155.26m, Code = "1257L", Expected = 21.4m },
                    new { Mode = PayPeriods.Monthly, Gross = 1155.27m, Code = "1257L", Expected = 21.4m },
                    new { Mode = PayPeriods.Monthly, Gross = 3692.26m, Code = "1257L", Expected = 528.8m },
                    new { Mode = PayPeriods.Monthly, Gross = 8758.26m, Code = "1257L", Expected = 1542m },
                    new { Mode = PayPeriods.Monthly, Gross = 52681.25m, Code = "1257L", Expected = 19625.13m },
                    new { Mode = PayPeriods.Monthly, Gross = 50000m, Code = "1257L", Expected = 20759.67m },
                    new { Mode = PayPeriods.Monthly, Gross = 15000m, Code = "1257L", Expected = 5025.06m },
                    new { Mode = PayPeriods.Monthly, Gross = 14000.55m, Code = "1257L", Expected = 4575.07m },
                    new { Mode = PayPeriods.Monthly, Gross = 12590.45m, Code = "BR", Expected = -20291.93m },
                    new { Mode = PayPeriods.Monthly, Gross = 11245.05m, Code = "NT", Expected = -31806.6m },
                },
                new []
                {
                    new { Mode = PayPeriods.Weekly, Gross = 267.07m, Code = "1257L", Expected = 5m },
                    new { Mode = PayPeriods.Weekly, Gross = 266.08m, Code = "1257L", Expected = 4.8m },
                    new { Mode = PayPeriods.Weekly, Gross = 853.05m, Code = "1257L", Expected = 122.2m },
                    new { Mode = PayPeriods.Weekly, Gross = 2021.09m, Code = "1257L", Expected = 355.8m },
                    new { Mode = PayPeriods.Weekly, Gross = 12157.07m, Code = "1257L", Expected = 4528.8m },
                    new { Mode = PayPeriods.Weekly, Gross = 15000m, Code = "1257L", Expected = 6348.41m },
                    new { Mode = PayPeriods.Weekly, Gross = 242.84m, Code = "1257L", Expected = -288.78m },
                    new { Mode = PayPeriods.Weekly, Gross = 243.83m, Code = "1257L", Expected = -288.33m },
                    new { Mode = PayPeriods.Weekly, Gross = 632.84m, Code = "BR", Expected = -4451.3m },
                    new { Mode = PayPeriods.Weekly, Gross = 2893.83m, Code = "NT", Expected = -6336.6m },
                },
                new []
                {
                    new { Mode = PayPeriods.Monthly, Gross = 2870.55m, Code = "BR", Expected = 574m },
                    new { Mode = PayPeriods.Monthly, Gross = 3500.95m, Code = "BR", Expected = 700.20m },
                    new { Mode = PayPeriods.Monthly, Gross = 32000m, Code = "BR", Expected = 6400m },
                },
                new []
                {
                    new { Mode = PayPeriods.Weekly, Gross = 650.15m, Code = "BR", Expected = 130m },
                    new { Mode = PayPeriods.Weekly, Gross = 995.55m, Code = "BR", Expected = 199m },
                    new { Mode = PayPeriods.Weekly, Gross = 7100.35m, Code = "BR", Expected = 1420.20m },
                },
                new []
                {
                    new { Mode = PayPeriods.Monthly, Gross = 895m, Code = "K585", Expected = 276.60m },
                    new { Mode = PayPeriods.Monthly, Gross = 1250m, Code = "K585", Expected = 347.60m },
                    new { Mode = PayPeriods.Monthly, Gross = 765m, Code = "K585", Expected = 250.60m },
                },
                new []
                {
                    new { Mode = PayPeriods.Weekly, Gross = 150m, Code = "K630", Expected = 54.20m },
                    new { Mode = PayPeriods.Weekly, Gross = 300m, Code = "K630", Expected = 84.20m },
                    new { Mode = PayPeriods.Weekly, Gross = 245m, Code = "K630", Expected = 73.40m },
                }
            };

            foreach(var set in sets)
            {
                decimal gtd = 0, ttd = 0;
                int periodNum = 1;
                foreach (var period in set)
                {
                    Assert.AreEqual(period.Expected, LegacyShim(period.Gross, period.Code, period.Mode, periodNum, gtd, ttd, false, 2021));
                    gtd += period.Gross;
                    ttd += period.Expected;
                    periodNum++;
                }
            }
        }

        [TestCategory("PAYE Tests"), TestMethod]
        public void PayeWk1Calculations2021()
        {
            // General WK1M1 Monthly
            Assert.AreEqual(0m, LegacyShim(39.24m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(0.2m, LegacyShim(39.25m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(625m, LegacyShim(3164.24m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(625.2m, LegacyShim(3164.25m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(4371.66m, LegacyShim(12539.24m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(4372.11m, LegacyShim(12539.25m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(19.8m, LegacyShim(99.99m, "BR", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(39.6m, LegacyShim(99.99m, "D0", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(44.55m, LegacyShim(99.99m, "D1", PayPeriods.Monthly, 1, 0, 0, false, 2021));

            // General WK1M1 Weekly
            Assert.AreEqual(0m, LegacyShim(29.05m, "145L", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(0.2m, LegacyShim(29.06m, "145L", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(144.4m, LegacyShim(750.06m, "145L", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(144.4m, LegacyShim(750.07m, "145L", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(1009m, LegacyShim(2913.06m, "145L", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(1009.01m, LegacyShim(2913.07m, "145L", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(20.2m, LegacyShim(101.99m, "BR", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(40.4m, LegacyShim(101.99m, "D0", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(45.45m, LegacyShim(101.99m, "D1", PayPeriods.Weekly, 1, 0, 0, false, 2021));

            // K WK1M1 Monthly
            Assert.AreEqual(197.60m, LegacyShim(950m, "K45", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(271.60m, LegacyShim(1120m, "K285", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(243.80m, LegacyShim(885m, "K401", PayPeriods.Monthly, 1, 0, 0, false, 2021));

            // K WK1M1 Weekly
            Assert.AreEqual(113m, LegacyShim(560m, "K27", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(92.4m, LegacyShim(432m, "K159", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(202.6m, LegacyShim(810m, "K306", PayPeriods.Weekly, 1, 0, 0, false, 2021));

            // Large Code Monthly
            Assert.AreEqual(333.2m, LegacyShim(2500m, "999L", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(433m, LegacyShim(3000m, "1000L", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(1037.66m, LegacyShim(5000m, "1001L", PayPeriods.Monthly, 1, 0, 0, false, 2021));

            // Large Code Weekly
            Assert.AreEqual(111.4m, LegacyShim(750m, "999L", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(141.4m, LegacyShim(900m, "1000L", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(377.8m, LegacyShim(1500m, "1001L", PayPeriods.Weekly, 1, 0, 0, false, 2021));
        }
    }
}
