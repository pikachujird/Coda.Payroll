// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Abstractions;
using System;

namespace Cedita.Payroll
{
    public class PayrollCalculator : IPayrollCalculator
    {
        protected readonly INiCalculationEngine niCalculationEngine;
        protected readonly IPayeCalculationEngine payeCalculationEngine;

        public PayrollCalculator(
            INiCalculationEngine niCalculationEngine,
            IPayeCalculationEngine payeCalculationEngine)
        {
            this.niCalculationEngine = niCalculationEngine;
            this.payeCalculationEngine = payeCalculationEngine;
        }

        public PayrollCalculationResult Calculate(PayrollCalculationRequest payrollData)
        {
            throw new NotImplementedException();
        }
    }
}
