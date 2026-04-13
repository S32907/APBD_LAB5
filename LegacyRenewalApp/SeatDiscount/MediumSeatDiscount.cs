namespace LegacyRenewalApp.SeatDiscount;

public class MediumSeatDiscount: ISeatDiscountStrategy
{
    public bool IsApplicable(int seatCount)
    {
        return seatCount >= 20;
    }

    public decimal Apply(decimal baseAmount)
    {
        return baseAmount * 0.08m;
    }

    public string addNote()
    {
        return "medium team discount; ";
    }
}