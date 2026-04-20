namespace CodeWars.Completed;

public class HelpSuzukiCountHisVegetables
{
    private static string[] Veggies => ["cabbage", "carrot", "celery", "cucumber", "mushroom", "onion", "pepper", "potato", "tofu", "turnip"];
    public static List<Tuple<int, string>> CountVegetables(string s)
    {
        return [.. s.Split(" ")
                 .Where(Veggies.Contains)
                 .GroupBy(x => x)
                 .Select(x => new Tuple<int, string>(x.Count(), x.Key))
                 .OrderByDescending(x => x.Item1)
                 .ThenByDescending(x => x.Item2)
        ];
    }
}