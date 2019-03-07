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

        /// <summary>
        /// Returns a DateTime object for the previous specified week day
        /// </summary>
        /// <param name="start"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static DateTime GetPreviousWeekday(this DateTime start, DayOfWeek day)
        {
            if (start.DayOfWeek == day)
                return start;

            int daysToAdd = ((int)day - (int)start.DayOfWeek - 7) % 7;
            return start.AddDays(daysToAdd);
        }

        /// <summary>
        /// Returns a DateTime object for the next upcoming specified week day
        /// </summary>
        /// <param name="start"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static DateTime GetNextWeekday(this DateTime start, DayOfWeek day)
        {
            if (start.DayOfWeek == day)
                return start;

            int daysToAdd = ((int)day - (int)start.DayOfWeek + 7) % 7;
            return start.AddDays(daysToAdd);
        }
    }
}
