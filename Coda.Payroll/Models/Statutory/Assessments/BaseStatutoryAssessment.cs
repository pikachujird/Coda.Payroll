using System;
using System.Collections.Generic;
using System.Linq;

namespace Coda.Payroll.Models.Statutory.Assessments
{
    public interface IStatutoryAssessment { }

    public class BaseStatutoryAssessment : IStatutoryAssessment
    {
        public readonly IDictionary<PayPeriods, decimal> PayPeriodsValueLookup = new Dictionary<PayPeriods, decimal>
        {
            { PayPeriods.Weekly, 1 },
            { PayPeriods.Fortnightly, 2 },
            { PayPeriods.FourWeekly, 4 },
            { PayPeriods.Monthly, 4.3333m },
        };

        public PayPeriods Frequency { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? UpcomingPaymentDate { get; set; }
        public bool StartDateNotKnown { get; set; }
        public decimal TotalEarningsInPeriod { get; set; }
        public int TotalPaymentsInPeriod { get; set; }
        public bool EmployeeHasContract { get; set; }

        public decimal AverageWeeklyEarnings =>
            TotalEarningsInPeriod == 0m || TotalPaymentsInPeriod == 0
                ? 0m
                : TotalEarningsInPeriod / TotalPaymentsInPeriod / PayPeriodsValueLookup[Frequency];

        public IEnumerable<DateTime> GetQualifyingDatesInRange() =>
            !EndDate.HasValue || !StartDate.HasValue
                ? null
                : Enumerable.Range(0, EndDate.Value.Subtract(StartDate.Value).Days + 1).Select(d => StartDate.Value.AddDays(d));

        public DateTime UpcomingPaymentDateForPeriod
        {
            get
            {
                if (!UpcomingPaymentDate.HasValue || !StartDate.HasValue || !EndDate.HasValue)
                    return DateTime.Today;

                var nextPeriod = (Frequency == PayPeriods.Monthly ? UpcomingPaymentDate.Value.AddMonths(1) : (Frequency == PayPeriods.Fortnightly ? UpcomingPaymentDate.Value.AddDays(14) : UpcomingPaymentDate.Value.AddDays(7)));
                return (UpcomingPaymentDate.Value > GetQualifyingDatesInRange().First() ? UpcomingPaymentDate.Value : nextPeriod);
            }
        }
    }
}
