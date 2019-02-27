// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.

using Cedita.Payroll.Calculation.StudentLoan;

namespace Cedita.Payroll.Abstractions
{
    public interface IStudentLoanCalculationEngine
    {
        StudentLoanCalculation CalculateStudentLoanDeduction(StudentLoanPlan plan, decimal gross, PayPeriods periods);
    }
}
