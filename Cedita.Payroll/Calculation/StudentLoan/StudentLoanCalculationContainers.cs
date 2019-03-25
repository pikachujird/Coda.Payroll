// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Models;

namespace Cedita.Payroll.Calculation.StudentLoan
{
    public enum StudentLoanPlan
    {
        Plan1,
        Plan2,
        PostGrad
    }

    public class StudentLoanCalculation
    {
        public decimal Threshold { get; set; }
        public decimal Rate { get; set; }
        public decimal PeriodAdjustedThreshold { get; set; }
        public decimal Gross { get; set; }
        public decimal ThresholdAdjustedGross { get; set; }

        public decimal StudentLoanDeduction { get; set; }
    }
}
