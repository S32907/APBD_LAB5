using System;
using System.Collections.Generic;

namespace LegacyRenewalApp.SeatDiscount;

public class SeatStrategyProducer
{
    private readonly List<ISeatDiscountStrategy> strategies = new List<ISeatDiscountStrategy>()
    {
        new LargeSeatDiscount(),
        new MediumSeatDiscount(),
        new SmallSeatDiscount(),
        new NoSeatDiscount()
    };

    public ISeatDiscountStrategy GetSeatStrategy(int seatCount)
    {
        foreach (var strategy in strategies)
        {
            if (strategy.IsApplicable(seatCount))
            {
                return strategy;
            }
        }
        
        throw new ArgumentException("No seat strategy was found for the customer");
    }
}