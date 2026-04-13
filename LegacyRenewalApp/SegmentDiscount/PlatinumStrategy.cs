namespace LegacyRenewalApp.SegmentDiscount;

public class PlatinumStrategy: IDiscountStrategy
{
    public bool Strategy(Customer customer, SubscriptionPlan subscriptionPlan)
    {
        return customer.Segment == "Platinum";
    }

    public decimal ApplyDiscount(decimal baseAmount)
    {
        return baseAmount * 0.15m;
    }

    public string AddToNode()
    {
        return "platinum discount; ";
    }
}