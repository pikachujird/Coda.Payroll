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
    public class StatutoryMaternityPayTests2018 : StatutoryTests
    {

        [TestCategory("Statutory Maternity Pay Tests"), TestMethod]
        public void CanLoadEmbeddedBankHolidayProvider()
        {
            var bankHolidayConfigData = BankHolidayDataProvider.GetBankHolidayConfigurationData();
            Assert.IsTrue(bankHolidayConfigData.BankHolidays.Count() > 0, "Bank Holiday Configuration Data Could not be loaded");

            var bankHolidaysThisYear = BankHolidayDataProvider.GetBankHolidays(new DateTime(2019, 01, 01));
            Assert.IsTrue(bankHolidaysThisYear.Count() > 0, "Bank Holiday Configuration Data for 2019 could not be found");
        }

        [TestCategory("Statutory Maternity Pay Tests"), TestMethod]
        public void ValidSmpClaim()
        {
            // Week long sick note, this is the first sick note they have claimed
            var maternityPayAssessment = (new MockMaternityPayAssessment())
                .WithBirthDate(new DateTime(2019, 05, 01))
                .WithDueDate(new DateTime(2019, 05, 01))
                .WithStartDate(new DateTime(2019, 05, 01))
                .WithNextPaymentDate(new DateTime(2019, 05, 03))
                .WithAverageWeeklyEarnings(250m)
                .GetAssessment();

            var statutoryCalculation = GetSmpCalculation(2018, maternityPayAssessment);
            var statutoryPayments = statutoryCalculation.Payments;            

            // Calculate 2 days sick pay
            Assert.AreEqual(273, statutoryPayments.Sum(m => m.Qty), "Unexpected total days sick pay");
            Assert.AreEqual(6140.94m, statutoryPayments.Sum(m => m.Qty * m.Cost), "Unexpected amount of total maternity pay");
            Assert.AreEqual(1350m, statutoryPayments.Where(m => !m.IsStatutoryMinimumRate).Sum(m => m.Qty * m.Cost), "Unexpected amount of average earning pay");
            Assert.AreEqual(4790.94m, statutoryPayments.Where(m => m.IsStatutoryMinimumRate).Sum(m => m.Qty * m.Cost), "Unexpected amount of statutory maternity pay");
            Assert.AreEqual(41, statutoryPayments.Count(), "Unexpected total collection of payments");
        }

    }
}
