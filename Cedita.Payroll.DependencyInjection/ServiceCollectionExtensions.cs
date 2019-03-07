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
            AddCeditaPayroll<EmbeddedTaxConfigurationDataProvider, EmbeddedBankHolidayConfigurationProvider>(services);
        }

        public static void AddCeditaPayroll<TTaxConfigurationDataProvider, TBankHolidayConfigurationDataProvider>(this IServiceCollection services)
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
