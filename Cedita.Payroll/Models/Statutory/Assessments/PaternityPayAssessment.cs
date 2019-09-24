using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cedita.Payroll;

namespace Cedita.Payroll.Models.Statutory.Assessments
{
    public class PaternityPayAssessment : BaseStatutoryAssessment
    {
        /// <summary>
        /// Question 1
        /// </summary>
        public DateTime? DueDate { get; set; }
        /// <summary>
        /// Question 2
        /// </summary>
        public DateTime? BirthDate { get; set; }
        public bool BirthDateNotKnown { get; set; }
        /// <summary>
        /// Question 3
        /// </summary>
        public bool IsResponsibleFather { get; set; }
        /// <summary>
        /// Question 4
        /// </summary>
        public bool EmployeeWorkedInPeriod { get; set; }
        /// <summary>
        /// Question 6
        /// </summary>
        public bool EmployeeOnPayroll { get; set; }
        /// <summary>
        /// Question 7
        /// </summary>
        public bool EmployeeEmployedAtBirth { get; set; }
        /// <summary>
        /// Question 9
        /// </summary>
        public int TotalClaimDays { get; set; }
        /// <summary>
        /// Question 10
        /// </summary>
        public DateTime? LastNormalPayDayToPeriod { get; set; }
        /// <summary>
        /// Question 11
        /// </summary>
        public DateTime? LastNormalPayDayFromPeriod { get; set; }
        /// <summary>
        /// Question 16
        /// </summary>
        public DateTime? WorkerNoticeReceivedDate { get; set; }

        /// <summary>
        /// Returns the [From Period] which is 40 weeks prior to the first Saturday after the date of birth (or due date if not known)
        /// </summary>
        public DateTime? FromPeriod {
            get
            {
                if (!BirthDate.HasValue && !DueDate.HasValue)
                    return (DateTime?)null;
                return (BirthDate ?? DueDate)?.GetNextWeekday(DayOfWeek.Saturday).AddDays(-(7 * 40));
            }
        }

        /// <summary>
        /// Returns the [To Period] which is 15 weeks prior to the first Sunday before the date of birth (or due date if not known)
        /// </summary>
        public DateTime? ToPeriod
        {
            get
            {
                if (!BirthDate.HasValue && !DueDate.HasValue)
                    return (DateTime?)null;
                return (BirthDate ?? DueDate)?.GetPreviousWeekday(DayOfWeek.Sunday).AddDays(-(7 * 15));
            }
        }

        /// <summary>
        /// Returns the [Employment From Period] which is 23 weeks prior to the first Saturday after the date of birth (or due date if not known)
        /// </summary>
        public DateTime? FromPeriodEmployment
        {
            get
            {
                if (!BirthDate.HasValue && !DueDate.HasValue)
                    return (DateTime?)null;
                return (BirthDate ?? DueDate)?.GetNextWeekday(DayOfWeek.Saturday).AddDays(-(7 * 23));
            }
        }

        /// <summary>
        /// Returns the [Employment To Period] which is 15 weeks prior to the first Sunday before the date of birth (or due date if not known)
        /// </summary>
        public DateTime? ToPeriodEmployment
        {
            get
            {
                if (!StartDate.HasValue && !DueDate.HasValue)
                    return (DateTime?)null;
                return (StartDate ?? DueDate)?.GetNextWeekday(DayOfWeek.Saturday).AddDays(-(7 * 15));
            }
        }

        /// <summary>
        /// Returns the [Earnings From Period] which is the same as the Employment From Period
        /// </summary>
        public DateTime? FromPeriodEarnings
        {
            get
            {
                return FromPeriodEmployment;
            }
        }
        /// <summary>
        /// Returns the [Earnings To Period] which is the first friday before the [To Period Employment]
        /// </summary>
        public DateTime? ToPeriodEarnings
        {
            get
            {
                var toPeriodEmployment = ToPeriodEmployment;
                if (!toPeriodEmployment.HasValue)
                    return (DateTime?)null;
                return (toPeriodEmployment)?.GetPreviousWeekday(DayOfWeek.Friday);
            }
        }

        /// <summary>
        /// Determines if the given assessment is eligible for SPP
        /// </summary>
        public virtual bool IsEligible
        {
            get
            {
                return (IsResponsibleFather &&
                    EmployeeWorkedInPeriod &&
                    EmployeeHasContract &&
                    (EmployeeOnPayroll || EmployeeEmployedAtBirth) &&
                    AverageWeeklyEarnings >= 118m);
            }
        }
    }
}
