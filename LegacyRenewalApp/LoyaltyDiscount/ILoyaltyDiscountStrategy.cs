namespace LegacyRenewalApp.LoyaltyDiscount;

public interface ILoyaltyDiscountStrategy
{
    bool IsApplicable(Customer customer);
    decimal Apply(decimal baseAmount);

    string addNote();
}