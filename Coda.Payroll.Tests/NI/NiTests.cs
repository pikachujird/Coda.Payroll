// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Coda.Payroll.Abstractions;
using Coda.Payroll.Calculation;
using Coda.Payroll.Calculation.NationalInsurance;
using Coda.Payroll.Configuration.Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Coda.Payroll.Tests
{
    [TestClass]
    public partial class NiTests
    {
        protected EmbeddedTaxConfigurationDataProvider DataProvider = new EmbeddedTaxConfigurationDataProvider();
        protected readonly INiCalculationEngineFactory niFactory;

        public NiTests()
        {
            niFactory = new DefaultNiCalculationEngineFactory(DataProvider);
        }

        protected decimal TestShim(decimal gross, char niCode, PayPeriods periods, int year)
        {
            var result = GetCalculationResult(gross, niCode, periods, year);
            return result.EmployeeNi + result.EmployerNi;
        }

        protected NationalInsuranceCalculation GetCalculationResult(decimal gross, char niCode, PayPeriods periods, int year)
        {
            var niEngine = niFactory.CreateNiCalculationEngine(year);
            return niEngine.CalculateNationalInsurance(gross, niCode, periods);
        }
    }
}
