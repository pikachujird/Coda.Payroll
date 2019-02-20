using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedita.Payroll.Engines.StatutoryPayments
{
    public class StatutoryCalculationEngine : IStatutoryCalculationEngine
    {
        protected virtual int TaxYear { get; set; }
        protected virtual IProvideTaxYearSpecifics TaxYearSpecificProvider { get; set; }

        public void SetTaxYearSpecificsProvider(IProvideTaxYearSpecifics provider)
        {
            TaxYearSpecificProvider = provider;
        }

        public void SetTaxYear(int taxYear)
        {
            TaxYear = taxYear;
            TaxYearSpecificProvider.SetTaxYear(taxYear);
        }
    }
}
