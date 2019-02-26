using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cedita.Payroll.Models.Statutory;
using Cedita.Payroll.Models.Statutory.Assessments;

namespace Cedita.Payroll.Abstractions
{
    public interface IStatutorySickPayCalculationEngine
    {
        IEnumerable<StatutoryPayment> Calculate(SickPayAssessment model);
    }

    public interface IStatutoryMaternityPayCalculationEngine
    {
        IEnumerable<StatutoryPayment> Calculate(MaternityPayAssessment model);
    }

    public interface IStatutoryPaternityPayCalculationEngine
    {
        IEnumerable<StatutoryPayment> Calculate(PaternityPayAssessment model);
    }
}
