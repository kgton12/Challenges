namespace CodeWars.Resolutions;

public class TheOfficeIIBoredomScore
{
    public static string Boredom(Dictionary<string, string> staff)
    {
        Dictionary<string, int> boredom = new()
        {
            { "accounts", 1 },
            { "finance", 2 },
            { "canteen", 10 },
            { "regulation", 3 },
            { "trading", 6 },
            { "change", 6 },
            { "IS", 8 },
            { "retail", 5 },
            { "cleaning", 4 },
            { "pissing about", 25 }
        };

        int boredomTotal = staff.Sum(x => boredom.GetValueOrDefault(x.Value));

        if (boredomTotal <= 80) return "kill me now";
        else if (boredomTotal > 80 && boredomTotal < 100) return "i can handle this";
        else return "party time!!";
    }
}
