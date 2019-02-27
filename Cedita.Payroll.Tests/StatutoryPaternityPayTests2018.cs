using Cedita.Payroll.Models.Statutory.Assessments;
using Cedita.Payroll.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedita.Payroll.Tests
{
    [TestClass]
    public class StatutoryPaternityPayTests2018 : StatutoryTests
    {

        [TestCategory("Statutory Paternity Pay Tests"), TestMethod]
        public void CanLoadEmbeddedBankHolidayProvider()
        {
            var bankHolidayConfigData = BankHolidayDataProvider.GetBankHolidayConfigurationData();
            Assert.IsTrue(bankHolidayConfigData.BankHolidays.Count() > 0, "Bank Holiday Configuration Data Could not be loaded");

            var bankHolidaysThisYear = BankHolidayDataProvider.GetBankHolidays(new DateTime(2019, 01, 01));
            Assert.IsTrue(bankHolidaysThisYear.Count() > 0, "Bank Holiday Configuration Data for 2019 could not be found");
        }

        [TestCategory("Statutory Paternity Pay Tests"), TestMethod]
        public void ValidTwoWeekSppClaim()
        {
            // Week long sick note, this is the first sick note they have claimed
            var paternityPayAssessment = (new MockPaternityPayAssessment())
                .WithDueDate(new DateTime(2019, 05, 01))
                .WithStartDate(new DateTime(2019, 05, 01))
                .WithNextPaymentDate(new DateTime(2019, 05, 03))
                .WithTotalClaimDays(13)
                .WithAverageWeeklyEarnings(250m)
                .WithIsResponsibleFatherAnswer(true)
                .WithEmployeeWorkedInPeriodAnswer(true)
                .WithEmployeeHasContractAnswer(true)
                .WithEmployeeOnPayrollAnswer(true)
                .WithEmployedAtBirthAnswer(true)
                .GetAssessment();

            var assessmentCalculation = GetSppCalculation(2018, paternityPayAssessment);
            var statutoryPayments = assessmentCalculation.Payments;

            // Calculate 2 days sick pay
            Assert.AreEqual(14, statutoryPayments.Sum(m => m.Qty), "Unexpected total days paternity pay");
            Assert.AreEqual(290.36m, statutoryPayments.Sum(m => m.Qty * m.Cost), "Unexpected amount of total paternity pay");
            Assert.AreEqual(3, statutoryPayments.Count(), "Unexpected total collection of payments");

            var firstPayment = statutoryPayments.First();
            Assert.AreEqual(62.22m, firstPayment.Qty * firstPayment.Cost, "Unexpected total sum of first payments");
            var secondPayment = statutoryPayments.Skip(1).First();
            Assert.AreEqual(145.18m, secondPayment.Qty * secondPayment.Cost, "Unexpected total sum of second payments");
            var finalPayment = statutoryPayments.Skip(2).First();
            Assert.AreEqual(82.96m, finalPayment.Qty * finalPayment.Cost, "Unexpected total sum of final payments");
        }

    }
}
