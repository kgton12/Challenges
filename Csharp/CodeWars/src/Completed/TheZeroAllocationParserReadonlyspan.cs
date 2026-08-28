using System.Globalization;

namespace CodeWars.Completed;

public class TheZeroAllocationParserReadonlyspan
{
    public static double ParseStockPrice(ReadOnlySpan<char> rawData)
    {
        // Example input: "SYM:AAPL|PRC:150.25|VOL:1000"

        int prcIndex = rawData.IndexOf("PRC:".AsSpan());
        if (prcIndex == -1) return 0.0;

        int startIndex = prcIndex + 4; // Move past "PRC:"

        var remainingData = rawData[startIndex..];
        int endIndex = remainingData.IndexOf("|VOL:".AsSpan());
        if (endIndex == -1) endIndex = remainingData.Length;

        return double.Parse(remainingData[..endIndex], CultureInfo.InvariantCulture);
    }
}