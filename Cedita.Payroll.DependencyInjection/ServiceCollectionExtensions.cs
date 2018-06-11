using Cedita.Payroll.Abstractions;
using Cedita.Payroll.Engines.Paye;
using Microsoft.Extensions.DependencyInjection;
using System;

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
            AddCeditaPayroll<JsonTax>
        }

        public static void AddCeditaPayroll<TTaxConfigurationDataProvider>(this IServiceCollection services)
            where TTaxConfigurationDataProvider : ITaxConfigurationDataProvider
        {
            services.AddTransient<IPayeCalculationEngine, PayeVersion13>();
        }
    }
}
