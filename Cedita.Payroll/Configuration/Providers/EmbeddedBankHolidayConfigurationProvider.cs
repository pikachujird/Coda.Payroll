using Cedita.Payroll.Abstractions;
using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cedita.Payroll.Configuration.Providers
{
    public class EmbeddedBankHolidayConfigurationProvider : IBankHolidayConfigurationDataProvider
    {
        /// <summary>
        /// Returns a collection of bank holiday dates
        /// </summary>
        /// <param name="since"></param>
        /// <returns></returns>
        public IEnumerable<DateTime> GetBankHolidays(DateTime? since = null)
        {
            var bankHolidayData = LoadBankHolidayConfigurationData();
            if (since.HasValue)
                return bankHolidayData.BankHolidays.Where(m => m.Date >= since.Value.Date);

            return bankHolidayData.BankHolidays;
        }

        public BankHolidayConfigurationData GetBankHolidayConfigurationData() => LoadBankHolidayConfigurationData();

        private const string BankHolidayConfigName = "BankHolidayConfig";
        private BankHolidayConfigurationData LoadedBankHolidayConfigurationData;

        private BankHolidayConfigurationData LoadBankHolidayConfigurationData()
        {
            if (LoadedBankHolidayConfigurationData == null)
            {
                var asm = typeof(EmbeddedTaxConfigurationDataProvider).Assembly;
                using (var configStream = asm.GetManifestResourceStream(BankHolidayConfigName))
                using (var textReader = new StreamReader(configStream))
                {
                    var jsonConfig = textReader.ReadToEnd();
                    LoadedBankHolidayConfigurationData = JsonConvert.DeserializeObject<BankHolidayConfigurationData>(jsonConfig);
                }
            }

            return LoadedBankHolidayConfigurationData;

        }
    }
}
