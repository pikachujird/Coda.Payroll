using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedita.Payroll.Models.Statutory.Assessments
{
    public class PaternityPayAssessment : BaseStatutoryAssessment
    {
        /// <summary>
        /// Question 1
        /// </summary>
        public DateTime DueDate { get; set; }
        /// <summary>
        /// Question 2
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// Question 3
        /// </summary>
        public bool IsResponsibleFather { get; set; }
        /// <summary>
        /// Question 4
        /// </summary>
        public bool EmployeeWorkedInPeriod { get; set; }
        /// <summary>
        /// Question 5
        /// </summary>
        public bool EmployeeHasContract { get; set; }
        /// <summary>
        /// Question 6
        /// </summary>
        public bool EmployeeOnPayroll { get; set; }
        /// <summary>
        /// Question 7
        /// </summary>
        public bool EmployeeEmployedAtBirth { get; set; }
        /// <summary>
        /// Question 8
        /// </summary>
        public DateTime ClaimStartDate { get; set; }
        /// <summary>
        /// Question 9
        /// </summary>
        public int TotalClaimDays { get; set; }
        /// <summary>
        /// Question 10
        /// </summary>
        public DateTime LastNormalPayDayToPeriod { get; set; }
        /// <summary>
        /// Question 11
        /// </summary>
        public DateTime LastNormalPayDayFromPeriod { get; set; }
        /// <summary>
        /// Question 13
        /// </summary>
        public decimal TotalEarningsInPeriod { get; set; }
        /// <summary>
        /// Question 14
        /// </summary>
        public int TotalPaymentsInPeriod { get; set; }
        /// <summary>
        /// Question 16
        /// </summary>
        public DateTime WorkerNoticeReceivedDate { get; set; }

        /// <summary>
        /// Determines if the given assessment is eligible for SPP
        /// </summary>
        public bool IsEligible
        {
            get
            {
                return (IsResponsibleFather &&
                    EmployeeWorkedInPeriod &&
                    EmployeeHasContract &&
                    EmployeeOnPayroll &&
                    EmployeeEmployedAtBirth &&
                    AverageWeeklyEarnings >= 116m);
            }
        }
    }
}
