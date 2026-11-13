using System.Globalization;

namespace CodeWars.Completed;

public static class FormatNumberAsCurrencyUsingExtensionMethod
{
    public static string ToCurrency(this decimal d, string currency)
    {
        decimal result = Math.Round(d, 2);
        string signal = result < 0 ? "-" : "";
        string formattedResult = Math.Abs(result)
            .ToString("F2", CultureInfo.InvariantCulture);

        return $"{signal}{currency}{formattedResult}";
    }
}