// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using System;
using System.Collections.Generic;

namespace Coda.Payroll.Configuration
{
    public class BankHolidayConfigurationData
    {
        public IEnumerable<DateTime> BankHolidays { get; set; }
    }
}
