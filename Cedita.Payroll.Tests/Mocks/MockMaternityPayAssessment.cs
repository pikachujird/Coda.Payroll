using Cedita.Payroll.Models.Statutory.Assessments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedita.Payroll.Tests.Mocks
{
    public class MockMaternityPayAssessment
    {
        protected MaternityPayAssessment Assessment;

        public MockMaternityPayAssessment()
        {
            Assessment = new MaternityPayAssessment();
        }

        public MockMaternityPayAssessment WithDueDate(DateTime start)
        {
            Assessment.DueDate = start;
            return this;
        }

        public MockMaternityPayAssessment WithBirthDate(DateTime start)
        {
            Assessment.BirthDate = start;
            return this;
        }

        public MockMaternityPayAssessment WithStartDate(DateTime start)
        {
            Assessment.StartDate = start;
            return this;
        }

        public MockMaternityPayAssessment WithEndDate(DateTime start)
        {
            Assessment.EndDate = start;
            return this;
        }

        public MockMaternityPayAssessment WithNextPaymentDate(DateTime nextPayment)
        {
            Assessment.UpcomingPaymentDate = nextPayment;
            return this;
        }

        public MockMaternityPayAssessment WithAverageWeeklyEarnings(decimal earnings)
        {
            Assessment.AverageWeeklyEarnings = earnings;
            return this;
        }

        public MaternityPayAssessment GetAssessment() => Assessment;
    }
}
