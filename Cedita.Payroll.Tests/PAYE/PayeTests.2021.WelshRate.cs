// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cedita.Payroll.Tests
{
    public partial class PayeTests
    {
        [TestCategory("PAYE Tests"), TestMethod]
        public void WelshRatePayeCumulativeCalculations2021()
        {
            var sets = new[]
            {
                new []
                {
                    new { Mode = PayPeriods.Monthly, Gross = 1155.26m, Code = "C1257L", Expected = 21.4m },
                    new { Mode = PayPeriods.Monthly, Gross = 1155.27m, Code = "C1257L", Expected = 21.4m },
                    new { Mode = PayPeriods.Monthly, Gross = 3692.26m, Code = "C1257L", Expected = 528.8m },
                    new { Mode = PayPeriods.Monthly, Gross = 8758.26m, Code = "C1257L", Expected = 1542m },
                    new { Mode = PayPeriods.Monthly, Gross = 52681.25m, Code = "C1257L", Expected = 19625.13m },
                    new { Mode = PayPeriods.Monthly, Gross = 50000m, Code = "C1257L", Expected = 20759.67m },
                    new { Mode = PayPeriods.Monthly, Gross = 15000m, Code = "C1257L", Expected = 5025.06m },
                    new { Mode = PayPeriods.Monthly, Gross = 14000.55m, Code = "C1257L", Expected = 4575.07m },
                    new { Mode = PayPeriods.Monthly, Gross = 12590.45m, Code = "CBR", Expected = -20291.93m },
                    new { Mode = PayPeriods.Monthly, Gross = 11245.05m, Code = "NT", Expected = -31806.6m },
                },
                new []
                {
                    new { Mode = PayPeriods.Weekly, Gross = 267.07m, Code = "C1257L", Expected = 5m },
                    new { Mode = PayPeriods.Weekly, Gross = 266.08m, Code = "C1257L", Expected = 4.8m },
                    new { Mode = PayPeriods.Weekly, Gross = 853.05m, Code = "C1257L", Expected = 122.2m },
                    new { Mode = PayPeriods.Weekly, Gross = 2021.09m, Code = "C1257L", Expected = 355.8m },
                    new { Mode = PayPeriods.Weekly, Gross = 12157.07m, Code = "C1257L", Expected = 4528.8m },
                    new { Mode = PayPeriods.Weekly, Gross = 15000m, Code = "C1257L", Expected = 6348.41m },
                    new { Mode = PayPeriods.Weekly, Gross = 242.84m, Code = "C1257L", Expected = -288.78m },
                    new { Mode = PayPeriods.Weekly, Gross = 243.83m, Code = "C1257L", Expected = -288.33m },
                    new { Mode = PayPeriods.Weekly, Gross = 632.84m, Code = "CBR", Expected = -4451.3m },
                    new { Mode = PayPeriods.Weekly, Gross = 2893.83m, Code = "NT", Expected = -6336.6m },
                }
            };

            foreach (var set in sets)
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
        public void WelshRatePayeWk1Calculations2021()
        {
            // Welsh WK1M1 Monthly
            Assert.AreEqual(0m, LegacyShim(39.24m, "C45L", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(0.2m, LegacyShim(39.25m, "C45L", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(625m, LegacyShim(3164.24m, "C45L", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(625.2m, LegacyShim(3164.25m, "C45L", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(4371.66m, LegacyShim(12539.24m, "C45L", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(4372.11m, LegacyShim(12539.25m, "C45L", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(19.8m, LegacyShim(99.99m, "CBR", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(39.6m, LegacyShim(99.99m, "CD0", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(44.55m, LegacyShim(99.99m, "CD1", PayPeriods.Monthly, 1, 0, 0, false, 2021));

            // Welsh WK1M1 Weekly
            Assert.AreEqual(0m, LegacyShim(29.05m, "C145L", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(0.2m, LegacyShim(29.06m, "C145L", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(144.4m, LegacyShim(750.06m, "C145L", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(144.4m, LegacyShim(750.07m, "C145L", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(1009m, LegacyShim(2913.06m, "C145L", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(1009.01m, LegacyShim(2913.07m, "C145L", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(20.2m, LegacyShim(101.99m, "CBR", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(40.4m, LegacyShim(101.99m, "CD0", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(45.45m, LegacyShim(101.99m, "CD1", PayPeriods.Weekly, 1, 0, 0, false, 2021));
        }
    }
}
