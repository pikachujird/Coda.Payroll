// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cedita.Payroll.Tests
{
    public partial class PayeTests
    {
        [TestCategory("PAYE Tests"), TestMethod]
        public void ScottishRatePayeCumulativeCalculations2021()
        {
            var sets = new[]
            {
                new []
                {
                    new { Mode = PayPeriods.Monthly, Gross = 1155.26m, Code = "S1257L", Expected = 20.33m },
                    new { Mode = PayPeriods.Monthly, Gross = 1155.27m, Code = "S1257L", Expected = 20.33m },
                    new { Mode = PayPeriods.Monthly, Gross = 3692.26m, Code = "S1257L", Expected = 525.69m },
                    new { Mode = PayPeriods.Monthly, Gross = 8758.26m, Code = "S1257L", Expected = 1644.32m },
                    new { Mode = PayPeriods.Monthly, Gross = 52681.25m, Code = "S1257L", Expected = 20638.97m },
                    new { Mode = PayPeriods.Monthly, Gross = 50000m, Code = "S1257L", Expected = 21346.96m },
                    new { Mode = PayPeriods.Monthly, Gross = 15000m, Code = "S1257L", Expected = 5262.37m },
                    new { Mode = PayPeriods.Monthly, Gross = 14000.55m, Code = "S1257L", Expected = 4802.37m },
                    new { Mode = PayPeriods.Monthly, Gross = 12590.45m, Code = "SBR", Expected = -22454.74m },
                    new { Mode = PayPeriods.Monthly, Gross = 12590.45m, Code = "NT", Expected = -31806.6m },
                },
                new []
                {
                    new { Mode = PayPeriods.Weekly, Gross = 267.07m, Code = "S1257L", Expected = 4.75m },
                    new { Mode = PayPeriods.Weekly, Gross = 266.08m, Code = "S1257L", Expected = 4.56m },
                    new { Mode = PayPeriods.Weekly, Gross = 853.05m, Code = "S1257L", Expected = 121.48m },
                    new { Mode = PayPeriods.Weekly, Gross = 2021.09m, Code = "S1257L", Expected = 379.45m },
                    new { Mode = PayPeriods.Weekly, Gross = 12157.07m, Code = "S1257L", Expected = 4762.72m },
                    new { Mode = PayPeriods.Weekly, Gross = 15000m, Code = "S1257L", Expected = 6518.56m },
                    new { Mode = PayPeriods.Weekly, Gross = 242.84m, Code = "S1257L", Expected = -266.21m },
                    new { Mode = PayPeriods.Weekly, Gross = 243.83m, Code = "S1257L", Expected = -265.74m },
                    new { Mode = PayPeriods.Weekly, Gross = 632.84m, Code = "SBR", Expected = -4922.97m },
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
        public void ScottishRatePayeWk1Calculations2021()
        {
            // Scottish WK1M1 Monthly
            Assert.AreEqual(0m, LegacyShim(39.24m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(0.19m, LegacyShim(39.25m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(750.69m, LegacyShim(3164.24m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(751.1m, LegacyShim(3164.25m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(4594.44m, LegacyShim(12539.24m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(4594.90m, LegacyShim(12539.25m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(19.8m, LegacyShim(99.99m, "SBR", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(20.79m, LegacyShim(99.99m, "SD0", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(40.59m, LegacyShim(99.99m, "SD1", PayPeriods.Monthly, 1, 0, 0, false, 2021));
            Assert.AreEqual(45.54m, LegacyShim(99.99m, "SD2", PayPeriods.Monthly, 1, 0, 0, false, 2021));

            // Scottish WK1M1 Weekly
            Assert.AreEqual(0m, LegacyShim(29.05m, "S145L", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(0.19m, LegacyShim(29.06m, "S145L", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(173.58m, LegacyShim(750.06m, "S145L", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(173.58m, LegacyShim(750.07m, "S145L", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(1060.41m, LegacyShim(2913.06m, "S145L", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(1060.43m, LegacyShim(2913.07m, "S145L", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(20.2m, LegacyShim(101.99m, "SBR", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(21.21m, LegacyShim(101.99m, "SD0", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(41.41m, LegacyShim(101.99m, "SD1", PayPeriods.Weekly, 1, 0, 0, false, 2021));
            Assert.AreEqual(46.46m, LegacyShim(101.99m, "SD2", PayPeriods.Weekly, 1, 0, 0, false, 2021));
        }
    }
}
