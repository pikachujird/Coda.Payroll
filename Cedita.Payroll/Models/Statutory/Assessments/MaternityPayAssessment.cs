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
                if (!DueDate.HasValue)
                    return (DateTime?)null;
                return DueDate?.AddDays(-28);
            }
        }

        public DateTime? LatestEndDate
        {
            get
            {
                if (!DueDate.HasValue)
                    return (DateTime?)null;
                return DueDate?.AddDays((52 * 7) - 1);
            }

        }


    }
}
