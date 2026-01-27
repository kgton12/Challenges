namespace CodeWars.Resolutions;

public class AlphabetWarClass
{
    public static string AlphabetWar(string fight)
    {
        Dictionary<string, int> leftSideValues = new() {
             {"w", 4 },
             {"p", 3 },
             {"b", 2 },
             {"s", 1 }
        };

        Dictionary<string, int> rigthSideValues = new() {
             {"m", 4 },
             {"q", 3 },
             {"d", 2 },
             {"z", 1 }
        };

        int leftPoints = 0;
        int rigthPoints = 0;

        foreach (var item in fight.ToLower())
        {
            if (rigthSideValues.ContainsKey(item.ToString())) rigthPoints += rigthSideValues[item.ToString()];
            if (leftSideValues.ContainsKey(item.ToString())) leftPoints += leftSideValues[item.ToString()];
        }

        if (rigthPoints > leftPoints) return "Right side wins!";
        else if (leftPoints > rigthPoints) return "Left side wins!";
        else return "Let's fight again!";
    }
}

