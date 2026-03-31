namespace LegacyRenewalApp.Discount;

public class EducationStrategy: IDiscountStrategy
{
    public bool Strategy(Customer customer, SubscriptionPlan subscriptionPlan)
    {
        return customer.Segment == "Education" &&  subscriptionPlan.IsEducationEligible;
    }

    public decimal ApplyDiscount(decimal baseAmount)
    {
        return baseAmount * 0.20m;
    }

    public string AddToNode()
    {
        return "education discount; ";
    }
}