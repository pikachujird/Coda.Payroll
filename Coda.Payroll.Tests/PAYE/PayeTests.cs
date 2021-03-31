// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Coda.Payroll.Abstractions;
using Coda.Payroll.Calculation;
using Coda.Payroll.Calculation.Paye;
using Coda.Payroll.Configuration.Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Coda.Payroll.Tests
{
    [TestClass]
    public partial class PayeTests
    {
        protected EmbeddedTaxConfigurationDataProvider DataProvider = new EmbeddedTaxConfigurationDataProvider();
        protected readonly IPayeCalculationEngineFactory payeFactory;
        
        public PayeTests()
        {
            payeFactory = new DefaultPayeCalculationEngineFactory(DataProvider);
        }

        protected decimal LegacyShim(decimal gross, string taxCode, PayPeriods periods, int period, decimal gtd, decimal ttd, bool wk1, int year)
        {
            var payeEngine = payeFactory.CreatePayeCalculationEngine(year);

            return payeEngine.CalculateTaxDueForPeriod(taxCode, gross, periods, period, wk1, gtd, ttd);
        }
    }
}
