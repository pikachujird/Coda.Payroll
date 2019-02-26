using Cedita.Payroll.Abstractions;
using Cedita.Payroll.Configuration.Providers;
using Cedita.Payroll.Models.Statutory;
using Cedita.Payroll.Models.Statutory.Assessments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedita.Payroll.Tests
{
    public abstract class StatutorySickPayTest
    {
        protected EmbeddedTaxConfigurationDataProvider DataProvider = new EmbeddedTaxConfigurationDataProvider();
        protected EmbeddedBankHolidayConfigurationProvider BankHolidayDataProvider = new EmbeddedBankHolidayConfigurationProvider();
        protected readonly IStatutoryCalculationEngineFactory statutoryFactory;

        public StatutorySickPayTest()
        {
            statutoryFactory = new DefaultStatutoryCalculationEngineFactory(DataProvider, BankHolidayDataProvider);
        }

        protected IEnumerable<StatutoryPayment> LegacyShim(int taxYear, SickPayAssessment assessment)
        {
            var sspEngine = statutoryFactory.CreateSspCalculationEngine(taxYear);
            return sspEngine.Calculate(assessment);
        }
    }
}
