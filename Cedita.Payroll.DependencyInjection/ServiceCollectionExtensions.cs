// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Abstractions;
using Cedita.Payroll.Configuration.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace Cedita.Payroll.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Add Cedita.Payroll Libraries using the built-in JSON Tax Data Provider
        /// </summary>
        /// <param name="services"></param>
        public static void AddCeditaPayroll(this IServiceCollection services)
        {
            AddCeditaPayroll<EmbeddedTaxConfigurationDataProvider>(services);
        }

        public static void AddCeditaPayroll<TTaxConfigurationDataProvider>(this IServiceCollection services)
            where TTaxConfigurationDataProvider : class, ITaxConfigurationDataProvider
        {
            services.AddSingleton<ITaxConfigurationDataProvider, TTaxConfigurationDataProvider>();

            services.AddSingleton<IPayeCalculationEngineFactory, DefaultPayeCalculationEngineFactory>();
            services.AddSingleton<INiCalculationEngineFactory, DefaultNiCalculationEngineFactory>();

            services.AddSingleton<IPayrollCalculatorFactory, DefaultPayrollCalculatorFactory>();
        }
    }
}
