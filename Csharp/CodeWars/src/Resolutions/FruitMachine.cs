namespace CodeWars.Resolutions;

public class FruitMachine
{
    private static readonly Dictionary<string, int> Scoring =
    new()
        {
            {"Wild", 100 },
            {"Star", 90 },
            {"Bell", 80 },
            {"Shell", 70 },
            {"Seven", 60 },
            {"Cherry", 50 },
            {"Bar", 40 },
            {"King", 30 },
            {"Queen", 20 },
            {"Jack", 10 },
        };

    public static int Fruit(List<string[]> reels, int[] spins)
    {
        List<string> reel = [];

        for (int i = 0; i < reels.Count; i++)
        {
            reel.Add(
                reels[i][spins[i]]
            );
        }

        if (reel.Distinct().Count() == 1)
            return Scoring.GetValueOrDefault(reel.First());
        else if (reel.Distinct().Count() == 2)
        {
            bool containsWild = reel.Any(x => x.Equals("Wild"));
            string score = reel.GroupBy(x => x).First(x => x.Count() == 2).Key;

            if (score == "Wild" || !containsWild)
                return Scoring.GetValueOrDefault(score) / 10;
            else
                return Scoring.GetValueOrDefault(score) / 10 * 2;
        }
        else
            return 0;
    }
}