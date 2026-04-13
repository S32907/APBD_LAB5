using System;
using System.Collections.Generic;
namespace LegacyRenewalApp.LoyaltyDiscount;

public class LoyaltyStrategyProducer
{
    private readonly List<ILoyaltyDiscountStrategy> _strategies = new List<ILoyaltyDiscountStrategy>()
    {
        new BasicLoyaltyDiscount(),
        new LongTermLoyaltyDiscount(),
        new NoLoyaltyDiscount()
    };

    public ILoyaltyDiscountStrategy getLoyaltyDiscountStrategy(Customer customer)
    {
        foreach (var strategy in _strategies)
        {
            if (strategy.IsApplicable(customer))
            {
                return strategy;
            }
        }
        
        throw new ArgumentException("No loyalty strategy was found for the customer");
    }
}