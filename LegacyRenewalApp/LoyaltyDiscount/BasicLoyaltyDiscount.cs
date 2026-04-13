namespace LegacyRenewalApp.LoyaltyDiscount;

public class BasicLoyaltyDiscount: ILoyaltyDiscountStrategy
{
    public bool IsApplicable(Customer customer)
    {
        return customer.YearsWithCompany >= 2;
    }

    public decimal Apply(decimal baseAmount)
    {
        return baseAmount * 0.03m;
    }

    public string addNote()
    {
        return "basic loyalty discount; ";
    }
}