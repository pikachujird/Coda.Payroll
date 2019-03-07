using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedita.Payroll.Models.Statutory.Assessments
{
    public interface IStatutoryAssessment { }

    public class BaseStatutoryAssessment : IStatutoryAssessment
    {
        public PayPeriods Frequency { get; set; }
        public DateTime? StartDate { get; set;}
        public DateTime? EndDate { get; set; }
        public DateTime? UpcomingPaymentDate { get; set; }
        public decimal TotalEarningsInPeriod { get; set; }
        public int TotalPaymentsInPeriod { get; set; }
        public decimal AverageWeeklyEarnings {
            get
            {
                if (TotalEarningsInPeriod == 0m || TotalPaymentsInPeriod == 0)
                    return 0m;

                return TotalEarningsInPeriod / TotalPaymentsInPeriod;
            }
        }

        public IEnumerable<DateTime> GetQualifyingDatesInRange()
        {
            if (!EndDate.HasValue || !StartDate.HasValue)
                return null;

            return Enumerable.Range(0, EndDate.Value.Subtract(StartDate.Value).Days + 1).Select(d => StartDate.Value.AddDays(d));
        }

        public DateTime UpcomingPaymentDateForPeriod
        {
            get
            {
                if (!UpcomingPaymentDate.HasValue || !StartDate.HasValue || !EndDate.HasValue)
                    return DateTime.Today;

                var nextPeriod = (Frequency == PayPeriods.Monthly ? UpcomingPaymentDate.Value.AddMonths(1) : (Frequency == PayPeriods.Fortnightly ? UpcomingPaymentDate.Value.AddDays(14) : UpcomingPaymentDate.Value.AddDays(7)));
                return  (UpcomingPaymentDate.Value > GetQualifyingDatesInRange().First() ? UpcomingPaymentDate.Value : nextPeriod);
            }
        }
    }    
}
