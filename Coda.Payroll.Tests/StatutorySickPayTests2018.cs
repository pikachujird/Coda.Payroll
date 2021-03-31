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
                .WithActiveContract(true)
                .WithBankHolidaysPaid(false)
                .WithIsFirstSicknote(true)
                .WithWaitingDaysApplied(true)
                .WithIsFitForWork(false)
                .WithTotalEarningsInPeriod(2000m)
                .WithTotalPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
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
                .WithActiveContract(true)
                .WithBankHolidaysPaid(false)
                .WithIsFirstSicknote(false)
                .WithWaitingDaysApplied(false)
                .WithIsFitForWork(false)
                .WithTotalEarningsInPeriod(2000m)
                .WithTotalPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
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
                .WithActiveContract(true)
                .WithBankHolidaysPaid(false)
                .WithIsFirstSicknote(false)
                .WithWaitingDaysApplied(false)
                .WithIsFitForWork(false)
                .WithTotalEarningsInPeriod(2000m)
                .WithTotalPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .GetAssessment();

            var statutoryPayments = GetSspCalculation(2018, sickPayAssessment).Payments;

            // Calculate 2 days sick pay
            Assert.AreEqual(10, statutoryPayments.Sum(m => m.Qty), "Unexpected total days sick pay");
            Assert.AreEqual(184.10m, statutoryPayments.Sum(m => m.Qty * m.Cost), "Unexpected amount of sick pay");
            Assert.AreEqual(2, statutoryPayments.Count(), "Unexpected total collection of payments");
            Assert.AreEqual(new DateTime(2019, 03, 01), statutoryPayments.First().PaymentDate, "Unexpected payment date for first payment collection");
            Assert.AreEqual(new DateTime(2019, 03, 08), statutoryPayments.Skip(1).Single().PaymentDate, "Unexpected payment date for second payment collection");
        }

        [TestCategory("Statutory Sick Pay Tests"), TestMethod]
        public void ValidOneWeekSickPayClaimWithBankHolidaysUnpaid()
        {
            // Week long sick note, this is the first sick note they have claimed
            var sickPayAssessment = (new MockSickPayAssessment())
                .WithStartDate(new DateTime(2019, 04, 17))
                .WithEndDate(new DateTime(2019, 04, 24))
                .WithActiveContract(true)
                .WithNextPaymentDate(new DateTime(2019, 04, 19))
                .WithBankHolidaysPaid(false)
                .WithIsFirstSicknote(false)
                .WithWaitingDaysApplied(false)
                .WithIsFitForWork(false)
                .WithTotalEarningsInPeriod(2000m)
                .WithTotalPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .GetAssessment();

            var statutoryAssessment = GetSspCalculation(2018, sickPayAssessment);
            var statutoryPayments = statutoryAssessment.Payments;

            // Calculate 2 days sick pay
            Assert.AreEqual(4, statutoryPayments.Sum(m => m.Qty), "Unexpected total days sick pay");
            Assert.AreEqual(73.64m, statutoryPayments.Sum(m => m.Qty * m.Cost), "Unexpected amount of sick pay");
            Assert.AreEqual(2, statutoryPayments.Count(), "Unexpected total collection of payments");
            Assert.AreEqual(new DateTime(2019, 04, 26), statutoryPayments.First().PaymentDate, "Unexpected payment date for first payment collection");
            Assert.AreEqual(new DateTime(2019, 05, 03), statutoryPayments.Skip(1).Single().PaymentDate, "Unexpected payment date for second payment collection");
        }

        [TestCategory("Statutory Sick Pay Tests"), TestMethod]
        public void ValidOverlappingSickPayClaimWithoutBankHolidays()
        {
            // Week long sick note, this is the first sick note they have claimed
            var sickPayAssessment = (new MockSickPayAssessment())
                .WithStartDate(new DateTime(2019, 04, 17))
                .WithEndDate(new DateTime(2019, 04, 24))
                .WithNextPaymentDate(new DateTime(2019, 04, 19))
                .WithActiveContract(true)
                .WithBankHolidaysPaid(false)
                .WithIsFirstSicknote(false)
                .WithWaitingDaysApplied(false)
                .WithIsFitForWork(false)
                .WithTotalEarningsInPeriod(2000m)
                .WithTotalPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .GetAssessment();

            var overlappingSickPayAssessment = (new MockSickPayAssessment())
                .WithStartDate(new DateTime(2019, 04, 22))
                .WithEndDate(new DateTime(2019, 04, 26))
                .WithNextPaymentDate(new DateTime(2019, 04, 26))
                .WithActiveContract(true)
                .WithBankHolidaysPaid(false)
                .WithIsFirstSicknote(false)
                .WithWaitingDaysApplied(false)
                .WithIsFitForWork(false)
                .WithTotalEarningsInPeriod(2000m)
                .WithTotalPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .GetAssessment();

            var sspEngine = statutoryFactory.CreateSspCalculationEngine(2018);
            var calculation = sspEngine.Calculate(overlappingSickPayAssessment, new List<SickPayAssessment> { sickPayAssessment });
            var statutoryPayments = calculation.Payments;

            // Calculate 2 days sick pay
            Assert.AreEqual(2, statutoryPayments.Sum(m => m.Qty), "Unexpected total days sick pay");
            Assert.AreEqual(36.82m, statutoryPayments.Sum(m => m.Qty * m.Cost), "Unexpected amount of sick pay");
            Assert.AreEqual(1, statutoryPayments.Count(), "Unexpected total collection of payments");
            Assert.AreEqual(new DateTime(2019, 05, 03), statutoryPayments.First().PaymentDate, "Unexpected payment date for first payment collection");
        }

        [TestCategory("Statutory Sick Pay Tests"), TestMethod]
        public void ValidOverlappingSickPayClaimWithBankHolidays()
        {
            // Week long sick note, this is the first sick note they have claimed
            var sickPayAssessment = (new MockSickPayAssessment())
                .WithStartDate(new DateTime(2019, 04, 17))
                .WithEndDate(new DateTime(2019, 04, 24))
                .WithNextPaymentDate(new DateTime(2019, 04, 19))
                .WithActiveContract(true)
                .WithBankHolidaysPaid(false)
                .WithIsFirstSicknote(false)
                .WithWaitingDaysApplied(false)
                .WithIsFitForWork(false)
                .WithTotalEarningsInPeriod(2000m)
                .WithTotalPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .GetAssessment();

            var overlappingSickPayAssessment = (new MockSickPayAssessment())
                .WithStartDate(new DateTime(2019, 04, 22))
                .WithEndDate(new DateTime(2019, 04, 26))
                .WithNextPaymentDate(new DateTime(2019, 04, 26))
                .WithActiveContract(true)
                .WithBankHolidaysPaid(true)
                .WithIsFirstSicknote(false)
                .WithWaitingDaysApplied(false)
                .WithIsFitForWork(false)
                .WithTotalEarningsInPeriod(2000m)
                .WithTotalPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .GetAssessment();

            var sspEngine = statutoryFactory.CreateSspCalculationEngine(2018);
            var calculation = sspEngine.Calculate(overlappingSickPayAssessment, new List<SickPayAssessment> { sickPayAssessment });
            var statutoryPayments = calculation.Payments;

            // Calculate 2 days sick pay
            Assert.AreEqual(3, statutoryPayments.Sum(m => m.Qty), "Unexpected total days sick pay");
            Assert.AreEqual(55.23m, statutoryPayments.Sum(m => m.Qty * m.Cost), "Unexpected amount of sick pay");
            Assert.AreEqual(1, statutoryPayments.Count(), "Unexpected total collection of payments");
            Assert.AreEqual(new DateTime(2019, 05, 03), statutoryPayments.First().PaymentDate, "Unexpected payment date for first payment collection");
        }

        [TestCategory("Statutory Sick Pay Tests"), TestMethod]
        public void ValidOverlappingSickPayClaimWith3HistoricalClaims()
        {
            // Week long sick note, this is the first sick note they have claimed
            var sickPayAssessment = (new MockSickPayAssessment())
                .WithStartDate(new DateTime(2019, 04, 17))
                .WithEndDate(new DateTime(2019, 04, 24))
                .WithNextPaymentDate(new DateTime(2019, 04, 19))
                .WithActiveContract(true)
                .WithBankHolidaysPaid(false)
                .WithIsFirstSicknote(false)
                .WithWaitingDaysApplied(false)
                .WithIsFitForWork(false)
                .WithTotalEarningsInPeriod(2000m)
                .WithTotalPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .GetAssessment();

            var overlappingSickPayAssessment = (new MockSickPayAssessment())
                .WithStartDate(new DateTime(2019, 04, 22))
                .WithEndDate(new DateTime(2019, 04, 26))
                .WithNextPaymentDate(new DateTime(2019, 04, 26))
                .WithActiveContract(true)
                .WithBankHolidaysPaid(false)
                .WithIsFirstSicknote(false)
                .WithWaitingDaysApplied(false)
                .WithIsFitForWork(false)
                .WithTotalEarningsInPeriod(2000m)
                .WithTotalPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .GetAssessment();

            var finalSickPayAssessment = (new MockSickPayAssessment())
                .WithStartDate(new DateTime(2019, 04, 15))
                .WithEndDate(new DateTime(2019, 05, 10))
                .WithNextPaymentDate(new DateTime(2019, 04, 19))
                .WithActiveContract(true)
                .WithBankHolidaysPaid(false)
                .WithIsFirstSicknote(false)
                .WithWaitingDaysApplied(false)
                .WithIsFitForWork(false)
                .WithTotalEarningsInPeriod(2000m)
                .WithTotalPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .GetAssessment();

            var sspEngine = statutoryFactory.CreateSspCalculationEngine(2018);
            var calculation = sspEngine.Calculate(finalSickPayAssessment, new List<SickPayAssessment> { sickPayAssessment, overlappingSickPayAssessment });
            var statutoryPayments = calculation.Payments;

            // Calculate 2 days sick pay
            Assert.AreEqual(11, statutoryPayments.Sum(m => m.Qty), "Unexpected total days sick pay");
            Assert.AreEqual(202.51m, statutoryPayments.Sum(m => m.Qty * m.Cost), "Unexpected amount of sick pay");
            Assert.AreEqual(3, statutoryPayments.Count(), "Unexpected total collection of payments");
            Assert.AreEqual(new DateTime(2019, 04, 26), statutoryPayments.First().PaymentDate, "Unexpected payment date for first payment collection");
        }


        [TestCategory("Statutory Sick Pay Tests"), TestMethod]
        public void ValidOneWeekSickPayClaimWithWaitingDaysAndUnpaidBankHolidays()
        {
            /*•	Please can the logic be applied that if one of the waiting days falls on a bank holiday when we say NO to pay bank holidays that the next working day is used to 
             * apply the waiting day, EG: sick note for 02/05-16/05. 3 waiting days = 02/05, 03/05 and 07/05 as 06/05 is a bank holiday. */
            // Week long sick note, this is the first sick note they have claimed
            var sickPayAssessment = (new MockSickPayAssessment())
                .WithStartDate(new DateTime(2019, 05, 02))
                .WithEndDate(new DateTime(2019, 05, 16))
                .WithNextPaymentDate(new DateTime(2019, 05, 03))
                .WithActiveContract(true)
                .WithBankHolidaysPaid(false)
                .WithIsFirstSicknote(true)
                .WithWaitingDaysApplied(true)
                .WithIsFitForWork(false)
                .WithTotalEarningsInPeriod(2000m)
                .WithTotalPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .GetAssessment();

            var statutoryPayments = GetSspCalculation(2018, sickPayAssessment).Payments;

            // In this instance, the 2nd, 3rd and 7th are the 3 waiting days, with the 6th being a bank holiday
            // The first payment group should only be a sum of 3 days
            Assert.AreEqual(3, statutoryPayments.First().Qty, "Unexpected total days sick in first week");
            Assert.AreEqual(7 * 18.41m, statutoryPayments.Sum(m => m.Qty * m.Cost), "Unexpected amount of sick pay");
            Assert.AreEqual(2, statutoryPayments.Count(), "Unexpected total collection of payments");
        }

        [TestCategory("Statutory Sick Pay Tests"), TestMethod]
        public void ValidSspClaimWith140DayCap()
        {
            var sickPayAssessment = (new MockSickPayAssessment())
                .WithStartDate(new DateTime(2019, 05, 02))
                .WithEndDate(new DateTime(2019, 05, 16))
                .WithNextPaymentDate(new DateTime(2019, 05, 03))
                .WithActiveContract(true)
                .WithBankHolidaysPaid(false)
                .WithIsFirstSicknote(true)
                .WithWaitingDaysApplied(true)
                .WithIsFitForWork(false)
                .WithTotalEarningsInPeriod(2000m)
                .WithTotalPaymentsInPeriod(8)
                .WithHistoricalSickDayTotal(139)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .GetAssessment();

            var statutoryPayments = GetSspCalculation(2018, sickPayAssessment).Payments;

            // In this instance, the 2nd, 3rd and 7th are the 3 waiting days, with the 6th being a bank holiday
            // The first payment group should only be a sum of 3 days
            Assert.AreEqual(1, statutoryPayments.First().Qty, "Unexpected total days sick in first week");
            Assert.AreEqual(1 * 18.41m, statutoryPayments.Sum(m => m.Qty * m.Cost), "Unexpected amount of sick pay");
            Assert.AreEqual(1, statutoryPayments.Count(), "Unexpected total collection of payments");

        }

        [TestCategory("Statutory Sick Pay Tests"), TestMethod]
        public void ValidOverlappingSspClaimForSamePeriod()
        {
            var firstSickPayAssessment = (new MockSickPayAssessment())
                .WithStartDate(new DateTime(2019, 06, 20))
                .WithEndDate(new DateTime(2019, 06, 26))
                .WithNextPaymentDate(new DateTime(2019, 06, 21))
                .WithActiveContract(true)
                .WithBankHolidaysPaid(true)
                .WithIsFirstSicknote(true)
                .WithWaitingDaysApplied(true)
                .WithIsFitForWork(false)
                .WithTotalEarningsInPeriod(1925.58m)
                .WithTotalPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .GetAssessment();

            var overlappingSickPayAssessment = (new MockSickPayAssessment())
                .WithStartDate(new DateTime(2019, 06, 20))
                .WithEndDate(new DateTime(2019, 07, 04))
                .WithNextPaymentDate(new DateTime(2019, 06, 21))
                .WithActiveContract(true)
                .WithBankHolidaysPaid(true)
                .WithIsFirstSicknote(false)
                .WithWaitingDaysApplied(false)
                .WithIsFitForWork(false)
                .WithTotalEarningsInPeriod(1925.58m)
                .WithTotalPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .GetAssessment();

            var sspEngine = statutoryFactory.CreateSspCalculationEngine(2019);
            var calculation = sspEngine.Calculate(overlappingSickPayAssessment, new List<SickPayAssessment> { firstSickPayAssessment });
            var statutoryPayments = calculation.Payments;

            Assert.AreEqual(6, statutoryPayments.Sum(m => m.Qty), "Unexpected total days sick pay");
            Assert.AreEqual(113.1m, statutoryPayments.Sum(m => m.Qty * m.Cost), "Unexpected amount of sick pay");
            Assert.AreEqual(2, statutoryPayments.Count(), "Unexpected total collection of payments");
            Assert.AreEqual(new DateTime(2019, 07, 05), statutoryPayments.First().PaymentDate, "Unexpected payment date for first payment collection");

        }

        [TestCategory("Statutory Sick Pay Tests"), TestMethod]
        public void UpdatedAverageWeeklyEarnings()
        {
            var sickPayAssessment = (new MockSickPayAssessment())
                .WithStartDate(new DateTime(2019, 05, 02))
                .WithEndDate(new DateTime(2019, 06, 16))
                .WithNextPaymentDate(new DateTime(2019, 05, 03))
                .WithActiveContract(true)
                .WithBankHolidaysPaid(false)
                .WithIsFirstSicknote(true)
                .WithWaitingDaysApplied(true)
                .WithIsFitForWork(false)
                .WithTotalEarningsInPeriod(2000m)
                .WithTotalPaymentsInPeriod(2)
                .WithHistoricalSickDayTotal(139)
                .WithPaymentFrequency(PayPeriods.Monthly)
                .GetAssessment();

            var monthlyAvgEarnings = GetSspCalculation(2019, sickPayAssessment).Assessment.AverageWeeklyEarnings;
            Assert.AreEqual(230.77100593081485242194170724m, monthlyAvgEarnings, "Monthly average earnings unexpected");

            sickPayAssessment.Frequency = PayPeriods.Fortnightly;
            sickPayAssessment.TotalPaymentsInPeriod = 4;
            var fortnightlyAvgEarnings = GetSspCalculation(2019, sickPayAssessment).Assessment.AverageWeeklyEarnings;
            Assert.AreEqual(250m, fortnightlyAvgEarnings, "Fortnightly average earnings unexpected");

            sickPayAssessment.Frequency = PayPeriods.Weekly;
            sickPayAssessment.TotalPaymentsInPeriod = 8;
            var weeklyAvgEarnings = GetSspCalculation(2019, sickPayAssessment).Assessment.AverageWeeklyEarnings;
            Assert.AreEqual(250, weeklyAvgEarnings, "Weekly average earnings unexpected");

        }

        [TestCategory("Statutory Sick Pay Tests"), TestMethod]
        public void ValidSickNoteWithManualWaitingDaysPaid()
        {
            var firstSickPayAssessment = (new MockSickPayAssessment())
                .WithStartDate(new DateTime(2019, 11, 04))
                .WithEndDate(new DateTime(2019, 11, 08))
                .WithNextPaymentDate(new DateTime(2019, 06, 21))
                .WithActiveContract(true)
                .WithBankHolidaysPaid(true)
                .WithIsFirstSicknote(true)
                .WithWaitingDaysApplied(true)
                .WithIsFitForWork(false)
                .WithTotalEarningsInPeriod(1925.58m)
                .WithTotalPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .GetAssessment();

            var secondSickPayAssessment = (new MockSickPayAssessment())
                .WithStartDate(new DateTime(2019, 11, 11))
                .WithEndDate(new DateTime(2019, 11, 15))
                .WithNextPaymentDate(new DateTime(2019, 06, 21))
                .WithActiveContract(true)
                .WithBankHolidaysPaid(true)
                .WithIsFirstSicknote(false)
                .WithWaitingDaysApplied(false)
                .WithIsFitForWork(false)
                .WithTotalEarningsInPeriod(1925.58m)
                .WithTotalPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .GetAssessment();

            var sspEngine = statutoryFactory.CreateSspCalculationEngine(2019);
            var calculation = sspEngine.Calculate(firstSickPayAssessment);
            var statutoryPayments = calculation.Payments;

            Assert.AreEqual(2, statutoryPayments.Sum(m => m.Qty), "Unexpected total days sick pay");
            Assert.AreEqual(37.70m, statutoryPayments.Sum(m => m.Qty * m.Cost), "Unexpected amount of sick pay");

            var altCalculation = sspEngine.Calculate(secondSickPayAssessment);
            var altStatutoryPayments = altCalculation.Payments;

            Assert.AreEqual(5, altStatutoryPayments.Sum(m => m.Qty), "Unexpected total days sick pay");
            Assert.AreEqual(94.25m, altStatutoryPayments.Sum(m => m.Qty * m.Cost), "Unexpected amount of sick pay");

        }


        [TestCategory("Statutory Sick Pay Tests"), TestMethod]
        public void ValidSickNoteWithAwaitingDirstButNotFirst()
        {
            var sickPayAssessment = (new MockSickPayAssessment())
                .WithStartDate(new DateTime(2019, 11, 04))
                .WithEndDate(new DateTime(2019, 11, 08))
                .WithNextPaymentDate(new DateTime(2019, 06, 21))
                .WithActiveContract(true)
                .WithBankHolidaysPaid(true)
                .WithIsFirstSicknote(false)
                .WithWaitingDaysApplied(true)
                .WithIsFitForWork(false)
                .WithTotalEarningsInPeriod(1925.58m)
                .WithTotalPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .GetAssessment();

            var sspEngine = statutoryFactory.CreateSspCalculationEngine(2019);
            var calculation = sspEngine.Calculate(sickPayAssessment);
            var statutoryPayments = calculation.Payments;

            Assert.AreEqual(2, statutoryPayments.Sum(m => m.Qty), "Unexpected total days sick pay");
            Assert.AreEqual(37.70m, statutoryPayments.Sum(m => m.Qty * m.Cost), "Unexpected amount of sick pay");
        }

        [TestCategory("Statutory Sick Pay Tests"), TestMethod]
        public void ValidSickNoteWithoutSickDayOverride()
        {
            var sickPayAssessment = (new MockSickPayAssessment())
                .WithStartDate(new DateTime(2020, 02, 06))
                .WithEndDate(new DateTime(2020, 02, 17))
                .WithNextPaymentDate(new DateTime(2020, 02, 07))
                .WithActiveContract(true)
                .WithBankHolidaysPaid(true)
                .WithIsFirstSicknote(false)
                .WithWaitingDaysApplied(false)
                .WithIsFitForWork(false)
                .WithTotalEarningsInPeriod(3500.00m)
                .WithTotalPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .WithSupersedeSickDayLimit(false)
                .WithHistoricalSickDayTotal(135)
                .GetAssessment();

            var sspEngine = statutoryFactory.CreateSspCalculationEngine(2019);
            var calculation = sspEngine.Calculate(sickPayAssessment);
            var statutoryPayments = calculation.Payments;

            Assert.AreEqual(5, statutoryPayments.Sum(m => m.Qty), "Unexpected total days sick pay");
        }

        [TestCategory("Statutory Sick Pay Tests"), TestMethod]
        public void ValidSickNoteWithSickDayOverride()
        {
            var sickPayAssessment = (new MockSickPayAssessment())
                .WithStartDate(new DateTime(2020, 02, 06))
                .WithEndDate(new DateTime(2020, 02, 17))
                .WithNextPaymentDate(new DateTime(2020, 02, 07))
                .WithActiveContract(true)
                .WithBankHolidaysPaid(true)
                .WithIsFirstSicknote(false)
                .WithWaitingDaysApplied(false)
                .WithIsFitForWork(false)
                .WithTotalEarningsInPeriod(3500.00m)
                .WithTotalPaymentsInPeriod(8)
                .WithPaymentFrequency(PayPeriods.Weekly)
                .WithSupersedeSickDayLimit(true)
                .WithHistoricalSickDayTotal(135)
                .GetAssessment();

            var sspEngine = statutoryFactory.CreateSspCalculationEngine(2019);
            var calculation = sspEngine.Calculate(sickPayAssessment);
            var statutoryPayments = calculation.Payments;

            Assert.AreEqual(8, statutoryPayments.Sum(m => m.Qty), "Unexpected total days sick pay");
        }
    }
}
