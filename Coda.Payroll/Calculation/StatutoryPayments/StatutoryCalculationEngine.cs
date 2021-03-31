using Coda.Payroll.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coda.Payroll.Calculation.StatutoryPayments
{
    public abstract class StatutoryCalculationEngine
    {
        protected readonly TaxYearConfigurationData taxYearConfigurationData;
        protected readonly BankHolidayConfigurationData bankHolidayConfigurationData;
        protected readonly IEnumerable<DateTime> BankHolidayDates;

        public StatutoryCalculationEngine(TaxYearConfigurationData taxYearConfigurationData, BankHolidayConfigurationData bankHolidayConfigurationData)
        {
            this.taxYearConfigurationData = taxYearConfigurationData;
            this.bankHolidayConfigurationData = bankHolidayConfigurationData;

            BankHolidayDates = bankHolidayConfigurationData.BankHolidays;
        }
    }
}
