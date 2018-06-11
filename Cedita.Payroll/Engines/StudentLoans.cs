// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using System;

namespace Cedita.Payroll.Engines
{
    public enum StudentLoanPlan
    {
        Plan1,
        Plan2
    }

    public class StudentLoanCalculationResult
    {
        public decimal Threshold { get; set; }
        public decimal Rate { get; set; }
        public decimal PeriodAdjustedThreshold { get; set; }
        public decimal Gross { get; set; }
        public decimal ThresholdAdjustedGross { get; set; }

        public decimal StudentLoanDeduction { get; set; }
    }

    /*
    public class StudentLoans
    {
        public StudentLoanCalculationResult CalculateStudentLoanDeduction(StudentLoanPlan plan, decimal gross, PayPeriods periods)
        {
            decimal threshold = 0, rate = 0, periodAdjustedThreshold, thresholdAdjustedGross, deduction;
            int periodCnt = 52;
            int weeksInPeriod = 1;
            if (periods == PayPeriods.Monthly)
                periodCnt = 12;
            else
                weeksInPeriod = (int)Math.Round((decimal)periodCnt / (int)periods);

            switch (plan)
            {
                case StudentLoanPlan.Plan1:
                    threshold = TaxYearSpecificProvider.GetSpecificValue<decimal>(TaxYearSpecificValues.Plan1StudentLoanThreshold);
                    rate = TaxYearSpecificProvider.GetSpecificValue<decimal>(TaxYearSpecificValues.Plan1StudentLoanRate);
                    break;
                case StudentLoanPlan.Plan2:
                    threshold = TaxYearSpecificProvider.GetSpecificValue<decimal>(TaxYearSpecificValues.Plan2StudentLoanThreshold);
                    rate = TaxYearSpecificProvider.GetSpecificValue<decimal>(TaxYearSpecificValues.Plan2StudentLoanRate);
                    break;
            }

            periodAdjustedThreshold = TaxMath.Truncate(((threshold * weeksInPeriod) / periodCnt), 2);
            thresholdAdjustedGross = Math.Max(0, gross - periodAdjustedThreshold);
            deduction = Math.Floor(thresholdAdjustedGross * rate);

            return new StudentLoanCalculationResult
            {
                Gross = gross,
                Threshold = threshold,
                Rate = rate,
                PeriodAdjustedThreshold = periodAdjustedThreshold,
                ThresholdAdjustedGross = thresholdAdjustedGross,
                StudentLoanDeduction = deduction
            };
        }

        protected virtual int TaxYear { get; set; }
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
    }*/
}
