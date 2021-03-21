// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cedita.Payroll.Configuration.Providers;
using System.Linq;
using Cedita.Payroll.Abstractions;

namespace Cedita.Payroll.Tests.EmbeddedProviders
{
    [TestClass]
    public class BankHolidayConfigurationProviderTests
    {
        private IBankHolidayConfigurationDataProvider provider = new EmbeddedBankHolidayConfigurationProvider();

        [TestCategory("Embedded Provider Tests"), TestMethod]
        public void BankHolidayProviderTests()
        {
            var realBhDate18 = new DateTime(2018, 12, 25);
            var realBhDate19 = new DateTime(2019, 12, 25);
            var sinceDate = new DateTime(2019, 01, 01);
            var testResults = provider.GetBankHolidays();
            Assert.IsTrue(testResults.Contains(realBhDate18));
            testResults = provider.GetBankHolidays(sinceDate);
            Assert.IsFalse(testResults.Contains(realBhDate18));
            Assert.IsTrue(testResults.Contains(realBhDate19));
        }
    }
}
