namespace CodeWars;

public class HarvestFestival
{
    public static string Plant(char seed, int water, int fert, int temp)
    {
        string[] stem = [.. Enumerable.Repeat(new string('-', water), water)];
        string flowers = new(seed, fert);

        List<string> result = [];

        if (temp < 20 || temp > 30)
            return new(string.Concat(stem) + seed);

        for (int i = 0; i < stem.Length; i++)
        {
            result.Add(stem[i]);
            result.Add(flowers);
        }

        return string.Concat(result);
    }
}