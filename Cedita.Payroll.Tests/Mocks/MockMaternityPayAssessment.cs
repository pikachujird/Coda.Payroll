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

        public MockMaternityPayAssessment WithEarningsInPeriod(decimal earnings)
        {
            Assessment.TotalEarningsInPeriod = earnings;
            return this;
        }

        public MockMaternityPayAssessment WithPaymentsInPeriod(int payments)
        {
            Assessment.TotalPaymentsInPeriod = payments;
            return this;
        }

        public MockMaternityPayAssessment WithEmploymentContract(bool hasContract)
        {
            Assessment.EmployeeHasContract = hasContract;
            return this;
        }

        public MockMaternityPayAssessment WithPaymentFrequency(PayPeriods frequency)
        {
            Assessment.Frequency = frequency;
            return this;
        }

        public MaternityPayAssessment GetAssessment() => Assessment;
    }
}
