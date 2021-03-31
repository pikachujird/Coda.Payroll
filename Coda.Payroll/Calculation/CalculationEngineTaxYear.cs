// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using System;

namespace Coda.Payroll.Calculation
{
    /// <summary>
    /// Defines the tax year that a calculation engine applies to
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class CalculationEngineTaxYearAttribute : Attribute
    {
        /// <summary>
        /// Year that the tax year started. For example 2016-17 tax year would be 2016
        /// </summary>
        public int TaxYear { get; set; }
    }
}
