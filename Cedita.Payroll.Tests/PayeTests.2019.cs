// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cedita.Payroll.Tests
{
    public partial class PayeTests
    {
        [TestCategory("PAYE Tests"), TestMethod]
        public void PayeCumulativeCalculations2019()
        {
            var sets = new[]
            {
                new []
                {
                    new { Mode = PayPeriods.Monthly, Gross = 1155.26m, Code = "1250L", Expected = 22.40m },
                    new { Mode = PayPeriods.Monthly, Gross = 1155.27m, Code = "1250L", Expected = 22.60m },
                    new { Mode = PayPeriods.Monthly, Gross = 3692.26m, Code = "1250L", Expected = 530m },
                    new { Mode = PayPeriods.Monthly, Gross = 8758.26m, Code = "1250L", Expected = 1543.20m },
                    new { Mode = PayPeriods.Monthly, Gross = 52681.25m, Code = "1250L", Expected = 19648.80m },
                    new { Mode = PayPeriods.Monthly, Gross = 50000m, Code = "1250L", Expected = 20767.15m },
                    new { Mode = PayPeriods.Monthly, Gross = 15000m, Code = "1250L", Expected = 5031.10m },
                    new { Mode = PayPeriods.Monthly, Gross = 14000.55m, Code = "1250L", Expected = 4581.10m },
                    new { Mode = PayPeriods.Monthly, Gross = 12590.45m, Code = "BR", Expected = -20339.75m },
                    new { Mode = PayPeriods.Monthly, Gross = 12245.05m, Code = "NT", Expected = -31806.60m },
                },
                new []
                {
                    new { Mode = PayPeriods.Weekly, Gross = 267.07m, Code = "1250L", Expected = 5.20m },
                    new { Mode = PayPeriods.Weekly, Gross = 266.07m, Code = "1250L", Expected = 5.20m },
                    new { Mode = PayPeriods.Weekly, Gross = 853.05m, Code = "1250L", Expected = 122.40m },
                    new { Mode = PayPeriods.Weekly, Gross = 2021.09m, Code = "1250L", Expected = 356.20m },
                    new { Mode = PayPeriods.Weekly, Gross = 12157.07m, Code = "1250L", Expected = 4534.24m },
                    new { Mode = PayPeriods.Weekly, Gross = 15000m, Code = "1250L", Expected = 6349.99m },
                    new { Mode = PayPeriods.Weekly, Gross = 242.84m, Code = "1250L", Expected = -287.12m },
                    new { Mode = PayPeriods.Weekly, Gross = 243.83m, Code = "1250L", Expected = -287.11m },
                    new { Mode = PayPeriods.Weekly, Gross = 632.84m, Code = "BR", Expected = -4462.40m },
                    new { Mode = PayPeriods.Weekly, Gross = 2893.83m, Code = "NT", Expected = -6336.60m },
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
                    Assert.AreEqual(period.Expected, LegacyShim(period.Gross, period.Code, period.Mode, periodNum, gtd, ttd, false, 2019));
                    gtd += period.Gross;
                    ttd += period.Expected;
                    periodNum++;
                }
            }
        }

        [TestCategory("PAYE Tests"), TestMethod]
        public void PayeWk1Calculations2019()
        {
            // General WK1M1 Monthly
            Assert.AreEqual(0m, LegacyShim(39.24m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(0.20m, LegacyShim(39.25m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(625.00m, LegacyShim(3164.24m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(625.40m, LegacyShim(3164.25m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(4375m, LegacyShim(12539.24m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(4375.45m, LegacyShim(12539.25m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(19.80m, LegacyShim(99.99m, "BR", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(39.60m, LegacyShim(99.99m, "D0", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(44.55m, LegacyShim(99.99m, "D1", PayPeriods.Monthly, 1, 0, 0, false, 2019));

            // General WK1M1 Weekly
            Assert.AreEqual(0m, LegacyShim(29.05m, "145L", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(0.2m, LegacyShim(29.06m, "145L", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(144.40m, LegacyShim(750.06m, "145L", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(144.56m, LegacyShim(750.07m, "145L", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(1009.76m, LegacyShim(2913.06m, "145L", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(1009.78m, LegacyShim(2913.07m, "145L", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(20.20m, LegacyShim(101.99m, "BR", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(40.40m, LegacyShim(101.99m, "D0", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(45.45m, LegacyShim(101.99m, "D1", PayPeriods.Weekly, 1, 0, 0, false, 2019));

            // K WK1M1 Monthly
            Assert.AreEqual(197.60m, LegacyShim(950m, "K45", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(271.60m, LegacyShim(1120m, "K285", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(243.80m, LegacyShim(885m, "K401", PayPeriods.Monthly, 1, 0, 0, false, 2019));

            // K WK1M1 Weekly
            Assert.AreEqual(113m, LegacyShim(560m, "K27", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(92.40m, LegacyShim(432m, "K159", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(203.36m, LegacyShim(810.06m, "K306", PayPeriods.Weekly, 1, 0, 0, false, 2019));

            // Large Code Monthly
            Assert.AreEqual(333.20m, LegacyShim(2500m, "999L", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(433m, LegacyShim(3000m, "1000L", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(1041m, LegacyShim(5000m, "1001L", PayPeriods.Monthly, 1, 0, 0, false, 2019));

            // Large Code Weekly
            Assert.AreEqual(111.40m, LegacyShim(750m, "999L", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(141.40m, LegacyShim(900m, "1000L", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(378.56m, LegacyShim(1500m, "1001L", PayPeriods.Weekly, 1, 0, 0, false, 2019));
        }
    }
}
