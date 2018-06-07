using Cedita.Payroll.Engines;
using Cedita.Payroll.Engines.Paye;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Cedita.Payroll.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCeditaPayroll<TTaxDataProvider>(this IServiceCollection services)
            where TTaxDataProvider : ITaxConfigurationDataProvider
        {
            services.AddTransient<IPayeCalculationEngine, PayeVersion13>();
        }
    }
}
