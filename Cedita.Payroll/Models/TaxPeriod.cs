// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using System;

namespace Cedita.Payroll.Models
{
    /// <summary>
    /// <see cref="TaxPeriod"/> represents a tax period for a specific date
    /// </summary>
    public class TaxPeriod
    {
        public DateTime Date { get; }
        public int Year { get; }
        public int Week { get; }
        public int Fortnight { get; }
        public int FourWeek { get; }
        public int Month { get; }

        public TaxPeriod(DateTime date, int year, int week, int fortnight, int fourweek, int month)
        {
            Date = date;
            Year = year;
            Week = week;
            Fortnight = fortnight;
            FourWeek = fourweek;
            Month = month;
        }

        public TaxPeriod(DateTime date)
        {
            Date = date;
            Year = date.Year;
            if (date.Month < 4 || (date.Month == 4 && date.Day < 6))
            {
                Year--;
            }
            var baseDate = new DateTime(Year, 04, 06);
            TaxPeriodsFromDates(baseDate, date, out int year, out int week, out int fortnight, out int fourweek, out int month);
            Week = week;
            Fortnight = fortnight;
            FourWeek = fourweek;
            Month = month;
        }

        public static TaxPeriod[] GetPeriodsForTaxYear(int taxYear)
        {
            var baseDate = new DateTime(taxYear, 04, 06);
            var daysInYear = new DateTime(taxYear + 1, 12, 31).DayOfYear;
            var tmpDayHolder = new TaxPeriod[daysInYear];
            for (int i = 0; i < daysInYear; i++)
            {
                var myDate = baseDate.AddDays(i);
                TaxPeriodsFromDates(baseDate, myDate, out int year, out int week, out int fortnight, out int fourweek, out int month);
                tmpDayHolder[i] = new TaxPeriod(myDate, taxYear, week, fortnight, fourweek, month);
            }
            return tmpDayHolder;
        }

        protected static void TaxPeriodsFromDates(DateTime taxYearStart, DateTime date,
            out int year, out int week, out int fortnight, out int fourweek, out int month)
        {
            year = date.Year;
            if (date.Month < 4 || (date.Month == 4 && date.Day < 6))
            {
                year--;
            }
            
            var span = date - taxYearStart;
            week = (int)Math.Floor(span.Days / 7d) + 1;
            fortnight = (int)((week / 2d) + 0.5d);
            fourweek = (int)((week / 4d) + 0.75d);

            if (date.Day < 6)
            {
                date = date.AddMonths(-1);
            }

            var monthDiff = date.Month - 3;
            var yearDiff = date.Year - year;
            month = Math.Max(1, (yearDiff * 12) + monthDiff);
        }

        protected static TaxPeriod GetPeriodFromNumber(PayPeriods periods, int period, int taxYear)
        {
            var baseDate = new DateTime(taxYear, 04, 06);
            var referenceDate = baseDate.AddDays(period * (365 / (int)periods));
            return new TaxPeriod(referenceDate);
        }
    }
}
