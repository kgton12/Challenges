namespace CodeWars.Resolutions;

public class MobileDisplayKeystrokes
{
    public static int MobileKeyboard(string str)
    {
        Dictionary<string, int> phoneKeyboard =
        new()
        {
            {"1234567890*#", 1 },
            {"adgjmptw", 2 },
            {"behknqux", 3 },
            {"cfilorvy", 4 },
            {"sz", 5 },
        };

        return str.Sum(
            x => phoneKeyboard.GetValueOrDefault(
                phoneKeyboard.Keys.FirstOrDefault(v => v.Contains(x)
            ) ?? string.Empty)
        );
    }
}