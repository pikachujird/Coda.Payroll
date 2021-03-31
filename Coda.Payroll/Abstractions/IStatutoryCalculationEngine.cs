using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Coda.Payroll.Models.Statutory;
using Coda.Payroll.Models.Statutory.Assessments;

namespace Coda.Payroll.Abstractions
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
