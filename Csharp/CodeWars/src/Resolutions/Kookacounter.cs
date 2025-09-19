namespace CodeWars.src.Resolutions;

public class Kookacounter
{
    public static int KookaCounter(string laughing)
    {
        var segments = SegmentWord(laughing, 2);

        string kooka = string.Empty;
        int result = 0;

        foreach (var item in segments)
        {
            if (!item.Equals(kooka))
            {
                result += 1;
                kooka = item;
            }
        }

        return result;
    }

    private static string[] SegmentWord(string str, int chunk) =>
        [..
            Enumerable.Range(0, str.Length / chunk + (str.Length % chunk == 0 ? 0 : 1))
                      .Select(i => str.Substring(i * chunk, Math.Min(2, str.Length - i * chunk)))
        ];
}
