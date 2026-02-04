namespace CodeWars.Resolutions;

public class DollarsAndCents
{
    public static string FormatMoney(double amount) =>
        $"${amount:F2}".Replace(',', '.');
}
