namespace CodeWars.src.Resolutions;

public class TheCouponCode
{
    public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
    {
        var currDate = DateTime.Parse(currentDate);
        var expDate = DateTime.Parse(expirationDate);

        return enteredCode.Equals(correctCode) && expDate >= currDate;
    }
}
