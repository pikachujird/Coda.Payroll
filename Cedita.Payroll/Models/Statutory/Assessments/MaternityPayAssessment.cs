using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedita.Payroll.Models.Statutory.Assessments
{
    public class MaternityPayAssessment : BaseStatutoryAssessment
    {
        public DateTime DueDate { get; set; }
        public DateTime BirthDate { get; set; }        
    }    
}
