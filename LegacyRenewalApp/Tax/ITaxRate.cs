namespace LegacyRenewalApp.Tax;

public interface ITaxRate
{
    decimal GetTaxRate(string country);
}