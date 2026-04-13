namespace LegacyRenewalApp.SeatDiscount;

public class LargeSeatDiscount: ISeatDiscountStrategy
{
    public bool IsApplicable(int seatCount)
    {
        return seatCount >= 50;
    }

    public decimal Apply(decimal baseAmount)
    {
        return baseAmount * 0.12m;
    }

    public string addNote()
    {
        return "large team discount; ";
    }
}