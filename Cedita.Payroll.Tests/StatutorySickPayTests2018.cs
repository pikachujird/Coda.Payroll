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
    public class StatutorySickPayTests2018 : StatutoryTests
    {

        [TestCategory("Statutory Sick Pay Tests"), TestMethod]
        public void CanLoadEmbeddedBankHolidayProvider()
        {
            var bankHolidayConfigData = BankHolidayDataProvider.GetBankHolidayConfigurationData();
            Assert.IsTrue(bankHolidayConfigData.BankHolidays.Count() > 0, "Bank Holiday Configuration Data Could not be loaded");

            var bankHolidaysThisYear = BankHolidayDataProvider.GetBankHolidays(new DateTime(2019, 01, 01));
            Assert.IsTrue(bankHolidaysThisYear.Count() > 0, "Bank Holiday Configuration Data for 2019 could not be found");

        }

        [TestCategory("Statutory Sick Pay Tests"), TestMethod]
        public void ValidOneWeekSickPayClaimWithWaitingDays()
        {
            // Week long sick note, this is the first sick note they have claimed
            var sickPayAssessment = (new MockSickPayAssessment())
                .WithStartDate(new DateTime(2019, 02, 18))
                .WithEndDate(new DateTime(2019, 02, 22))
                .WithNextPaymentDate(new DateTime(2019, 02, 22))
                .WithBankHolidaysPaid(false)
                .WithIsFirstSicknote(true)
                .GetAssessment();

            var statutoryPayments = GetSspCalculation(2018, sickPayAssessment).Payments;

            // Calculate 2 days sick pay
            Assert.AreEqual(2, statutoryPayments.Sum(m => m.Qty), "Unexpected total days sick pay");
            Assert.AreEqual(36.82m, statutoryPayments.Sum(m => m.Qty * m.Cost), "Unexpected amount of sick pay");
            Assert.AreEqual(1, statutoryPayments.Count(), "Unexpected total collection of payments");
        }

        [TestCategory("Statutory Sick Pay Tests"), TestMethod]
        public void ValidOneWeekSickPayClaimWithNoWaitingDays()
        {
            // Week long sick note, this is the first sick note they have claimed
            var sickPayAssessment = (new MockSickPayAssessment())
                .WithStartDate(new DateTime(2019, 02, 18))
                .WithEndDate(new DateTime(2019, 02, 22))
                .WithNextPaymentDate(new DateTime(2019, 02, 22))
                .WithBankHolidaysPaid(false)
                .WithIsFirstSicknote(false)
                .GetAssessment();

            var statutoryPayments = GetSspCalculation(2018, sickPayAssessment).Payments;

            // Calculate 2 days sick pay
            Assert.AreEqual(5, statutoryPayments.Sum(m => m.Qty), "Unexpected total days sick pay");
            Assert.AreEqual(92.05m, statutoryPayments.Sum(m => m.Qty * m.Cost), "Unexpected amount of sick pay");
            Assert.AreEqual(1, statutoryPayments.Count(), "Unexpected total collection of payments");
        }

        [TestCategory("Statutory Sick Pay Tests"), TestMethod]
        public void ValidTwoWeekSickPayClaimWithNoWaitingDaysOverMultiplePeriods()
        {
            // Week long sick note, this is the first sick note they have claimed
            var sickPayAssessment = (new MockSickPayAssessment())
                .WithStartDate(new DateTime(2019, 02, 18))
                .WithEndDate(new DateTime(2019, 03, 02))
                .WithNextPaymentDate(new DateTime(2019, 02, 22))
                .WithBankHolidaysPaid(false)
                .WithIsFirstSicknote(false)
                .GetAssessment();
              
            var statutoryPayments = GetSspCalculation(2018, sickPayAssessment).Payments;

            // Calculate 2 days sick pay
            Assert.AreEqual(10, statutoryPayments.Sum(m => m.Qty), "Unexpected total days sick pay");
            Assert.AreEqual(184.10m, statutoryPayments.Sum(m => m.Qty * m.Cost), "Unexpected amount of sick pay");
            Assert.AreEqual(2, statutoryPayments.Count(), "Unexpected total collection of payments");
            Assert.AreEqual(new DateTime(2019,03,01), statutoryPayments.First().PaymentDate, "Unexpected payment date for first payment collection");
            Assert.AreEqual(new DateTime(2019,03,08), statutoryPayments.Skip(1).Single().PaymentDate, "Unexpected payment date for second payment collection");
        }

        [TestCategory("Statutory Sick Pay Tests"), TestMethod]
        public void ValidOneWeekSickPayClaimWithBankHolidaysUnpaid()
        {
            // Week long sick note, this is the first sick note they have claimed
            var sickPayAssessment = (new MockSickPayAssessment())
                .WithStartDate(new DateTime(2019, 04, 17))
                .WithEndDate(new DateTime(2019, 04, 24))
                .WithNextPaymentDate(new DateTime(2019, 04, 19))
                .WithBankHolidaysPaid(false)
                .WithIsFirstSicknote(false)
                .GetAssessment();

            var statutoryPayments = GetSspCalculation(2018, sickPayAssessment).Payments;

            // Calculate 2 days sick pay
            Assert.AreEqual(4, statutoryPayments.Sum(m => m.Qty), "Unexpected total days sick pay");
            Assert.AreEqual(73.64m, statutoryPayments.Sum(m => m.Qty * m.Cost), "Unexpected amount of sick pay");
            Assert.AreEqual(2, statutoryPayments.Count(), "Unexpected total collection of payments");
            Assert.AreEqual(new DateTime(2019, 04, 26), statutoryPayments.First().PaymentDate, "Unexpected payment date for first payment collection");
            Assert.AreEqual(new DateTime(2019, 05, 03), statutoryPayments.Skip(1).Single().PaymentDate, "Unexpected payment date for second payment collection");
        }
    }
}
