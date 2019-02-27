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
        public DateTime StartDate { get; set;}
        public DateTime EndDate { get; set; }
        public DateTime UpcomingPaymentDate { get; set; }
        public decimal AverageWeeklyEarnings { get; set; }
        public IEnumerable<DateTime> GetQualifyingDatesInRange() => Enumerable.Range(0, EndDate.Subtract(StartDate).Days + 1).Select(d => StartDate.AddDays(d));

        public DateTime UpcomingPaymentDateForPeriod
        {
            get
            {
                var nextPeriod = (Frequency == PayPeriods.Monthly ? UpcomingPaymentDate.AddMonths(1) : (Frequency == PayPeriods.Fortnightly ? UpcomingPaymentDate.AddDays(14) : UpcomingPaymentDate.AddDays(7)));
                return  (UpcomingPaymentDate > GetQualifyingDatesInRange().First() ? UpcomingPaymentDate : nextPeriod);
            }
        }
    }    
}
