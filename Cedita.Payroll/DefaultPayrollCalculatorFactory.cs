// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Abstractions;
using System;
using System.Collections.Concurrent;

namespace Cedita.Payroll
{
    public class DefaultPayrollCalculatorFactory : IPayrollCalculatorFactory
    {
        protected readonly INiCalculationEngineFactory niCalculationEngineFactory;
        protected readonly IPayeCalculationEngineFactory payeCalculationEngineFactory;

        public DefaultPayrollCalculatorFactory(
            INiCalculationEngineFactory niCalculationEngineFactory,
            IPayeCalculationEngineFactory payeCalculationEngineFactory)
        {
            this.niCalculationEngineFactory = niCalculationEngineFactory;
            this.payeCalculationEngineFactory = payeCalculationEngineFactory;
        }

        public IPayrollCalculator CreatePayrollCalculator()
        {
            // Get the current tax year
            var taxDate = DateTime.Now.GetTaxPeriod();
            var taxYear = taxDate.Year;

            return CreatePayrollCalculator(taxYear);
        }

        public IPayrollCalculator CreatePayrollCalculator(int taxYear)
        {
            return payrollCalculators.GetOrAdd(taxYear, CreatePayrollCalculatorInternal(taxYear));
        }
        
        protected ConcurrentDictionary<int, IPayrollCalculator> payrollCalculators =
            new ConcurrentDictionary<int, IPayrollCalculator>();

        protected IPayrollCalculator CreatePayrollCalculatorInternal(int taxYear)
        {
            var niEngine = niCalculationEngineFactory.CreateNiCalculationEngine(taxYear);
            var payeEngine = payeCalculationEngineFactory.CreatePayeCalculationEngine(taxYear);

            return new PayrollCalculator(niEngine, payeEngine);
        }
    }
}
