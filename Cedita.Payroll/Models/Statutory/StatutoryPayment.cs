using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedita.Payroll.Models.Statutory
{
    public class StatutoryPayment
    {
        public DateTime ReferenceDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Qty { get; set; }
        public decimal Cost { get; set; }
        public bool IsStatutoryMinimumRate { get; set; } = true;
        public decimal Total
        {
            get
            {
                return Math.Round(Qty * Cost, 2, MidpointRounding.AwayFromZero);
            }
        }
    }
}
