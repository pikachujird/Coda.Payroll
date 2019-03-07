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
    public class SppCalculationEngine : StatutoryCalculationEngine, IStatutoryPaternityPayCalculationEngine
    {
        public SppCalculationEngine(TaxYearConfigurationData taxYearConfigurationData, BankHolidayConfigurationData bankHolidayConfigurationData) : base(taxYearConfigurationData, bankHolidayConfigurationData) {}

        public StatutoryCalculationResult<PaternityPayAssessment> Calculate(PaternityPayAssessment model)
        {
            var assessmentCalculation = new StatutoryCalculationResult<PaternityPayAssessment>();

            if (!model.UpcomingPaymentDate.HasValue)
                assessmentCalculation.AddError(StatutoryValidationError.MissingRequiredValue, "The next Upcoming Payment Date must be provided");
            if (!model.StartDate.HasValue)
                assessmentCalculation.AddError(StatutoryValidationError.MissingRequiredValue, "The Start Date must be provided");
            if (!model.BirthDate.HasValue)
                assessmentCalculation.AddError(StatutoryValidationError.MissingRequiredValue, "The Birth Date must be provided");
            if (model.UpcomingPaymentDate.HasValue && model.StartDate.HasValue && model.UpcomingPaymentDate.Value < model.StartDate.Value)
                assessmentCalculation.AddError(StatutoryValidationError.InvalidUpcomingPayDate, "The upcoming process date cannot be before the Start Date");
            if (model.BirthDate.HasValue && model.StartDate.HasValue && model.StartDate.Value < model.BirthDate.Value)
                assessmentCalculation.AddError(StatutoryValidationError.InvalidStartDate, "Paternity pay cannot be started before the birth date");

            if (assessmentCalculation.Errors.Any())
                return assessmentCalculation;

            if (!model.EndDate.HasValue)
                model.EndDate = model.StartDate?.AddDays(model.TotalClaimDays);

            var scheduledPayments = new List<StatutoryPayment>();
            var datesInRange = model.GetQualifyingDatesInRange();
            var nextPaymentDate = (model.UpcomingPaymentDate.Value > datesInRange.First() ? model.UpcomingPaymentDate.Value : model.UpcomingPaymentDate.Value.AddDays(7));

            var statPayment = new StatutoryPayment
            {
                ReferenceDate = nextPaymentDate,
                PaymentDate = nextPaymentDate.AddDays(7),
                Cost = taxYearConfigurationData.StatutoryPaternityPayDayRate,
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
                        Cost = taxYearConfigurationData.StatutoryPaternityPayDayRate,
                        Qty = 0m
                    };
                }

                // We do want to pay this date
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
    }
}
