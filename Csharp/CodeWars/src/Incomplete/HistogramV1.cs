using System.Text;

namespace CodeWars.Incomplete;

public class HistogramV1
{
    //https://www.codewars.com/kata/57c6c2e1f8392d982a0000f2/train/csharp
    public static string Histogram(int[] results)
    {
        int max = results.Max();
        var sb = new StringBuilder();

        if (max > 0)
        {
            for (int r = 0; r <= max; r++)
            {
                var lineSb = new StringBuilder();

                for (int i = 0; i < results.Length; i++)
                {
                    if (i > 0) lineSb.Append(' ');

                    int c = results[i];

                    int rNumber = max - c;

                    if (c > 0 && r == rNumber)
                        lineSb.Append(c);
                    else if (r >= (max - c + 1) && r <= max)
                        lineSb.Append('#');
                    else
                        lineSb.Append(' ');
                }
                sb.Append(lineSb.ToString().TrimEnd());
                sb.Append('\n');
            }
        }

        sb.Append("-----------\n");
        sb.Append("1 2 3 4 5 6\n");

        return sb.ToString();
    }
}