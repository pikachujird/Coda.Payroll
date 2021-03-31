using Coda.Payroll.Models.Statutory.Assessments;
using Coda.Payroll.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coda.Payroll.Tests
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
                .WithEmploymentContract(true)
                .WithEarningsInPeriod(2000m)
                .WithPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
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

        [TestCategory("Statutory Maternity Pay Tests"), TestMethod]
        public void ValidComplexSmpClaim()
        {
            // Week long sick note, this is the first sick note they have claimed
            var maternityPayAssessment = (new MockMaternityPayAssessment())
                .WithBirthDate(new DateTime(2019, 05, 01))
                .WithDueDate(new DateTime(2019, 05, 01))
                .WithStartDate(new DateTime(2019, 05, 01))
                .WithNextPaymentDate(new DateTime(2019, 05, 03))
                .WithEmploymentContract(true)
                .WithEarningsInPeriod(7454.24m)
                .WithPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .GetAssessment();

            var statutoryCalculation = GetSmpCalculation(2018, maternityPayAssessment);
            var statutoryPayments = statutoryCalculation.Payments;

            // Calculate 2 days sick pay
            Assert.AreEqual(273, statutoryPayments.Sum(m => m.Qty), "Unexpected total days sick pay");
            Assert.AreEqual(9822.61m, statutoryPayments.Sum(m => m.Total), "Unexpected amount of total maternity pay");
            Assert.AreEqual(5031.67m, statutoryPayments.Where(m => !m.IsStatutoryMinimumRate).Sum(m => m.Total), "Unexpected amount of average earning pay");
            Assert.AreEqual(4790.94m, statutoryPayments.Where(m => m.IsStatutoryMinimumRate).Sum(m => m.Total), "Unexpected amount of statutory maternity pay");
            Assert.AreEqual(41, statutoryPayments.Count(), "Unexpected total collection of payments");
        }

        [TestCategory("Statutory Maternity Pay Tests"), TestMethod]
        public void SmpLowestPayments()
        {
            // Week long sick note, this is the first sick note they have claimed
            var maternityPayAssessment = (new MockMaternityPayAssessment())
                .WithBirthDate(new DateTime(2020, 02, 01))
                .WithDueDate(new DateTime(2020, 02, 01))
                .WithStartDate(new DateTime(2020, 02, 01))
                .WithNextPaymentDate(new DateTime(2020, 02, 03))
                .WithEmploymentContract(true)
                .WithEarningsInPeriod(1000m)
                .WithPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .GetAssessment();


            var statutoryCalculation = GetSmpCalculation(2019, maternityPayAssessment);
            var statutoryPayments = statutoryCalculation.Payments;

            Assert.AreEqual(16.07m, Math.Round(statutoryPayments.FirstOrDefault().Cost, 2, MidpointRounding.AwayFromZero), "SMP Amount Value.");
            Assert.AreEqual(16.07m, Math.Round(statutoryPayments.LastOrDefault().Cost, 2, MidpointRounding.AwayFromZero), "SMP Amount Value.");
            Assert.IsTrue(statutoryPayments.All(x => Math.Round(x.Cost, 2, MidpointRounding.AwayFromZero) == 16.07m));

        }

        [TestCategory("Statutory Maternity Pay Tests"), TestMethod]
        public void SmpAverageEarningsCalculationTest()
        {
            // Week long sick note, this is the first sick note they have claimed
            var maternityPayAssessment = (new MockMaternityPayAssessment())
                .WithBirthDate(new DateTime(2020, 01, 07))
                .WithDueDate(new DateTime(2020, 01, 07))
                .WithStartDate(new DateTime(2020, 01, 07))
                .WithNextPaymentDate(new DateTime(2020, 01, 10))
                .WithEmploymentContract(true)
                .WithEarningsInPeriod(2000m)
                .WithPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .GetAssessment();

            var statutoryCalculation = GetSmpCalculation(2019, maternityPayAssessment);
            var statutoryPayments = statutoryCalculation.Payments;

            var firstFullWeekPaymentAverageEarnings = statutoryPayments.Skip(1).First();
            Assert.AreEqual(225m, Math.Round(firstFullWeekPaymentAverageEarnings.Total, 2, MidpointRounding.AwayFromZero), "Average Earnings Total");
        }

        [TestCategory("Statutory Maternity Pay Tests"), TestMethod]
        public void SmpBelowMinimumEarningsCalculationTest()
        {
            // Week long sick note, this is the first sick note they have claimed
            var maternityPayAssessment = (new MockMaternityPayAssessment())
                .WithBirthDate(new DateTime(2020, 01, 07))
                .WithDueDate(new DateTime(2020, 01, 07))
                .WithStartDate(new DateTime(2020, 01, 07))
                .WithNextPaymentDate(new DateTime(2020, 01, 10))
                .WithEmploymentContract(true)
                .WithEarningsInPeriod(500m)
                .WithPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .GetAssessment();

            var statutoryCalculation = GetSmpCalculation(2019, maternityPayAssessment);
            var statutoryPayments = statutoryCalculation.Payments;

            // Ensure the figure below statutory minimum is used (90% of average earnings)
            Assert.AreEqual(2193.77m, Math.Round(statutoryPayments.Sum(x => x.Total), 2, MidpointRounding.AwayFromZero), "Below Statutory Earnings Total");
        }

        [TestCategory("Statutory Maternity Pay Tests"), TestMethod]
        public void Calculate42CorrectPaymentsAtNintyPercent()
        {
            // Week long sick note, this is the first sick note they have claimed
            var maternityPayAssessment = (new MockMaternityPayAssessment())
                .WithBirthDate(new DateTime(2020, 07, 01))
                .WithDueDate(new DateTime(2020, 07, 01))
                .WithStartDate(new DateTime(2020, 04, 12))
                .WithNextPaymentDate(new DateTime(2020, 04, 24))
                .WithEmploymentContract(true)
                .WithEarningsInPeriod(2000m)
                .WithPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .GetAssessment();

            var statutoryCalculation = GetSmpCalculation(2019, maternityPayAssessment);
            //The first 6 payments should be calculated at 90% of their weekly rate. E.g. £250 / 0.9 = £225. £225 / 7 = £32.14 (the average day rate).
            var statutoryPayments = statutoryCalculation.Payments.Take(6);

            var averageCost = Math.Round(statutoryPayments.Average(x => x.Cost), 2, MidpointRounding.AwayFromZero);

            Assert.AreEqual(32.14m, averageCost, "Below Statutory Earnings Total");

        }
    }
}
