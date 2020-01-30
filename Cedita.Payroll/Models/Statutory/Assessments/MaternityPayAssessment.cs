using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedita.Payroll.Models.Statutory.Assessments
{
    public class MaternityPayAssessment : PaternityPayAssessment
    {

        /// <summary>
        /// Returns the Earliest SMP Start Date
        /// </summary>
        public DateTime? EarliestStartDate
        {
            get
            {
                if (!DueDate.HasValue)
                    return (DateTime?)null;
                return DueDate?.GetPreviousWeekday(DayOfWeek.Sunday).AddDays(-(7 * 11));
            }
        }

        /// <summary>
        /// Returns the latest start date for SMP
        /// </summary>
        public DateTime? LatestStartDate
        {
            get
            {
                if (!DueDate.HasValue && !StartDate.HasValue) // Start Date First - and if not known, default to due date
                    return (DateTime?)null;
                return (StartDate ?? DueDate)?.AddDays(-28);
            }
        }

        public DateTime? LatestEndDate
        {
            get
            {
                if (!StartDate.HasValue)
                    return (DateTime?)null;
                return StartDate?.AddDays((52 * 7) - 1);
            }

        }

        /// <summary>
        /// Determines if the given assessment is eligible for SPP
        /// </summary>
        public override bool IsEligible
        {
            get
            {
                return (
                    EmployeeHasContract && // The employee is not entitled to Statutory Maternity Leave because they don’t have an employment contract with you.
                    AverageWeeklyEarnings >= 118m
                );
            }
        } 
    }
}
