using Cedita.Payroll.Models.Statutory.Assessments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedita.Payroll.Tests.Mocks
{
    public class MockSickPayAssessment
    {
        protected SickPayAssessment Assessment;

        public MockSickPayAssessment()
        {
            Assessment = new SickPayAssessment();
        }

        public MockSickPayAssessment WithStartDate(DateTime start)
        {
            Assessment.StartDate = start;
            return this;
        }

        public MockSickPayAssessment WithEndDate(DateTime start)
        {
            Assessment.EndDate = start;
            return this;
        }

        public MockSickPayAssessment WithBankHolidaysPaid(bool payBankHolidays)
        {
            Assessment.IncludeBankHolidays = payBankHolidays;
            return this;
        }

        public MockSickPayAssessment WithIsFirstSicknote(bool isFirstSicknote)
        {
            Assessment.FirstSickNote = isFirstSicknote;
            return this;
        }

        public MockSickPayAssessment WithNextPaymentDate(DateTime nextPayment)
        {
            Assessment.UpcomingPaymentDate = nextPayment;
            return this;
        }

        public SickPayAssessment GetAssessment() => Assessment;
    }
}
