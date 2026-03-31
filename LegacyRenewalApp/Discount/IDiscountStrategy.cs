namespace LegacyRenewalApp.Discount;

public interface IDiscountStrategy
{
    bool Strategy(Customer customer, SubscriptionPlan subscriptionPlan);
    decimal ApplyDiscount(decimal baseAmount);
    string AddToNode();
}