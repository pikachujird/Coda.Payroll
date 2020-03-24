// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cedita.Payroll.Tests
{
    public partial class NiTests
    {
        [TestCategory("NI Tests"), TestMethod]
        public void NationalInsurance2020()
        {
            // A
            var niCode = 'A';
            
            Assert.AreEqual(0.00m, TestShim(169.04m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(0.01m, TestShim(169.05m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(0.01m, TestShim(169.11m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(0.02m, TestShim(169.12m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(1.94m, TestShim(183.03m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(1.94m, TestShim(183.04m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(1.95m, TestShim(183.05m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(1.96m, TestShim(183.11m, niCode, PayPeriods.Weekly, 2020));
            
            Assert.AreEqual(202.91m, TestShim(962.04m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(202.92m, TestShim(962.05m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(202.93m, TestShim(962.12m, niCode, PayPeriods.Weekly, 2020));

            Assert.AreEqual(000.00m, TestShim(0338.04m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.01m, TestShim(0338.05m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.01m, TestShim(0338.11m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.02m, TestShim(0338.12m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(003.87m, TestShim(0366.03m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(003.87m, TestShim(0366.04m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(003.88m, TestShim(0366.05m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(003.89m, TestShim(0366.09m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(405.83m, TestShim(1924.04m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(405.84m, TestShim(1924.05m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(405.85m, TestShim(1924.12m, niCode, PayPeriods.Fortnightly, 2020));

            Assert.AreEqual(000.00m, TestShim(0676.04m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.01m, TestShim(0676.05m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.01m, TestShim(0676.11m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.02m, TestShim(0676.12m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(007.59m, TestShim(0731.04m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(007.61m, TestShim(0731.05m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(007.61m, TestShim(0731.11m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(007.62m, TestShim(0731.12m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(811.52m, TestShim(3847.04m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(811.53m, TestShim(3847.05m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(811.54m, TestShim(3847.12m, niCode, PayPeriods.FourWeekly, 2020));

            Assert.AreEqual(000.00m, TestShim(0732.04m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.01m, TestShim(0732.05m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.01m, TestShim(0732.11m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.02m, TestShim(0732.12m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(008.28m, TestShim(0792.04m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(008.30m, TestShim(0792.05m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(008.30m, TestShim(0792.11m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(008.31m, TestShim(0792.12m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(879.03m, TestShim(4167.04m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(879.04m, TestShim(4167.05m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(879.05m, TestShim(4167.12m, niCode, PayPeriods.Monthly, 2020));

            // B
            niCode = 'B';
            Assert.AreEqual(000.00m, TestShim(169.04m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(000.01m, TestShim(169.05m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(000.01m, TestShim(169.11m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(000.02m, TestShim(169.12m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(001.94m, TestShim(183.03m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(001.94m, TestShim(183.04m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(001.94m, TestShim(183.05m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(001.96m, TestShim(183.11m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(155.00m, TestShim(962.04m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(155.01m, TestShim(962.05m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(155.02m, TestShim(962.12m, niCode, PayPeriods.Weekly, 2020));

            Assert.AreEqual(000.00m, TestShim(0338.04m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.01m, TestShim(0338.05m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.01m, TestShim(0338.11m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.02m, TestShim(0338.12m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(003.87m, TestShim(0366.03m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(003.87m, TestShim(0366.04m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(003.87m, TestShim(0366.05m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(003.88m, TestShim(0366.09m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(310.01m, TestShim(1924.04m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(310.02m, TestShim(1924.05m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(310.03m, TestShim(1924.12m, niCode, PayPeriods.Fortnightly, 2020));

            Assert.AreEqual(000.00m, TestShim(0676.04m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.01m, TestShim(0676.05m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.01m, TestShim(0676.11m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.02m, TestShim(0676.12m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(007.59m, TestShim(0731.04m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(007.60m, TestShim(0731.05m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(007.61m, TestShim(0731.11m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(007.62m, TestShim(0731.12m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(619.89m, TestShim(3847.04m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(619.90m, TestShim(3847.05m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(619.91m, TestShim(3847.12m, niCode, PayPeriods.FourWeekly, 2020));

            Assert.AreEqual(000.00m, TestShim(0732.04m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.01m, TestShim(0732.05m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.01m, TestShim(0732.11m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.02m, TestShim(0732.12m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(008.28m, TestShim(0792.04m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(008.29m, TestShim(0792.05m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(008.30m, TestShim(0792.11m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(008.31m, TestShim(0792.12m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(671.47m, TestShim(4167.04m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(671.48m, TestShim(4167.05m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(671.49m, TestShim(4167.12m, niCode, PayPeriods.Monthly, 2020));

            // C
            niCode = 'C';
            Assert.AreEqual(000.00m, TestShim(169.04m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(000.01m, TestShim(169.05m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(000.01m, TestShim(169.11m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(000.02m, TestShim(169.12m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(001.94m, TestShim(183.03m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(001.94m, TestShim(183.04m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(001.94m, TestShim(183.05m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(001.95m, TestShim(183.11m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(109.43m, TestShim(962.04m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(109.44m, TestShim(962.05m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(109.45m, TestShim(962.12m, niCode, PayPeriods.Weekly, 2020));

            Assert.AreEqual(000.00m, TestShim(0338.04m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.01m, TestShim(0338.05m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.01m, TestShim(0338.11m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.02m, TestShim(0338.12m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(003.87m, TestShim(0366.03m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(003.87m, TestShim(0366.04m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(003.87m, TestShim(0366.05m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(003.88m, TestShim(0366.09m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(218.87m, TestShim(1924.04m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(218.88m, TestShim(1924.05m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(218.89m, TestShim(1924.12m, niCode, PayPeriods.Fortnightly, 2020));

            Assert.AreEqual(000.00m, TestShim(0676.04m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.01m, TestShim(0676.05m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.01m, TestShim(0676.11m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.02m, TestShim(0676.12m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(007.59m, TestShim(0731.04m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(007.60m, TestShim(0731.05m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(007.60m, TestShim(0731.11m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(007.61m, TestShim(0731.12m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(437.60m, TestShim(3847.04m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(437.61m, TestShim(3847.05m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(437.62m, TestShim(3847.12m, niCode, PayPeriods.FourWeekly, 2020));

            Assert.AreEqual(000.00m, TestShim(0732.04m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.01m, TestShim(0732.05m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.01m, TestShim(0732.11m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.02m, TestShim(0732.12m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(008.28m, TestShim(0792.04m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(008.29m, TestShim(0792.05m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(008.29m, TestShim(0792.11m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(008.30m, TestShim(0792.12m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(474.03m, TestShim(4167.04m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(474.04m, TestShim(4167.05m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(474.05m, TestShim(4167.12m, niCode, PayPeriods.Monthly, 2020));

            // H
            niCode = 'H';
            Assert.AreEqual(00.00m, TestShim(169.04m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(00.00m, TestShim(169.05m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(00.00m, TestShim(169.11m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(00.00m, TestShim(169.12m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(00.00m, TestShim(183.03m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(00.00m, TestShim(183.04m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(00.01m, TestShim(183.05m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(00.01m, TestShim(183.11m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(93.48m, TestShim(962.04m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(93.49m, TestShim(962.05m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(93.50m, TestShim(962.12m, niCode, PayPeriods.Weekly, 2020));

            Assert.AreEqual(000.00m, TestShim(0338.04m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.00m, TestShim(0338.05m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.00m, TestShim(0338.11m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.00m, TestShim(0338.12m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.00m, TestShim(0366.03m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.00m, TestShim(0366.04m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.01m, TestShim(0366.05m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.01m, TestShim(0366.09m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(186.96m, TestShim(1924.04m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(186.97m, TestShim(1924.05m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(186.98m, TestShim(1924.12m, niCode, PayPeriods.Fortnightly, 2020));

            Assert.AreEqual(000.00m, TestShim(0676.04m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.00m, TestShim(0676.05m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.00m, TestShim(0676.11m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.00m, TestShim(0676.12m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.00m, TestShim(0731.04m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.01m, TestShim(0731.05m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.01m, TestShim(0731.11m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.01m, TestShim(0731.12m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(373.92m, TestShim(3847.04m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(373.93m, TestShim(3847.05m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(373.94m, TestShim(3847.12m, niCode, PayPeriods.FourWeekly, 2020));

            Assert.AreEqual(000.00m, TestShim(0732.04m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.00m, TestShim(0732.05m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.00m, TestShim(0732.11m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.00m, TestShim(0732.12m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.00m, TestShim(0792.04m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.01m, TestShim(0792.05m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.01m, TestShim(0792.11m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.01m, TestShim(0792.12m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(405.00m, TestShim(4167.04m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(405.01m, TestShim(4167.05m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(405.02m, TestShim(4167.12m, niCode, PayPeriods.Monthly, 2020));

            // J
            niCode = 'J';
            Assert.AreEqual(000.00m, TestShim(169.04m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(000.01m, TestShim(169.05m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(000.01m, TestShim(169.11m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(000.02m, TestShim(169.12m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(001.94m, TestShim(183.03m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(001.94m, TestShim(183.04m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(001.94m, TestShim(183.05m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(001.95m, TestShim(183.11m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(125.01m, TestShim(962.04m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(125.02m, TestShim(962.05m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(125.03m, TestShim(962.12m, niCode, PayPeriods.Weekly, 2020));

            Assert.AreEqual(000.00m, TestShim(0338.04m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.01m, TestShim(0338.05m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.01m, TestShim(0338.11m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.02m, TestShim(0338.12m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(003.87m, TestShim(0366.03m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(003.87m, TestShim(0366.04m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(003.87m, TestShim(0366.05m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(003.88m, TestShim(0366.09m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(250.03m, TestShim(1924.04m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(250.04m, TestShim(1924.05m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(250.05m, TestShim(1924.12m, niCode, PayPeriods.Fortnightly, 2020));

            Assert.AreEqual(000.00m, TestShim(0676.04m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.01m, TestShim(0676.05m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.01m, TestShim(0676.11m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.02m, TestShim(0676.12m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(007.59m, TestShim(0731.04m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(007.60m, TestShim(0731.05m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(007.60m, TestShim(0731.11m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(007.61m, TestShim(0731.12m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(499.92m, TestShim(3847.04m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(499.93m, TestShim(3847.05m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(499.94m, TestShim(3847.12m, niCode, PayPeriods.FourWeekly, 2020));

            Assert.AreEqual(000.00m, TestShim(0732.04m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.01m, TestShim(0732.05m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.01m, TestShim(0732.11m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.02m, TestShim(0732.12m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(008.28m, TestShim(0792.04m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(008.29m, TestShim(0792.05m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(008.29m, TestShim(0792.11m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(008.30m, TestShim(0792.12m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(541.53m, TestShim(4167.04m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(541.54m, TestShim(4167.05m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(541.55m, TestShim(4167.12m, niCode, PayPeriods.Monthly, 2020));

            // M
            niCode = 'M';
            Assert.AreEqual(00.00m, TestShim(169.04m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(00.00m, TestShim(169.05m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(00.00m, TestShim(169.11m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(00.00m, TestShim(169.12m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(00.00m, TestShim(183.03m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(00.00m, TestShim(183.04m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(00.01m, TestShim(183.05m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(00.01m, TestShim(183.11m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(93.48m, TestShim(962.04m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(93.49m, TestShim(962.05m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(93.50m, TestShim(962.12m, niCode, PayPeriods.Weekly, 2020));

            Assert.AreEqual(000.00m, TestShim(0338.04m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.00m, TestShim(0338.05m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.00m, TestShim(0338.11m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.00m, TestShim(0338.12m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.00m, TestShim(0366.03m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.00m, TestShim(0366.04m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.01m, TestShim(0366.05m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(000.01m, TestShim(0366.09m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(186.96m, TestShim(1924.04m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(186.97m, TestShim(1924.05m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(186.98m, TestShim(1924.12m, niCode, PayPeriods.Fortnightly, 2020));

            Assert.AreEqual(000.00m, TestShim(0676.04m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.00m, TestShim(0676.05m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.00m, TestShim(0676.11m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.00m, TestShim(0676.12m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.00m, TestShim(0731.04m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.01m, TestShim(0731.05m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.01m, TestShim(0731.11m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(000.01m, TestShim(0731.12m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(373.92m, TestShim(3847.04m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(373.93m, TestShim(3847.05m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(373.94m, TestShim(3847.12m, niCode, PayPeriods.FourWeekly, 2020));

            Assert.AreEqual(000.00m, TestShim(0732.04m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.00m, TestShim(0732.05m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.00m, TestShim(0732.11m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.00m, TestShim(0732.12m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.00m, TestShim(0792.04m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.01m, TestShim(0792.05m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.01m, TestShim(0792.11m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(000.01m, TestShim(0792.12m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(405.00m, TestShim(4167.04m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(405.01m, TestShim(4167.05m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(405.02m, TestShim(4167.12m, niCode, PayPeriods.Monthly, 2020));

            // Z
            niCode = 'Z';
            Assert.AreEqual(00.00m, TestShim(169.04m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(00.00m, TestShim(169.05m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(00.00m, TestShim(169.11m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(00.00m, TestShim(169.12m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(00.00m, TestShim(183.03m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(00.00m, TestShim(183.04m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(00.00m, TestShim(183.05m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(00.00m, TestShim(183.11m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(15.58m, TestShim(962.04m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(15.59m, TestShim(962.05m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(15.60m, TestShim(962.12m, niCode, PayPeriods.Weekly, 2020));

            Assert.AreEqual(00.00m, TestShim(0338.04m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(00.00m, TestShim(0338.05m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(00.00m, TestShim(0338.11m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(00.00m, TestShim(0338.12m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(00.00m, TestShim(0366.03m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(00.00m, TestShim(0366.04m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(00.00m, TestShim(0366.05m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(00.00m, TestShim(0366.09m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(31.16m, TestShim(1924.04m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(31.17m, TestShim(1924.05m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(31.18m, TestShim(1924.12m, niCode, PayPeriods.Fortnightly, 2020));

            Assert.AreEqual(00.00m, TestShim(0676.04m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(00.00m, TestShim(0676.05m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(00.00m, TestShim(0676.11m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(00.00m, TestShim(0676.12m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(00.00m, TestShim(0731.04m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(00.00m, TestShim(0731.05m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(00.00m, TestShim(0731.11m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(00.00m, TestShim(0731.12m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(62.32m, TestShim(3847.04m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(62.33m, TestShim(3847.05m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(62.34m, TestShim(3847.12m, niCode, PayPeriods.FourWeekly, 2020));

            Assert.AreEqual(0732.04m, TestShim(00.00m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(0732.05m, TestShim(00.00m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(0732.11m, TestShim(00.00m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(0732.12m, TestShim(00.00m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(0792.04m, TestShim(00.00m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(0792.05m, TestShim(00.00m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(0792.11m, TestShim(00.00m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(0792.12m, TestShim(00.00m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(4167.04m, TestShim(67.50m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(4167.05m, TestShim(67.51m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(4167.12m, TestShim(67.52m, niCode, PayPeriods.Monthly, 2020));

            // X Codeu
            niCode = 'X';
            Assert.AreEqual(0m, TestShim(162.29m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(0m, TestShim(162.30m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(0m, TestShim(892.04m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(0m, TestShim(892.05m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(0m, TestShim(892.29m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(0m, TestShim(892.30m, niCode, PayPeriods.Weekly, 2020));
            Assert.AreEqual(0m, TestShim(1180m, niCode, PayPeriods.Weekly, 2020));

            Assert.AreEqual(0m, TestShim(324.29m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(0m, TestShim(324.30m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(0m, TestShim(1783.04m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(0m, TestShim(1783.05m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(0m, TestShim(1783.29m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(0m, TestShim(1783.30m, niCode, PayPeriods.Fortnightly, 2020));
            Assert.AreEqual(0m, TestShim(2545m, niCode, PayPeriods.Fortnightly, 2020));

            Assert.AreEqual(0m, TestShim(648.29m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(0m, TestShim(648.30m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(0m, TestShim(3566.04m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(0m, TestShim(3566.05m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(0m, TestShim(3566.29m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(0m, TestShim(3566.30m, niCode, PayPeriods.FourWeekly, 2020));
            Assert.AreEqual(0m, TestShim(4850m, niCode, PayPeriods.FourWeekly, 2020));

            Assert.AreEqual(0m, TestShim(702.29m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(0m, TestShim(702.30m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(0m, TestShim(3863.04m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(0m, TestShim(3863.05m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(0m, TestShim(3863.29m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(0m, TestShim(3863.30m, niCode, PayPeriods.Monthly, 2020));
            Assert.AreEqual(0m, TestShim(5500m, niCode, PayPeriods.Monthly, 2020));

            // Ensure the UEL/LEL Figures are all zero for X Code
            var niResult = GetCalculationResult(600m, niCode, PayPeriods.Weekly, 2020);
            Assert.AreEqual(0m, niResult.EarningsUptoIncludingLEL);
            Assert.AreEqual(0m, niResult.EarningsAboveUEL);
            Assert.AreEqual(0m, niResult.EarningsAboveSTUptoIncludingUEL);
            Assert.AreEqual(0m, niResult.EarningsAbovePTUptoIncludingST);
            Assert.AreEqual(0m, niResult.EarningsAboveLELUptoIncludingPT);
        }
    }
}
