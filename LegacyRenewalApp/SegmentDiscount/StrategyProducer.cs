using System;
using System.Collections.Generic;
namespace LegacyRenewalApp.SegmentDiscount;

public class StrategyProducer
{
    private readonly List<IDiscountStrategy> _strategies = new List<IDiscountStrategy>()
    {
        new SilverStrategy(), 
        new GoldStrategy(),
        new PlatinumStrategy(),
        new EducationStrategy()
    };

    public IDiscountStrategy GetStrategy(Customer customer, SubscriptionPlan subscriptionPlan)
    {
        foreach (var strategy in _strategies)
        {
            if (strategy.Strategy(customer, subscriptionPlan))
            {
                return strategy;
            }
        }

        throw new ArgumentException("No strategy was found for the customer");
    }
}