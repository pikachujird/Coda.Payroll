using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cedita.Payroll.Models.Statutory;
using Cedita.Payroll.Models.Statutory.Assessments;

namespace Cedita.Payroll.Engines.StatutoryPayments
{
    public interface IStatutoryCalculationEngine : IResolvableEngine, IRequireTaxYearSpecifics { }

    public interface IStatutorySickPayCalculationEngine : IStatutoryCalculationEngine
    {
        IEnumerable<StatutoryPayment> Calculate(SickPayAssessment model);
    }

    public interface IStatutoryMaternityPayCalculationEngine : IStatutoryCalculationEngine
    {
        IEnumerable<StatutoryPayment> Calculate(MaternityPayAssessment model);
    }

    public interface IStatutoryPaternityPayCalculationEngine : IStatutoryCalculationEngine
    {
        IEnumerable<StatutoryPayment> Calculate(PaternityPayAssessment model);
    }
}
