// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Abstractions;
using Cedita.Payroll.Engines;
using Cedita.Payroll.Engines.Paye;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Cedita.Payroll.Tests
{
    [TestClass]
    public partial class PayeTests
    {
        protected Dictionary<int, IPayeCalculationEngine> CalcEngines = new Dictionary<int, IPayeCalculationEngine>();

        protected decimal LegacyShim(decimal gross, string taxCode, PayPeriods periods, int period, decimal gtd, decimal ttd, bool wk1, int year)
        {
            /*if (!CalcEngines.ContainsKey(year))
            {
                CalcEngines.Add(year, DefaultEngineResolver.GetEngine<IPayeCalculationEngine>(year));
                CalcEngines[year].SetTaxYearSpecificsProvider(new JsonTaxYearSpecificProvider());
                CalcEngines[year].SetTaxYear(year);
            }

            return CalcEngines[year].CalculateTaxDueForPeriod(taxCode, gross, periods, period, wk1, gtd, ttd);*/
            return 0;
        }
    }
}
