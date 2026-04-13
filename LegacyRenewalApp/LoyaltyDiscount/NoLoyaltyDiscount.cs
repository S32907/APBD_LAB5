namespace LegacyRenewalApp.LoyaltyDiscount;

public class NoLoyaltyDiscount: ILoyaltyDiscountStrategy
{
    public bool IsApplicable(Customer customer)
    {
        return customer.YearsWithCompany < 2;
    }

    public decimal Apply(decimal baseAmount)
    {
        return 0;
    }

    public string addNote()
    {
        return "no loyalty discount; ";
    }
}