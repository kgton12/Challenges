namespace CodeWars.Resolutions;

public class TipCalculator
{
    public static int CalculateTip(double amount, string rating)
    {
        var tip = new Dictionary<string, int>{
                { "terrible", 0 },
                { "poor", 5 },
                { "good", 10 },
                { "great", 15 },
                { "excellent", 20 }
            };

        if (tip.TryGetValue(rating.ToLower(), out int percentage))
            return (int)Math.Ceiling(amount * percentage / 100);
        else
            return -1;
    }
}

