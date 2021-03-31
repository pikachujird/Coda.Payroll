// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Coda.Payroll.Abstractions;
using Coda.Payroll.Calculation;
using Coda.Payroll.Calculation.StatutoryPayments;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Coda.Payroll
{
    public class DefaultStatutoryCalculationEngineFactory : IStatutoryCalculationEngineFactory
    {
        protected readonly ITaxConfigurationDataProvider taxConfigurationDataProvider;
        protected readonly IBankHolidayConfigurationDataProvider bankHolidayConfigurationDataProvider;

        protected readonly Dictionary<int, Type> discoveredSspCalculationEngines;
        protected readonly Dictionary<int, Type> discoveredSmpCalculationEngines;
        protected readonly Dictionary<int, Type> discoveredSppCalculationEngines;

        protected ConcurrentDictionary<int, IStatutorySickPayCalculationEngine> sspCalculationEngines = new ConcurrentDictionary<int, IStatutorySickPayCalculationEngine>();
        protected ConcurrentDictionary<int, IStatutoryMaternityPayCalculationEngine> smpCalculationEngines = new ConcurrentDictionary<int, IStatutoryMaternityPayCalculationEngine>();
        protected ConcurrentDictionary<int, IStatutoryPaternityPayCalculationEngine> sppCalculationEngines = new ConcurrentDictionary<int, IStatutoryPaternityPayCalculationEngine>();

        public DefaultStatutoryCalculationEngineFactory(ITaxConfigurationDataProvider taxConfigurationDataProvider, IBankHolidayConfigurationDataProvider bankHolidayConfigurationDataProvider)
        {
            this.taxConfigurationDataProvider = taxConfigurationDataProvider;
            this.bankHolidayConfigurationDataProvider = bankHolidayConfigurationDataProvider;

            var interfaceTypes = typeof(DefaultStatutoryCalculationEngineFactory).Assembly.ExportedTypes.Where(t => 
                typeof(IStatutorySickPayCalculationEngine).IsAssignableFrom(t) || 
                typeof(IStatutoryPaternityPayCalculationEngine).IsAssignableFrom(t) ||
                typeof(IStatutoryMaternityPayCalculationEngine).IsAssignableFrom(t)
            );

            // One engine can span multiple years
            var allTypes = interfaceTypes.SelectMany(t =>
                t.GetCustomAttributes(typeof(CalculationEngineTaxYearAttribute), false).Select(
                    a => new
                    {
                        ((CalculationEngineTaxYearAttribute)a).TaxYear,
                        Type = t
                    }));

            discoveredSspCalculationEngines = allTypes.Where(t => typeof(IStatutorySickPayCalculationEngine).IsAssignableFrom(t.Type)).ToDictionary(m => m.TaxYear, m => m.Type);
            discoveredSmpCalculationEngines = allTypes.Where(t => typeof(IStatutoryMaternityPayCalculationEngine).IsAssignableFrom(t.Type)).ToDictionary(m => m.TaxYear, m => m.Type);
            discoveredSppCalculationEngines = allTypes.Where(t => typeof(IStatutoryPaternityPayCalculationEngine).IsAssignableFrom(t.Type)).ToDictionary(m => m.TaxYear, m => m.Type);
        }

        public IStatutorySickPayCalculationEngine CreateSspCalculationEngine(int taxYear) => sspCalculationEngines.GetOrAdd(taxYear, CreateSspCalculationEngineInternal(taxYear));
        public IStatutoryMaternityPayCalculationEngine CreateSmpCalculationEngine(int taxYear) => smpCalculationEngines.GetOrAdd(taxYear, CreateSmpCalculationEngineInternal(taxYear));        
        public IStatutoryPaternityPayCalculationEngine CreateSppCalculationEngine(int taxYear) => sppCalculationEngines.GetOrAdd(taxYear, CreateSppCalculationEngineInternal(taxYear));

        protected IStatutorySickPayCalculationEngine CreateSspCalculationEngineInternal(int taxYear) => 
            (IStatutorySickPayCalculationEngine)Activator.CreateInstance(
                discoveredSspCalculationEngines[taxYear], 
                taxConfigurationDataProvider.GetTaxYearConfigurationData(taxYear), 
                bankHolidayConfigurationDataProvider.GetBankHolidayConfigurationData());

        protected IStatutoryMaternityPayCalculationEngine CreateSmpCalculationEngineInternal(int taxYear) => 
            (IStatutoryMaternityPayCalculationEngine)Activator.CreateInstance(
                discoveredSmpCalculationEngines[taxYear], 
                taxConfigurationDataProvider.GetTaxYearConfigurationData(taxYear), 
                bankHolidayConfigurationDataProvider.GetBankHolidayConfigurationData());

        protected IStatutoryPaternityPayCalculationEngine CreateSppCalculationEngineInternal(int taxYear) => 
            (IStatutoryPaternityPayCalculationEngine)Activator.CreateInstance(
                discoveredSppCalculationEngines[taxYear], 
                taxConfigurationDataProvider.GetTaxYearConfigurationData(taxYear), 
                bankHolidayConfigurationDataProvider.GetBankHolidayConfigurationData());
    }
}
