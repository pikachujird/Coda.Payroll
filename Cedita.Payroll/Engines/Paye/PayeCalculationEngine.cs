// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cedita.Payroll.Engines.Paye
{
    /// <summary>
    /// Starting point for Paye Calculation Engines requiring definition of most of the common internal structures required for tax calculation.
    /// </summary>
    public abstract class PayeCalculationEngine : IPayeCalculationEngine
    {
        protected virtual int TaxYear { get; set; }
        protected virtual PayeCalculationContainer CalculationContainer { get; set; }
        protected virtual Dictionary<Tuple<int, int, int, bool>, PayeInternalBracket[]> BracketCache { get; set; }
            = new Dictionary<Tuple<int, int, int, bool>, PayeInternalBracket[]>();
        protected virtual IProvideTaxYearSpecifics TaxYearSpecificProvider { get; set; }

        public void SetTaxYearSpecificsProvider(IProvideTaxYearSpecifics provider)
        {
            TaxYearSpecificProvider = provider;
        }

        public void SetTaxYear(int taxYear)
        {
            TaxYear = taxYear;
            TaxYearSpecificProvider.SetTaxYear(taxYear);
        }
        
        public virtual decimal CalculateTaxDueForPeriod(string taxCode, decimal gross, PayPeriods periods, int period, bool week1 = false, decimal grossToDate = 0, decimal taxToDate = 0)
        {
            return CalculateTaxDueForPeriod(TaxCode.Parse(taxCode), gross, periods, period, week1, grossToDate, taxToDate);
        }
        public abstract decimal CalculateTaxDueForPeriod(TaxCode taxCode, decimal gross, PayPeriods periods, int period, bool week1 = false, decimal grossToDate = 0, decimal taxToDate = 0);

        protected abstract PayeInternalBracket[] GetBracketsForPeriod();

        protected abstract decimal GetPayAdjustment(TaxCode taxCode, PayPeriods periods);

        protected abstract PayeCalculationContainer CreateDefaultContainer();

        protected abstract void CreateContainer(TaxCode taxCode, decimal grossForPeriod, PayPeriods periods, int period = 1, bool week1 = false, decimal grossToDateExcludingPeriod = 0, decimal taxToDateExcludingPeriod = 0);

        protected abstract void CalculateTax();
    }
}
