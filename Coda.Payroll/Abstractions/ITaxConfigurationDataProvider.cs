// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Coda.Payroll.Configuration;
using System;
using System.Collections.Generic;

namespace Coda.Payroll.Abstractions
{
    /// <summary>
    /// Interface to support the retrieval of Tax Year Specifics
    /// </summary>
    public interface ITaxConfigurationDataProvider
    {
        TaxYearConfigurationData GetTaxYearConfigurationData(int taxYear);
    }
}
