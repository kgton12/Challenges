using System.Globalization;

namespace CodeWars.Resolutions;

public class ZebulansNightmareClass
{
    public static string ZebulansNightmare(string functionName)
    {
        TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;

        return string.Concat(
            functionName.Split('_').Select((s, i) => i == 0 ? s : textInfo.ToTitleCase(s))
        );
    }
}
