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

        /// <summary>
        /// The HMRC Spec states that this should be truncated to 5 decimal places, then always rounded up to the nearest penny. Unless
        /// of course it's the statutory rate that is a flat £145.18 a week / £20.74 a day
        /// </summary>
        public decimal Total => (IsStatutoryMinimumRate ? (Qty * Cost) : TaxMath.UpRound(TaxMath.Truncate(Qty * Cost, 5), 2));
    }
}
