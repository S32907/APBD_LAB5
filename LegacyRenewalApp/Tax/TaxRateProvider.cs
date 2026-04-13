using System.Collections.Generic;

namespace LegacyRenewalApp.Tax;

public class TaxRateProvider: ITaxRate
{
    private static readonly Dictionary<string, decimal> Rates = new()
    {
        { "Poland", 0.23m },
        { "Germany", 0.19m },
        { "Czech Republic", 0.21m },
        { "Norway", 0.25m }
    };
    
    
    
    public decimal GetTaxRate(string country)
    {
        return Rates.GetValueOrDefault(country, 0.20m);
    }
}