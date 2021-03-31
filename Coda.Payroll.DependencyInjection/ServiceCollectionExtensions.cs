// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.

using System;
using Coda.Payroll.Abstractions;
using Coda.Payroll.Configuration.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace Coda.Payroll.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Add Coda.Payroll Libraries using the built-in JSON Tax Data Provider
        /// </summary>
        /// <param name="services"></param>
        [Obsolete("Use AddCodaPayroll instead. This method will be removed in a future version.")]
        public static void AddCeditaPayroll(this IServiceCollection services)
        {
            AddCodaPayroll<EmbeddedTaxConfigurationDataProvider, EmbeddedBankHolidayConfigurationProvider>(services);
        }
        
        /// <summary>
        /// Add Coda.Payroll Libraries using the built-in JSON Tax Data Provider
        /// </summary>
        /// <param name="services"></param>
        public static void AddCodaPayroll(this IServiceCollection services)
        {
            AddCodaPayroll<EmbeddedTaxConfigurationDataProvider, EmbeddedBankHolidayConfigurationProvider>(services);
        }

        public static void AddCodaPayroll<TTaxConfigurationDataProvider, TBankHolidayConfigurationDataProvider>(this IServiceCollection services)
            where TTaxConfigurationDataProvider : class, ITaxConfigurationDataProvider
            where TBankHolidayConfigurationDataProvider : class, IBankHolidayConfigurationDataProvider
        {
            services.AddSingleton<ITaxConfigurationDataProvider, TTaxConfigurationDataProvider>();
            services.AddSingleton<IBankHolidayConfigurationDataProvider, TBankHolidayConfigurationDataProvider>();

            services.AddSingleton<IPayeCalculationEngineFactory, DefaultPayeCalculationEngineFactory>();
            services.AddSingleton<INiCalculationEngineFactory, DefaultNiCalculationEngineFactory>();
            services.AddSingleton<IStudentLoanCalculationEngineFactory, DefaultStudentLoanCalculationEngineFactory>();

            services.AddSingleton<IPayrollCalculatorFactory, DefaultPayrollCalculatorFactory>();
            services.AddSingleton<IStatutoryCalculationEngineFactory, DefaultStatutoryCalculationEngineFactory>();
        }
    }
}
