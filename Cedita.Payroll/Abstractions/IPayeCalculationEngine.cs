// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Models;

namespace Cedita.Payroll.Abstractions
{
    public interface IPayeCalculationEngine
    {
        decimal CalculateTaxDueForPeriod(string taxCode, decimal gross, PayPeriods periods, int period, bool week1 = false, decimal grossToDate = 0, decimal taxToDate = 0);
        decimal CalculateTaxDueForPeriod(TaxCode taxCode, decimal gross, PayPeriods periods, int period, bool week1 = false, decimal grossToDate = 0, decimal taxToDate = 0);
    }
}
