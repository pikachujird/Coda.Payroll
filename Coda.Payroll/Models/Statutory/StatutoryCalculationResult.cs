using Coda.Payroll.Models.Statutory.Assessments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coda.Payroll.Models.Statutory
{
    public enum StatutoryValidationError
    {
        MissingRequiredValue,
        InvalidUpcomingPayDate,

        InvalidStartDate
    }

    public class StatutoryCalculationResult<TAssessment> 
        where TAssessment : class, IStatutoryAssessment
    {
        public bool IsEligible { get; set; } = false;
        public TAssessment Assessment { get; set; }

        public Dictionary<StatutoryValidationError, string> Errors { get; set; } = new Dictionary<StatutoryValidationError, string>();
        public IEnumerable<StatutoryPayment> Payments { get; set; }

        /// <summary>
        /// Adds an assessment validation error
        /// </summary>
        /// <param name="validationError"></param>
        /// <param name="message"></param>
        public void AddError(StatutoryValidationError validationError, string message) => Errors[validationError] = message;
    }
}
