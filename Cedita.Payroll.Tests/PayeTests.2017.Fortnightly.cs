// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cedita.Payroll.Tests
{
    public partial class PayeTests
    {
        [TestCategory("PAYE Tests"), TestMethod]
        public void PayeCalculations2017Fortnightly()
        {
            // General Tax Rate
            Assert.AreEqual(218.20m, LegacyShim(1534.04m, "1150L", PayPeriods.Fortnightly, 1, 0, 0, false, 2017));
            Assert.AreEqual(1319.4m, LegacyShim(9695.98m, "1150L", PayPeriods.Fortnightly, 7, 0, 0, false, 2017));
        }
    }
}
