// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Configuration;
using System;
using System.Collections.Generic;

namespace Cedita.Payroll.Abstractions
{
    /// <summary>
    /// Interface to support the retrieval of Tax Year Specifics
    /// </summary>
    public interface IBankHolidayConfigurationDataProvider
    {
        IEnumerable<DateTime> GetBankHolidays(DateTime? since = null);
        BankHolidayConfigurationData GetBankHolidayConfigurationData();
    }
}
