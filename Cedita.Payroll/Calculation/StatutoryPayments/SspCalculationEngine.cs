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

        public IEnumerable<StatutoryPayment> Calculate(SickPayAssessment model)
        {
            if (model.UpcomingPaymentDate == DateTime.MinValue)
                throw new Exception("The next Upcoming Payment Date must be provided");

            var scheduledPayments = new List<StatutoryPayment>();

            var dailyRate = taxYearConfigurationData.StatutorySickPayDayRate;

            var allDatesInRange = model.GetQualifyingDatesInRange();
            var datesInRange = allDatesInRange.Skip(model.FirstSickNote ? 3 : 0);
            var nextPaymentDate = model.UpcomingPaymentDateForPeriod;

            var statPayment = new StatutoryPayment
            {
                ReferenceDate = nextPaymentDate,
                PaymentDate = nextPaymentDate.AddDays(7),
                Cost = dailyRate,
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
                        Cost = dailyRate,
                        Qty = 0m
                    };
                }

                if (claimDate.DayOfWeek == DayOfWeek.Saturday || claimDate.DayOfWeek == DayOfWeek.Sunday)
                    continue;

                // If we don't pay bank holidays, and the claim date is a bank holiday, don't pay this date
                if (!model.IncludeBankHolidays && BankHolidayDates.Contains(claimDate))
                    continue;

                // TODO If we have an existing sick note for this date, don't pay this date
                //

                // We do want to pay this date, woop for the worker
                statPayment.Qty += 1m;
            }

            // Add the last period
            scheduledPayments.Add(statPayment);

            // Filter out empty schedules
            return scheduledPayments.Where(m => m.Qty > 0).Select(m => m);
        }
    }
}
