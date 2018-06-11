# Cedita.Payroll
Cedita.Payroll is a .NET Standard version of HMRC-compliant PAYE, National Insurance, and related calculators. Core components for building payroll services.

## Usage
Version 2 comes with a revised API meaning there's less wiring up to do, and is also DI first (whilst retaining ease to wire up manually).

To get started, install from NuGet:

    Install-Package Cedita.Payroll -pre
    
If you're using ASP.NET Core (or any `IServiceCollection` compatible DI library), just call:

```cs
services.AddCeditaPayroll();
```

## Calculate Payroll for a Pay Period
To calculate both PAYE Tax and National Insurance in a few lines of code using the V2 Payroll Calculation API, let's take a look at a basic example:

```cs
// ctor
..(IPayrollCalculatorFactory payrollCalculatorFactory)
{
   payrollCalculator = payrollCalculatorFactory.CreatePayrollCalculator(2018);
}

// implementation
var calcRequest = new PayrollCalculationRequest
{
    PayFrequency = PayPeriods.Weekly,
    PayPeriod = 3,
    TaxCode = TaxCode.Parse("1185L"),
    IsWeek1Month1 = true,
    TaxableGross = 500,
    NiableGross = 500
};

var result = payrollCalculator.Calculate(calcRequest);
// Tax - result.Paye.Tax
// NI - result.NationalInsurance.NetNi
// Ee NI result.NationalInsurance.EmployeeNi
// Er NI result.NationalInsurance.EmployerNi
```

## Calculate Tax Due for Pay Period (PAYE only)
Of course, you can also continue to calculate individually not unlike the V1 API, it just takes a little bit less wiring up.

To calculate the tax due for any specific period would take 2 lines of code once wired up and injected via your DI container (see above for single line).

```cs
// Where DI is used
public decimal CalculateTax(IPayeCalculationEngineFactory payeFactory)
{
    var payeEngine = payeFactory.CreatePayeCalculationEngine(2018); // Specify tax year
    var taxDueInPeriod = payeEngine.CalculateTaxDueForPeriod("1185L", 5000, PayPeriods.Monthly, 1);
    
    // ..
}
```
