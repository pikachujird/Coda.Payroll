// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Coda.Payroll.Abstractions;
using Coda.Payroll.Configuration;
using System;

namespace Coda.Payroll.Calculation.StudentLoan
{
    public class StudentLoanCalculationEngine : IStudentLoanCalculationEngine
    {
        protected readonly TaxYearConfigurationData taxYearConfigurationData;

        public StudentLoanCalculationEngine(TaxYearConfigurationData taxYearConfigurationData)
        {
            this.taxYearConfigurationData = taxYearConfigurationData;
        }

        public StudentLoanCalculation CalculateStudentLoanDeduction(StudentLoanPlan plan, decimal gross, PayPeriods periods)
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
                    threshold = taxYearConfigurationData.Plan1StudentLoanThreshold;
                    rate = taxYearConfigurationData.Plan1StudentLoanRate;
                    break;
                case StudentLoanPlan.Plan2:
                    threshold = taxYearConfigurationData.Plan2StudentLoanThreshold;
                    rate = taxYearConfigurationData.Plan2StudentLoanRate;
                    break;
                case StudentLoanPlan.Plan4:
                    threshold = taxYearConfigurationData.Plan4StudentLoanThreshold;
                    rate = taxYearConfigurationData.Plan4StudentLoanRate;
                    break;
                case StudentLoanPlan.PostGrad:
                    threshold = taxYearConfigurationData.PostGradStudentLoanThreshold;
                    rate = taxYearConfigurationData.PostGradStudentLoanRate;
                    break;
            }

            periodAdjustedThreshold = TaxMath.Truncate(((threshold * weeksInPeriod) / periodCnt), 2);
            thresholdAdjustedGross = Math.Max(0, gross - periodAdjustedThreshold);
            deduction = Math.Floor(thresholdAdjustedGross * rate);

            return new StudentLoanCalculation
            {
                Gross = gross,
                Threshold = threshold,
                Rate = rate,
                PeriodAdjustedThreshold = periodAdjustedThreshold,
                ThresholdAdjustedGross = thresholdAdjustedGross,
                StudentLoanDeduction = deduction
            };
        }
    }
}
