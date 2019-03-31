using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cedita.Payroll.Abstractions;
using Cedita.Payroll.Configuration;
using Cedita.Payroll.Models.Statutory;
using Cedita.Payroll.Models.Statutory.Assessments;

namespace Cedita.Payroll.Calculation.StatutoryPayments
{
    [CalculationEngineTaxYear(TaxYear = 2018)]
    public class SspCalculationEngine : StatutoryCalculationEngine, IStatutorySickPayCalculationEngine
    {
        public SspCalculationEngine(TaxYearConfigurationData taxYearConfigurationData, BankHolidayConfigurationData bankHolidayConfigurationData) : base(taxYearConfigurationData, bankHolidayConfigurationData) {}

        public StatutoryCalculationResult<SickPayAssessment> Calculate(SickPayAssessment model, IEnumerable<SickPayAssessment> previousSicknotes = null)
        {
            var assessmentCalculation = new StatutoryCalculationResult<SickPayAssessment>();
            if (!model.UpcomingPaymentDate.HasValue)
                assessmentCalculation.AddError(StatutoryValidationError.MissingRequiredValue, "The next Upcoming Payment Date must be provided");

            if (assessmentCalculation.Errors.Any())
                return assessmentCalculation;

            var previousSickDays = new List<DateTime>();
            // If we are providing some historical sick notes, extract the actual sick days for each of them
            if (previousSicknotes != null)
                previousSickDays = previousSicknotes.OrderBy(m => m.StartDate).SelectMany(m => GetSickDays(m)).Distinct().ToList();

            var scheduledPayments = new List<StatutoryPayment>();

            var datesInRange = GetSickDays(model);
            var nextPaymentDate = model.UpcomingPaymentDateForPeriod;

            var statPayment = new StatutoryPayment
            {
                ReferenceDate = nextPaymentDate,
                PaymentDate = nextPaymentDate.AddDays(7),
                Cost = taxYearConfigurationData.StatutorySickPayDayRate,
                Qty = 0m
            };

            foreach (var claimDate in datesInRange)
            {
                if (claimDate > nextPaymentDate)
                {
                    scheduledPayments.Add(statPayment);

                    // Next payment is one week away, Fort/Monthly change
                    nextPaymentDate = nextPaymentDate.AddDays(7);

                    statPayment = new StatutoryPayment
                    {
                        ReferenceDate = nextPaymentDate,
                        PaymentDate = nextPaymentDate.AddDays(7),
                        Cost = taxYearConfigurationData.StatutorySickPayDayRate,
                        Qty = 0m
                    };
                }

                // If we have already been paid a sick note for this date, don't pay it twice
                if (previousSickDays.Contains(claimDate))
                    continue;

                // We do want to pay this date, woop for the worker
                statPayment.Qty += 1m;
            }

            // Add the last period
            scheduledPayments.Add(statPayment);

            // Filter out empty schedules
            assessmentCalculation.Payments = scheduledPayments.Where(m => m.Qty > 0).Select(m => m);

            // If we've got to this point, we must be eligible
            assessmentCalculation.IsEligible = true;

            return assessmentCalculation;
        }

        /// <summary>
        /// Returns the actual sick days contained within a given sick pay assessment
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public IEnumerable<DateTime> GetSickDays(SickPayAssessment model)
        {
            if (!model.EndDate.HasValue || !model.StartDate.HasValue)
                return null;

            var sickDays = new List<DateTime>();
            var datesInRange = model.GetQualifyingDatesInRange().Where(m => m.DayOfWeek != DayOfWeek.Saturday && m.DayOfWeek != DayOfWeek.Sunday);

            int dayCounter = 0;
            foreach (var date in datesInRange)
            {
                dayCounter++;
                if (model.FirstSickNote && dayCounter <= 3)
                    continue;
                if (!model.IncludeBankHolidays && BankHolidayDates.Contains(date))
                    continue;
                sickDays.Add(date);
            }

            return sickDays;
        }

    }
}
