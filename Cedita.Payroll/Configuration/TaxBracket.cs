// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.

namespace Cedita.Payroll.Configuration
{
    public class TaxBracket
    {
        public decimal From { get; set; }
        public decimal To { get; set; }
        public decimal Multiplier { get; set; }
    }
}
