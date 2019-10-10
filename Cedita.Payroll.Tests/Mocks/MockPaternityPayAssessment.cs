using Cedita.Payroll.Models.Statutory.Assessments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedita.Payroll.Tests.Mocks
{
    public class MockPaternityPayAssessment
    {
        protected PaternityPayAssessment Assessment;

        public MockPaternityPayAssessment()
        {
            Assessment = new PaternityPayAssessment();
        }

        public MockPaternityPayAssessment WithDueDate(DateTime start)
        {
            Assessment.DueDate = start;
            Assessment.BirthDate = start;
            return this;
        }

        public MockPaternityPayAssessment WithBirthDate(DateTime start)
        {
            Assessment.BirthDate = start;
            return this;
        }

        public MockPaternityPayAssessment WithStartDate(DateTime start)
        {
            Assessment.StartDate = start;
            return this;
        }

        public MockPaternityPayAssessment WithEndDate(DateTime start)
        {
            Assessment.EndDate = start;
            return this;
        }

        public MockPaternityPayAssessment WithNextPaymentDate(DateTime nextPayment)
        {
            Assessment.UpcomingPaymentDate = nextPayment;
            return this;
        }

        public MockPaternityPayAssessment WithEarningsInPeriod(decimal earnings)
        {
            Assessment.TotalEarningsInPeriod = earnings;
            return this;
        }

        public MockPaternityPayAssessment WithPaymentsInPeriod(int payments)
        {
            Assessment.TotalPaymentsInPeriod = payments;
            return this;
        }

        public MockPaternityPayAssessment WithTotalClaimDays(int claimDays)
        {
            Assessment.TotalClaimDays = claimDays;
            Assessment.EndDate = Assessment.StartDate.Value.AddDays(claimDays);
            return this;
        }

        public MockPaternityPayAssessment WithIsResponsibleFatherAnswer(bool answer)
        {
            Assessment.IsResponsibleFather = answer;
            return this;
        }
        public MockPaternityPayAssessment WithEmployeeWorkedInPeriodAnswer(bool answer)
        {
            Assessment.EmployeeWorkedInPeriod = answer;
            return this;
        }
        public MockPaternityPayAssessment WithEmployeeHasContractAnswer(bool answer)
        {
            Assessment.EmployeeHasContract = answer;
            return this;
        }
        public MockPaternityPayAssessment WithEmployeeOnPayrollAnswer(bool answer)
        {
            Assessment.EmployeeOnPayroll = answer;
            return this;
        }
        public MockPaternityPayAssessment WithEmployedAtBirthAnswer(bool answer)
        {
            Assessment.EmployeeEmployedAtBirth = answer;
            return this;
        }

        public MockPaternityPayAssessment WithPaymentFrequency(PayPeriods frequency)
        {
            Assessment.Frequency = frequency;
            return this;
        }

        public PaternityPayAssessment GetAssessment() => Assessment;
    }
}
