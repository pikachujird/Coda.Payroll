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
        StatutoryCalculationResult<SickPayAssessment> Calculate(SickPayAssessment model, IEnumerable<SickPayAssessment> previousSicknotes = null);
    }

    public interface IStatutoryMaternityPayCalculationEngine
    {
        StatutoryCalculationResult<MaternityPayAssessment> Calculate(MaternityPayAssessment model);
    }

    public interface IStatutoryPaternityPayCalculationEngine
    {
        StatutoryCalculationResult<PaternityPayAssessment> Calculate(PaternityPayAssessment model);
    }
}
