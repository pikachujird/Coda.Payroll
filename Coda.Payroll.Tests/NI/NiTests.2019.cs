// Copyright (c) Coda Technology Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coda.Payroll.Tests
{
    public partial class NiTests
    {
        [TestCategory("NI Tests"), TestMethod]
        public void NationalInsurance2019()
        {
            // A
            var niCode = 'A';
            Assert.AreEqual(0.00m, TestShim(166.04m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0.02m, TestShim(166.05m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0.02m, TestShim(166.10m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0.02m, TestShim(166.11m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0.07m, TestShim(166.29m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0.08m, TestShim(166.30m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(205.37m, TestShim(962.04m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(205.38m, TestShim(962.05m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(205.41m, TestShim(962.29m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(205.42m, TestShim(962.30m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(239.81m, TestShim(1180.00m, niCode, PayPeriods.Weekly, 2019));

            Assert.AreEqual(0000.00m, TestShim(0332.04m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.02m, TestShim(0332.05m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.02m, TestShim(0332.10m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.02m, TestShim(0332.11m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.07m, TestShim(0332.29m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.08m, TestShim(0332.30m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0410.74m, TestShim(1924.04m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0410.75m, TestShim(1924.05m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0410.78m, TestShim(1924.29m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0410.79m, TestShim(1924.30m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0508.86m, TestShim(2545.00m, niCode, PayPeriods.Fortnightly, 2019));

            Assert.AreEqual(0000.00m, TestShim(0664.04m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.02m, TestShim(0664.05m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.02m, TestShim(0664.10m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.02m, TestShim(0664.11m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.07m, TestShim(0664.29m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.08m, TestShim(0664.30m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0821.21m, TestShim(3847.04m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0821.22m, TestShim(3847.05m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0821.25m, TestShim(3847.29m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0821.26m, TestShim(3847.30m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0979.68m, TestShim(4850.00m, niCode, PayPeriods.FourWeekly, 2019));

            Assert.AreEqual(0000.00m, TestShim(0719.04m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.02m, TestShim(0719.05m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.02m, TestShim(0719.10m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.02m, TestShim(0719.11m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.07m, TestShim(0719.29m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.08m, TestShim(0719.30m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0889.58m, TestShim(4167.04m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0889.59m, TestShim(4167.05m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0889.62m, TestShim(4167.29m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0889.63m, TestShim(4167.30m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(1100.19m, TestShim(5500.00m, niCode, PayPeriods.Monthly, 2019));

            // B
            niCode = 'B';
            Assert.AreEqual(0000.00m, TestShim(0166.04m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0166.05m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0166.10m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.02m, TestShim(0166.11m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.06m, TestShim(0166.29m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.06m, TestShim(0166.30m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0156.42m, TestShim(0962.04m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0156.43m, TestShim(0962.05m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0156.46m, TestShim(0962.29m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0156.47m, TestShim(0962.30m, niCode, PayPeriods.Weekly, 2019));

            Assert.AreEqual(0000.00m, TestShim(0332.04m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0332.05m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0332.10m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.02m, TestShim(0332.11m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.06m, TestShim(0332.29m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.06m, TestShim(0332.30m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0312.83m, TestShim(1924.04m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0312.84m, TestShim(1924.05m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0312.87m, TestShim(1924.29m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0312.88m, TestShim(1924.30m, niCode, PayPeriods.Fortnightly, 2019));

            Assert.AreEqual(0000.00m, TestShim(0664.04m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0664.05m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0664.10m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.02m, TestShim(0664.11m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.06m, TestShim(0664.29m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.06m, TestShim(0664.30m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0625.45m, TestShim(3847.04m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0625.46m, TestShim(3847.05m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0625.49m, TestShim(3847.29m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0625.50m, TestShim(3847.30m, niCode, PayPeriods.FourWeekly, 2019));

            Assert.AreEqual(0000.00m, TestShim(0719.04m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0719.05m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0719.10m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.02m, TestShim(0719.11m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.06m, TestShim(0719.29m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.06m, TestShim(0719.30m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0677.53m, TestShim(4167.04m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0677.54m, TestShim(4167.05m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0677.57m, TestShim(4167.29m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0677.58m, TestShim(4167.30m, niCode, PayPeriods.Monthly, 2019));

            // C
            niCode = 'C';
            Assert.AreEqual(0000.00m, TestShim(0166.04m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0166.05m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0166.10m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0166.11m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.04m, TestShim(0166.29m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.04m, TestShim(0166.30m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0109.85m, TestShim(0962.04m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0109.86m, TestShim(0962.05m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0109.89m, TestShim(0962.29m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0109.89m, TestShim(0962.30m, niCode, PayPeriods.Weekly, 2019));

            Assert.AreEqual(0000.00m, TestShim(0332.04m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0332.05m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0332.10m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0332.11m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.04m, TestShim(0332.29m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.04m, TestShim(0332.30m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0219.70m, TestShim(1924.04m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0219.71m, TestShim(1924.05m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0219.74m, TestShim(1924.29m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0219.74m, TestShim(1924.30m, niCode, PayPeriods.Fortnightly, 2019));

            Assert.AreEqual(0000.00m, TestShim(0664.04m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0664.05m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0664.10m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0664.11m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.04m, TestShim(0664.29m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.04m, TestShim(0664.30m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0439.25m, TestShim(3847.04m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0439.26m, TestShim(3847.05m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0439.29m, TestShim(3847.29m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0439.29m, TestShim(3847.30m, niCode, PayPeriods.FourWeekly, 2019));

            Assert.AreEqual(0000.00m, TestShim(0719.04m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0719.05m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0719.10m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0719.11m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.04m, TestShim(0719.29m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.04m, TestShim(0719.30m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0475.82m, TestShim(4167.04m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0475.83m, TestShim(4167.05m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0475.86m, TestShim(4167.29m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0475.86m, TestShim(4167.30m, niCode, PayPeriods.Monthly, 2019));

            // H
            niCode = 'H';
            Assert.AreEqual(0000.00m, TestShim(0166.04m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0166.05m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0166.10m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0166.11m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.03m, TestShim(0166.29m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.04m, TestShim(0166.30m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0095.52m, TestShim(0962.04m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0095.53m, TestShim(0962.05m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0095.56m, TestShim(0962.29m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0095.57m, TestShim(0962.30m, niCode, PayPeriods.Weekly, 2019));

            Assert.AreEqual(0000.00m, TestShim(0332.04m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0332.05m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0332.10m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0332.11m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.03m, TestShim(0332.29m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.04m, TestShim(0332.30m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0191.04m, TestShim(1924.04m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0191.05m, TestShim(1924.05m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0191.08m, TestShim(1924.29m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0191.09m, TestShim(1924.30m, niCode, PayPeriods.Fortnightly, 2019));

            Assert.AreEqual(0000.00m, TestShim(0664.04m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0664.05m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0664.10m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0664.11m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.03m, TestShim(0664.29m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.04m, TestShim(0664.30m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0381.96m, TestShim(3847.04m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0381.97m, TestShim(3847.05m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0382.00m, TestShim(3847.29m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0382.01m, TestShim(3847.30m, niCode, PayPeriods.FourWeekly, 2019));

            Assert.AreEqual(0000.00m, TestShim(0719.04m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0719.05m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0719.10m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0719.11m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.03m, TestShim(0719.29m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.04m, TestShim(0719.30m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0413.76m, TestShim(4167.04m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0413.77m, TestShim(4167.05m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0413.80m, TestShim(4167.29m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0413.81m, TestShim(4167.30m, niCode, PayPeriods.Monthly, 2019));

            // J
            niCode = 'J';
            Assert.AreEqual(0000.00m, TestShim(0166.04m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0166.05m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0166.10m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0166.11m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.04m, TestShim(0166.29m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.05m, TestShim(0166.30m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0125.77m, TestShim(0962.04m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0125.78m, TestShim(0962.05m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0125.81m, TestShim(0962.29m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0125.82m, TestShim(0962.30m, niCode, PayPeriods.Weekly, 2019));

            Assert.AreEqual(0000.00m, TestShim(0332.04m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0332.05m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0332.10m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0332.11m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.04m, TestShim(0332.29m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.05m, TestShim(0332.30m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0251.54m, TestShim(1924.04m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0251.55m, TestShim(1924.05m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0251.58m, TestShim(1924.29m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0251.59m, TestShim(1924.30m, niCode, PayPeriods.Fortnightly, 2019));

            Assert.AreEqual(0000.00m, TestShim(0664.04m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0664.05m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0664.10m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0664.11m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.04m, TestShim(0664.29m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.05m, TestShim(0664.30m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0502.91m, TestShim(3847.04m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0502.92m, TestShim(3847.05m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0502.95m, TestShim(3847.29m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0502.96m, TestShim(3847.30m, niCode, PayPeriods.FourWeekly, 2019));

            Assert.AreEqual(0000.00m, TestShim(0719.04m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0719.05m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0719.10m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0719.11m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.04m, TestShim(0719.29m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.05m, TestShim(0719.30m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0544.78m, TestShim(4167.04m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0544.79m, TestShim(4167.05m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0544.82m, TestShim(4167.29m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0544.83m, TestShim(4167.30m, niCode, PayPeriods.Monthly, 2019));

            // M
            niCode = 'M';
            Assert.AreEqual(0000.00m, TestShim(0166.04m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0166.05m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0166.10m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0166.11m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.03m, TestShim(0166.29m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.04m, TestShim(0166.30m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0095.52m, TestShim(0962.04m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0095.53m, TestShim(0962.05m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0095.56m, TestShim(0962.29m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0095.57m, TestShim(0962.30m, niCode, PayPeriods.Weekly, 2019));

            Assert.AreEqual(0000.00m, TestShim(0332.04m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0332.05m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0332.10m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0332.11m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.03m, TestShim(0332.29m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.04m, TestShim(0332.30m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0191.04m, TestShim(1924.04m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0191.05m, TestShim(1924.05m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0191.08m, TestShim(1924.29m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0191.09m, TestShim(1924.30m, niCode, PayPeriods.Fortnightly, 2019));

            Assert.AreEqual(0000.00m, TestShim(0664.04m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0664.05m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0664.10m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0664.11m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.03m, TestShim(0664.29m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.04m, TestShim(0664.30m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0381.96m, TestShim(3847.04m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0381.97m, TestShim(3847.05m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0382.00m, TestShim(3847.29m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0382.01m, TestShim(3847.30m, niCode, PayPeriods.FourWeekly, 2019));

            Assert.AreEqual(0000.00m, TestShim(0719.04m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0719.05m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0719.10m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0719.11m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.03m, TestShim(0719.29m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.04m, TestShim(0719.30m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0413.76m, TestShim(4167.04m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0413.77m, TestShim(4167.05m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0413.80m, TestShim(4167.29m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0413.81m, TestShim(4167.30m, niCode, PayPeriods.Monthly, 2019));

            // Z
            niCode = 'Z';
            Assert.AreEqual(0000.00m, TestShim(0166.04m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.00m, TestShim(0166.05m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.00m, TestShim(0166.10m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.00m, TestShim(0166.11m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.00m, TestShim(0166.29m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0166.30m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0015.92m, TestShim(0962.04m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0015.93m, TestShim(0962.05m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0015.96m, TestShim(0962.29m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0015.97m, TestShim(0962.30m, niCode, PayPeriods.Weekly, 2019));

            Assert.AreEqual(0000.00m, TestShim(0332.04m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.00m, TestShim(0332.05m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.00m, TestShim(0332.10m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.00m, TestShim(0332.11m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.00m, TestShim(0332.29m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0332.30m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0031.84m, TestShim(1924.04m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0031.85m, TestShim(1924.05m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0031.88m, TestShim(1924.29m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0031.89m, TestShim(1924.30m, niCode, PayPeriods.Fortnightly, 2019));

            Assert.AreEqual(0000.00m, TestShim(0664.04m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.00m, TestShim(0664.05m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.00m, TestShim(0664.10m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.00m, TestShim(0664.11m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.00m, TestShim(0664.29m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0664.30m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0063.66m, TestShim(3847.04m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0063.67m, TestShim(3847.05m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0063.70m, TestShim(3847.29m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0063.71m, TestShim(3847.30m, niCode, PayPeriods.FourWeekly, 2019));

            Assert.AreEqual(0000.00m, TestShim(0719.04m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.00m, TestShim(0719.05m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.00m, TestShim(0719.10m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.00m, TestShim(0719.11m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.00m, TestShim(0719.29m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0000.01m, TestShim(0719.30m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0068.96m, TestShim(4167.04m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0068.97m, TestShim(4167.05m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0069.00m, TestShim(4167.29m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0069.01m, TestShim(4167.30m, niCode, PayPeriods.Monthly, 2019));

            // X Code
            niCode = 'X';
            Assert.AreEqual(0m, TestShim(162.29m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0m, TestShim(162.30m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0m, TestShim(892.04m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0m, TestShim(892.05m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0m, TestShim(892.29m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0m, TestShim(892.30m, niCode, PayPeriods.Weekly, 2019));
            Assert.AreEqual(0m, TestShim(1180m, niCode, PayPeriods.Weekly, 2019));

            Assert.AreEqual(0m, TestShim(324.29m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0m, TestShim(324.30m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0m, TestShim(1783.04m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0m, TestShim(1783.05m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0m, TestShim(1783.29m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0m, TestShim(1783.30m, niCode, PayPeriods.Fortnightly, 2019));
            Assert.AreEqual(0m, TestShim(2545m, niCode, PayPeriods.Fortnightly, 2019));

            Assert.AreEqual(0m, TestShim(648.29m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0m, TestShim(648.30m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0m, TestShim(3566.04m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0m, TestShim(3566.05m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0m, TestShim(3566.29m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0m, TestShim(3566.30m, niCode, PayPeriods.FourWeekly, 2019));
            Assert.AreEqual(0m, TestShim(4850m, niCode, PayPeriods.FourWeekly, 2019));

            Assert.AreEqual(0m, TestShim(702.29m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0m, TestShim(702.30m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0m, TestShim(3863.04m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0m, TestShim(3863.05m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0m, TestShim(3863.29m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0m, TestShim(3863.30m, niCode, PayPeriods.Monthly, 2019));
            Assert.AreEqual(0m, TestShim(5500m, niCode, PayPeriods.Monthly, 2019));

            // Ensure the UEL/LEL Figures are all zero for X Code
            var niResult = GetCalculationResult(600m, niCode, PayPeriods.Weekly, 2019);
            Assert.AreEqual(0m, niResult.EarningsUptoIncludingLEL);
            Assert.AreEqual(0m, niResult.EarningsAboveUEL);
            Assert.AreEqual(0m, niResult.EarningsAboveSTUptoIncludingUEL);
            Assert.AreEqual(0m, niResult.EarningsAbovePTUptoIncludingST);
            Assert.AreEqual(0m, niResult.EarningsAboveLELUptoIncludingPT);
        }
    }
}
