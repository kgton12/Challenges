using System.Text;

namespace CodeWars.Resolutions;

public class OddevenStringSort
{
    public static string SortMyString(string s)
    {
        var evenIndex = new StringBuilder();
        var oddIndex = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
            if (i % 2 == 0)
                evenIndex.Append(s[i]);
            else
                oddIndex.Append(s[i]);

        return $"{evenIndex} {oddIndex}";
    }
}
