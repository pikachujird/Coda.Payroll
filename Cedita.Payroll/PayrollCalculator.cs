// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Abstractions;

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
            var niResult = niCalculationEngine.CalculateNationalInsurance(
                payrollData.NiableGross,
                payrollData.NiCode,
                payrollData.PaymentFrequency);

            var payeResult = payeCalculationEngine.CalculateTaxDueForPeriod(
                payrollData.TaxCode,
                payrollData.TaxableGross,
                payrollData.PaymentFrequency,
                payrollData.PaymentPeriod,
                payrollData.IsWeek1Month1,
                payrollData.TaxableGrossToDate,
                payrollData.TaxToDate);
            var payeCalcResult = payeCalculationEngine.GetContainer();

            return new PayrollCalculationResult
            {
                Request = payrollData,
                Paye = payeCalcResult,
                NationalInsurance = niResult
            };
        }
    }
}
