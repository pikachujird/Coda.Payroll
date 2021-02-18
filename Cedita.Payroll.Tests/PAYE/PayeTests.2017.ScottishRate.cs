// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cedita.Payroll.Tests
{
    public partial class PayeTests
    {
        [TestCategory("PAYE Tests"), TestMethod]
        public void ScottishRatePayeCalculations2017()
        {
            // General Tax Rate
            Assert.AreEqual(0m, LegacyShim(39.24m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));
            Assert.AreEqual(0.20m, LegacyShim(39.25m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));
            Assert.AreEqual(524.80m, LegacyShim(2663.24m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));
            Assert.AreEqual(525m, LegacyShim(2663.25m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));
            Assert.AreEqual(525m, LegacyShim(2663.26m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));
            Assert.AreEqual(525.40m, LegacyShim(2664.26m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));
            Assert.AreEqual(4474.60m, LegacyShim(12538.24m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));
            Assert.AreEqual(4475m, LegacyShim(12538.25m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));
            Assert.AreEqual(4475m, LegacyShim(12538.26m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));
            Assert.AreEqual(4475.45m, LegacyShim(12539.25m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));

            Assert.AreEqual(121m, LegacyShim(614.82m, "S45L", PayPeriods.Weekly, 1, 0, 0, false, 2017));
            Assert.AreEqual(121.20m, LegacyShim(614.83m, "S45L", PayPeriods.Weekly, 1, 0, 0, false, 2017));
            Assert.AreEqual(121.24m, LegacyShim(614.84m, "S45L", PayPeriods.Weekly, 1, 0, 0, false, 2017));
            Assert.AreEqual(1032.44m, LegacyShim(2893.82m, "S45L", PayPeriods.Weekly, 1, 0, 0, false, 2017));
            Assert.AreEqual(1032.84m, LegacyShim(2893.83m, "S45L", PayPeriods.Weekly, 1, 0, 0, false, 2017));
            Assert.AreEqual(1032.86m, LegacyShim(2893.84m, "S45L", PayPeriods.Weekly, 1, 0, 0, false, 2017));

            // Scottish to rUK
            Assert.AreEqual(591.40m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));
            Assert.AreEqual(591.80m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 2, 2830 * 1, 591.40m, false, 2017));
            Assert.AreEqual(591.80m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 3, 2830 * 2, 1183.20m, false, 2017));
            Assert.AreEqual(591.80m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 4, 2830 * 3, 1775m, false, 2017));
            Assert.AreEqual(591.40m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 5, 2830 * 4, 2366.80m, false, 2017));
            Assert.AreEqual(591.80m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 6, 2830 * 5, 2958.20m, false, 2017));
            Assert.AreEqual(358.46m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 7, 2830 * 6, 3550m, false, 2017));
            Assert.AreEqual(558.34m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 8, 2830 * 7, 3908.46m, false, 2017));
            Assert.AreEqual(558.20m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 9, 2830 * 8, 4466.80m, false, 2017));
            Assert.AreEqual(558.46m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 10, 2830 * 9, 5025m, false, 2017));
            Assert.AreEqual(558.47m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 11, 2830 * 10, 5583.46m, false, 2017));
            Assert.AreEqual(558.47m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 12, 2830 * 11, 6141.93m, false, 2017));

            // rUK to Scottish
            Assert.AreEqual(558.20m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));
            Assert.AreEqual(558.40m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 2, 2830 * 1, 558.20m, false, 2017));
            Assert.AreEqual(558.40m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 3, 2830 * 2, 1116.60m, false, 2017));
            Assert.AreEqual(558.40m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 4, 2830 * 3, 1675m, false, 2017));
            Assert.AreEqual(558.20m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 5, 2830 * 4, 2233.40m, false, 2017));
            Assert.AreEqual(558.40m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 6, 2830 * 5, 2791.60m, false, 2017));
            Assert.AreEqual(791.80m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 7, 2830 * 6, 3350m, false, 2017));
            Assert.AreEqual(591.80m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 8, 2830 * 7, 4141.80m, false, 2017));
            Assert.AreEqual(591.40m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 9, 2830 * 8, 4733.60m, false, 2017));
            Assert.AreEqual(591.80m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 10, 2830 * 9, 5325m, false, 2017));
            Assert.AreEqual(591.80m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 11, 2830 * 10, 5916.80m, false, 2017));
            Assert.AreEqual(591.80m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 12, 2830 * 11, 6508.60m, false, 2017));
        }
    }
}
