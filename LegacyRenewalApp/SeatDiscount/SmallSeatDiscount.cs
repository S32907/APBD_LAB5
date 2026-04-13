namespace LegacyRenewalApp.SeatDiscount;

public class SmallSeatDiscount: ISeatDiscountStrategy
{
    public bool IsApplicable(int seatCount)
    {
        return seatCount >= 10;
    }

    public decimal Apply(decimal baseAmount)
    {
       return baseAmount * 0.04m;
    }

    public string addNote()
    {
        return "small team discount; ";
    }
}