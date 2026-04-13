namespace LegacyRenewalApp.SeatDiscount;

public interface ISeatDiscountStrategy
{
    bool IsApplicable(int seatCount);
    decimal Apply(decimal baseAmount);
    string addNote();
}