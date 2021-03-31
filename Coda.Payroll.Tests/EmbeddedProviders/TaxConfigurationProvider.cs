// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coda.Payroll.Configuration.Providers;
using System.Linq;
using Coda.Payroll.Abstractions;

namespace Coda.Payroll.Tests.EmbeddedProviders
{
    [TestClass]
    public class TaxConfigurationProviderTests
    {
        private ITaxConfigurationDataProvider _provider = new EmbeddedTaxConfigurationDataProvider();

        [TestCategory("Embedded Provider Tests"), TestMethod]
        public void TaxProviderTests()
        {
            var taxYearData = _provider.GetTaxYearConfigurationData(2015);
            var brackets = taxYearData.Brackets;
            Assert.AreEqual(31785, brackets.First().To);
            Assert.AreEqual(150000, brackets.Last().From);

            var niCodeA = taxYearData.NiRates['A'];
            Assert.AreEqual(12, niCodeA.EeD);
            Assert.AreEqual(13.8m, niCodeA.ErF);

            var fixedCode = taxYearData.FixedCodes.Single(m => m.Code == "NT");
            Assert.AreEqual(0, fixedCode.Rate);

            Assert.AreEqual("1060L", taxYearData.DefaultTaxCode);
            Assert.AreEqual(40040, taxYearData.UpperAccrualPoint);
            Assert.AreEqual(0.6m, taxYearData.DeaProtectedEarnings);

            // Check that we can get other tax years
            taxYearData = _provider.GetTaxYearConfigurationData(2017);
            brackets = taxYearData.Brackets;
            Assert.AreNotEqual(31785, brackets.First().To);

            niCodeA = taxYearData.NiRates['A'];
            Assert.AreEqual(2, niCodeA.EeD);
            Assert.AreEqual(0, niCodeA.ErF);

            fixedCode = taxYearData.FixedCodes.Single(m => m.Code == "BR");
            Assert.AreEqual(0.2m, fixedCode.Rate);

            Assert.AreEqual("1150L", taxYearData.DefaultTaxCode);
            Assert.AreEqual(8164, taxYearData.PrimaryThreshold);
        }
    }
}
