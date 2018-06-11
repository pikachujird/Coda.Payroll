// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Models;
using System;

namespace Cedita.Payroll
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Get the <see cref="TaxPeriod"/> for this <see cref="DateTime"/>
        /// </summary>
        /// <param name="date"><see cref="DateTime"/></param>
        /// <returns><see cref="TaxPeriod"/> for <paramref name="date"/></returns>
        public static TaxPeriod GetTaxPeriod(this DateTime date)
        {
            return new TaxPeriod(date);
        }
    }
}
