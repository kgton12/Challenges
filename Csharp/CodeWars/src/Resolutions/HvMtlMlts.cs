namespace CodeWars.src.Resolutions;

public class HvMtlMlts
{
    public static string HeavyMetalUmlauts(string boringText)
    {
        List<Dictionary<char, char>> dic = [
            new Dictionary<char, char> {
                {'A','Ä'},
                {'O','Ö'},
                {'a','ä'},
                {'o','ö'},
                {'E','Ë'},
                {'U','Ü'},
                {'e','ë'},
                {'u','ü'},
                {'I','Ï'},
                {'Y','Ÿ'},
                {'i','ï'},
                {'y','ÿ'}
            }
         ];

        return string.Concat(
                boringText.Select(
                    x => string.Concat(dic.Select(
                        d => d.TryGetValue(x, out char v) ? v : x)
                    )
                )
        );
    }
}
