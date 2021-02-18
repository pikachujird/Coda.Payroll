// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cedita.Payroll.Tests
{
    public partial class PayeTests
    {
        [TestCategory("PAYE Tests"), TestMethod]
        public void WelshRatePayeCumulativeCalculations2019()
        {
            var sets = new[]
            {
                new []
                {
                    new { Mode = PayPeriods.Monthly, Gross = 1155.26m, Code = "C1250L", Expected = 22.40m },
                    new { Mode = PayPeriods.Monthly, Gross = 1155.27m, Code = "C1250L", Expected = 22.60m },
                    new { Mode = PayPeriods.Monthly, Gross = 3692.26m, Code = "C1250L", Expected = 530m },
                    new { Mode = PayPeriods.Monthly, Gross = 8758.26m, Code = "C1250L", Expected = 1543.20m },
                    new { Mode = PayPeriods.Monthly, Gross = 52681.25m, Code = "C1250L", Expected = 19648.80m },
                    new { Mode = PayPeriods.Monthly, Gross = 50000m, Code = "C1250L", Expected = 20767.15m },
                    new { Mode = PayPeriods.Monthly, Gross = 15000m, Code = "C1250L", Expected = 5031.10m },
                    new { Mode = PayPeriods.Monthly, Gross = 14000.55m, Code = "C1250L", Expected = 4581.10m },
                    new { Mode = PayPeriods.Monthly, Gross = 12590.45m, Code = "CBR", Expected = -20339.75m },
                    new { Mode = PayPeriods.Monthly, Gross = 12245.05m, Code = "NT", Expected = -31806.60m },
                },
                new []
                {
                    new { Mode = PayPeriods.Weekly, Gross = 267.07m, Code = "C1250L", Expected = 5.20m },
                    new { Mode = PayPeriods.Weekly, Gross = 266.08m, Code = "C1250L", Expected = 5.20m },
                    new { Mode = PayPeriods.Weekly, Gross = 853.05m, Code = "C1250L", Expected = 122.40m },
                    new { Mode = PayPeriods.Weekly, Gross = 2021.09m, Code = "C1250L", Expected = 356.20m },
                    new { Mode = PayPeriods.Weekly, Gross = 12157.07m, Code = "C1250L", Expected = 4534.24m },
                    new { Mode = PayPeriods.Weekly, Gross = 15000m, Code = "C1250L", Expected = 6349.99m },
                    new { Mode = PayPeriods.Weekly, Gross = 242.84m, Code = "C1250L", Expected = -287.12m },
                    new { Mode = PayPeriods.Weekly, Gross = 243.83m, Code = "C1250L", Expected = -287.11m },
                    new { Mode = PayPeriods.Weekly, Gross = 632.84m, Code = "CBR", Expected = -4462.40m },
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
        public void WelshRatePayeWk1Calculations2019()
        {
            // Welsh WK1M1 Monthly
            Assert.AreEqual(0m, LegacyShim(39.24m, "C45L", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(0.20m, LegacyShim(39.25m, "C45L", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(625.00m, LegacyShim(3164.24m, "C45L", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(625.40m, LegacyShim(3164.25m, "C45L", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(4375m, LegacyShim(12539.24m, "C45L", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(4375.45m, LegacyShim(12539.25m, "C45L", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(19.80m, LegacyShim(99.99m, "CBR", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(39.60m, LegacyShim(99.99m, "CD0", PayPeriods.Monthly, 1, 0, 0, false, 2019));
            Assert.AreEqual(44.55m, LegacyShim(99.99m, "CD1", PayPeriods.Monthly, 1, 0, 0, false, 2019));

            // Welsh WK1M1 Weekly
            Assert.AreEqual(0m, LegacyShim(29.05m, "C145L", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(0.20m, LegacyShim(29.06m, "C145L", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(144.40m, LegacyShim(750.06m, "C145L", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(144.56m, LegacyShim(750.07m, "C145L", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(1009.76m, LegacyShim(2913.06m, "C145L", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(1009.78m, LegacyShim(2913.07m, "C145L", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(20.20m, LegacyShim(101.99m, "CBR", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(40.40m, LegacyShim(101.99m, "CD0", PayPeriods.Weekly, 1, 0, 0, false, 2019));
            Assert.AreEqual(45.45m, LegacyShim(101.99m, "CD1", PayPeriods.Weekly, 1, 0, 0, false, 2019));
        }
    }
}
