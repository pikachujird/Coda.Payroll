// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Models;

namespace Cedita.Payroll
{
    /// <summary>
    /// Represents a Payroll Calculation
    /// </summary>
    public class PayrollCalculationRequest
    {
        /* Calculation Requisites */
        public PayPeriods PaymentFrequency { get; set; }
        public int PaymentPeriod { get; set; }

        /* PAYE Requisites */
        public TaxCode TaxCode { get; set; }
        public bool IsWeek1Month1 { get; set; }
        public decimal TaxableGross { get; set; }
        public decimal TaxableGrossToDate { get; set; }
        public decimal TaxToDate { get; set; }

        /* NI Requisites */
        public char NiCode { get; set; }
        public decimal NiableGross { get; set; }
    }
}
