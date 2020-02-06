using System;

namespace Cedita.Payroll.Models.Statutory.Assessments
{
    public class SickPayAssessment : BaseStatutoryAssessment
    {
        public bool IsFitForWork { get; set; }
        public bool ApplyWaitingDays { get; set; }
        public bool IncludeBankHolidays { get; set; }
        public bool FirstSickNote { get; set; }
        public bool HasEightWeekGapSincePreviousSicknote { get; set; }
        public int PreviousSickDaysTotal { get; set; }
        public DateTime? DateCaseAssessed { get; set; }
        public bool SupersedeSickDayLimit { get; set; }
        public int TotalUnclaimedSickDays { get; set; }

        /// <summary>
        /// Determines if the given assessment is eligible for SPP
        /// </summary>
        public bool IsEligible => !IsFitForWork && AverageWeeklyEarnings >= 118m && PreviousSickDaysTotal < 140 && EmployeeHasContract;
    }
}
