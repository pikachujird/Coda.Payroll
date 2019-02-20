// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.

namespace Cedita.Payroll.Models.TaxYearSpecifics
{
    public enum TaxYearSpecificValues
    {
        // NI Specific (0-9)
        LowerEarningsLimit = 0,
        UpperEarningsLimit = 1,
        PrimaryThreshold = 2,
        SecondaryThreshold = 3,
        UpperAccrualPoint = 4,
        UpperSecondaryThreshold = 5,
        ApprenticeUpperSecondaryThreshold = 6,

        // SLR Specific (10-19)
        Plan1StudentLoanThreshold = 10,
        Plan1StudentLoanRate = 11,
        Plan2StudentLoanThreshold = 12,
        Plan2StudentLoanRate = 13,
        
        // Pension Specific (20-29)
        PensionLowerThreshold = 20,
        PensionAutomaticEnrolment = 21,
        PensionUpperThreshold = 22,

        // Tax Specific (30-39)
        DefaultTaxCode = 30,
        DeaProtectedEarnings = 31,

        // Statutories (32-34)
        StatutorySickPayDayRate = 32,
        StatutoryMaternityPayDayRate = 33,
        StatutoryMaternityPay6WeekRatePercentage = 34

    }
}
