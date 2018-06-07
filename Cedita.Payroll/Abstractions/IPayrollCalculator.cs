using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedita.Payroll.Abstractions
{
    public interface IPayrollCalculator
    {
        public PayrollCalculation Calculate();
    }
}
