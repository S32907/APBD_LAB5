namespace LegacyRenewalApp.LoyaltyDiscount;

public class LongTermLoyaltyDiscount: ILoyaltyDiscountStrategy
{
    public bool IsApplicable(Customer customer)
    {
        return customer.YearsWithCompany >= 5;
    }

    public decimal Apply(decimal baseAmount)
    {
        return baseAmount * 0.07m;
    }

    public string addNote()
    {
        return "long-term loyalty discount; ";
    }
}