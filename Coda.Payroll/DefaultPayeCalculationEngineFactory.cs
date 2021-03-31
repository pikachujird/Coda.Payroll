// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Coda.Payroll.Abstractions;
using Coda.Payroll.Calculation;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Coda.Payroll
{
    public class DefaultPayeCalculationEngineFactory : IPayeCalculationEngineFactory
    {
        protected readonly ITaxConfigurationDataProvider taxConfigurationDataProvider;
        protected readonly Dictionary<int, Type> discoveredPayeCalculationEngines;
        protected ConcurrentDictionary<int, IPayeCalculationEngine> payeCalculationEngines =
            new ConcurrentDictionary<int, IPayeCalculationEngine>();
        
        public DefaultPayeCalculationEngineFactory(ITaxConfigurationDataProvider taxConfigurationDataProvider)
        {
            this.taxConfigurationDataProvider = taxConfigurationDataProvider;

            var interfaceTypes = typeof(DefaultNiCalculationEngineFactory).Assembly.ExportedTypes
                    .Where(t => typeof(IPayeCalculationEngine).IsAssignableFrom(t));
            // One engine can span multiple years
            var allTypes = interfaceTypes.SelectMany(t =>
                t.GetCustomAttributes(typeof(CalculationEngineTaxYearAttribute), false).Select(
                    a => new
                    {
                        ((CalculationEngineTaxYearAttribute)a).TaxYear,
                        Type = t
                    }));
            discoveredPayeCalculationEngines = allTypes.ToDictionary(m => m.TaxYear, m => m.Type);
        }

        public IPayeCalculationEngine CreatePayeCalculationEngine(int taxYear)
        {
            return payeCalculationEngines.GetOrAdd(taxYear, CreatePayeCalculationEngineInternal(taxYear));
        }

        protected IPayeCalculationEngine CreatePayeCalculationEngineInternal(int taxYear)
        {
            var payeEngine = Activator.CreateInstance(
                discoveredPayeCalculationEngines[taxYear],
                taxConfigurationDataProvider.GetTaxYearConfigurationData(taxYear));

            return (IPayeCalculationEngine)payeEngine;
        }
    }
}
