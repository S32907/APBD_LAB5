namespace LegacyRenewalApp.SegmentDiscount;

public class GoldStrategy: IDiscountStrategy
{
    public bool Strategy(Customer customer, SubscriptionPlan subscriptionPlan)
    {
        return customer.Segment == "Gold";
    }

    public decimal ApplyDiscount(decimal baseAmount)
    {
        return baseAmount * 0.10m;
    }

    public string AddToNode()
    {
        return "gold discount; ";
    }
}