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

        public MockSickPayAssessment WithActiveContract(bool hasContract)
        {
            Assessment.EmployeeHasContract = hasContract;
            return this;
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

        public MockSickPayAssessment WithTotalEarningsInPeriod(decimal totalEarnings)
        {
            Assessment.TotalEarningsInPeriod = totalEarnings;
            return this;
        }

        public MockSickPayAssessment WithTotalPaymentsInPeriod(int totalPayments)
        {
            Assessment.TotalPaymentsInPeriod = totalPayments;
            return this;
        }

        public MockSickPayAssessment WithIsFitForWork(bool isFit)
        {
            Assessment.IsFitForWork = isFit;
            return this;
        }
        public MockSickPayAssessment WithHistoricalSickDayTotal(int total)
        {
            Assessment.PreviousSickDaysTotal = total;
            return this;
        }

        public SickPayAssessment GetAssessment() => Assessment;
    }
}
