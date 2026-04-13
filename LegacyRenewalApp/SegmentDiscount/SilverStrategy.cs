namespace LegacyRenewalApp.SegmentDiscount;

public class SilverStrategy: IDiscountStrategy
{
    public bool Strategy(Customer customer, SubscriptionPlan subscriptionPlan)
    {
        return customer.Segment == "Silver";
    }

    public decimal ApplyDiscount(decimal baseAmount)
    {
        return baseAmount * 0.05m;
    }

    public string AddToNode()
    {
        return "silver discount; ";
    }
}