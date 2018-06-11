// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Abstractions;
using Cedita.Payroll.Calculation;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Cedita.Payroll
{
    public class DefaultNiCalculationEngineFactory : INiCalculationEngineFactory
    {
        protected readonly ITaxConfigurationDataProvider taxConfigurationDataProvider;
        protected readonly Dictionary<int, Type> discoveredNiCalculationEngines;
        protected ConcurrentDictionary<int, INiCalculationEngine> niCalculationEngines =
            new ConcurrentDictionary<int, INiCalculationEngine>();

        public DefaultNiCalculationEngineFactory(ITaxConfigurationDataProvider taxConfigurationDataProvider)
        {
            this.taxConfigurationDataProvider = taxConfigurationDataProvider;

            var interfaceTypes = typeof(DefaultNiCalculationEngineFactory).Assembly.ExportedTypes
                    .Where(t => typeof(INiCalculationEngine).IsAssignableFrom(t));
            // One engine can span multiple years
            var allTypes = interfaceTypes.SelectMany(t =>
                t.GetCustomAttributes(typeof(CalculationEngineTaxYearAttribute), false).Select(
                    a => new
                    {
                        ((CalculationEngineTaxYearAttribute)a).TaxYear,
                        Type = t
                    }));
            discoveredNiCalculationEngines = allTypes.ToDictionary(m => m.TaxYear, m => m.Type);
        }
        
        public INiCalculationEngine CreateNiCalculationEngine(int taxYear)
        {
            return niCalculationEngines.GetOrAdd(taxYear, CreateNiCalculationEngineInternal(taxYear));
        }

        protected INiCalculationEngine CreateNiCalculationEngineInternal(int taxYear)
        {
            var niEngine = Activator.CreateInstance(
                discoveredNiCalculationEngines[taxYear],
                taxConfigurationDataProvider.GetTaxYearConfigurationData(taxYear));

            return (INiCalculationEngine)niEngine;
        }
    }
}
