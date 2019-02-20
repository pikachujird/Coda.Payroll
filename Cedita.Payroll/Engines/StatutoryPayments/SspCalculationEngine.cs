using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cedita.Payroll.Models.Statutory;
using Cedita.Payroll.Models.Statutory.Assessments;
using Cedita.Payroll.Models.TaxYearSpecifics;

namespace Cedita.Payroll.Engines.StatutoryPayments
{
    [EngineApplicableTaxYear(TaxYearStartYear = 2018)]
    public class SspCalculationEngine : StatutoryCalculationEngine, IStatutorySickPayCalculationEngine
    {
        public IEnumerable<StatutoryPayment> Calculate(SickPayAssessment model)
        {
            var dailyRate = TaxYearSpecificProvider.GetSpecificValue<decimal>(TaxYearSpecificValues.StatutorySickPayDayRate);

            var scheduledPayments = new List<StatutoryPayment>();
            var datesInRange = model.GetQualifyingDatesInRange();
            var nextPaymentDate = model.UpcomingPaymentDateForPeriod;

            var statPayment = new StatutoryPayment
            {
                ReferenceDate = nextPaymentDate,
                PaymentDate = nextPaymentDate,
                Cost = dailyRate,
                Qty = 0m
            };

            foreach (var claimDate in datesInRange)
            {
                if (claimDate > nextPaymentDate)
                {
                    scheduledPayments.Add(statPayment);

                    statPayment = new StatutoryPayment
                    {
                        ReferenceDate = nextPaymentDate,
                        PaymentDate = nextPaymentDate.AddDays(7),
                        Cost = dailyRate,
                        Qty = 0m
                    };

                    // Next payment is one week away, Fort/Monthly change
                    nextPaymentDate = nextPaymentDate.AddDays(7);
                }

                if (claimDate.DayOfWeek == DayOfWeek.Saturday || claimDate.DayOfWeek == DayOfWeek.Sunday)
                    continue;

                // If we don't pay bank holidays, don't pay this date
                if (model.IncludeBankHolidays && claimDate.IsBankHoliday())
                    continue;

                // If we have an existing sick note for this date, don't pay this date
                //

                // We do want to pay this date, woop for the worker
                statPayment.Qty += 1m;
            }

            // Add the last period
            scheduledPayments.Add(statPayment);

            return new List<StatutoryPayment>
            {
                new StatutoryPayment { Qty = 1, Cost = dailyRate }
            };
        }
    }
}
