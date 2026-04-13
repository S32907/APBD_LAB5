namespace LegacyRenewalApp.SeatDiscount;

public class NoSeatDiscount: ISeatDiscountStrategy
{
    public bool IsApplicable(int seatCount)
    {
        return seatCount < 10;
    }

    public decimal Apply(decimal baseAmount)
    {
        return 0;
    }

    public string addNote()
    {
        return "no team discount; ";
    }
}