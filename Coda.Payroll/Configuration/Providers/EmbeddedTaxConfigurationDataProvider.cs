// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Coda.Payroll.Abstractions;
using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Coda.Payroll.Configuration.Providers
{
    public class EmbeddedTaxConfigurationDataProvider : ITaxConfigurationDataProvider
    {
        public TaxYearConfigurationData GetTaxYearConfigurationData(int taxYear)
        {
            var taxData = LoadConfigurationData();
            return taxData.ConfigurationData[taxYear];
        }
        
        private const string PayrollConfigName = "PayrollConfig";
        private TaxConfigurationData LoadedTaxConfigurationData;

        private TaxConfigurationData LoadConfigurationData()
        {
            if (LoadedTaxConfigurationData == null)
            {
                var asm = typeof(EmbeddedTaxConfigurationDataProvider).Assembly;
                using (var configStream = asm.GetManifestResourceStream(PayrollConfigName))
                using (var textReader = new StreamReader(configStream))
                {
                    var jsonConfig = textReader.ReadToEnd();
                    LoadedTaxConfigurationData = JsonConvert.DeserializeObject<TaxConfigurationData>(jsonConfig);
                }
            }

            return LoadedTaxConfigurationData;
        }
    }
}
