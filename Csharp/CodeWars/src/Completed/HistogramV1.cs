using System.Text;

namespace CodeWars.Completed;

public class HistogramV1
{
    public static string Histogram(int[] results)
    {
        results ??= [];

        int n = results.Length;
        int max = n > 0 ? results.Max() : 0;
        var sb = new StringBuilder();

        int baseWidth = n > 0 ? 2 * n - 1 : 0;

        if (max > 0)
        {
            for (int r = 0; r <= max; r++)
            {
                var lineSb = new StringBuilder(new string(' ', baseWidth));

                for (int i = 0; i < n; i++)
                {
                    int pos = i * 2;
                    int c = results[i];
                    int rNumber = max - c;

                    if (c > 0 && r == rNumber)
                    {
                        string s = c.ToString();
                        if (pos + s.Length > lineSb.Length)
                            lineSb.Append(new string(' ', pos + s.Length - lineSb.Length));
                        for (int k = 0; k < s.Length; k++) lineSb[pos + k] = s[k];
                    }
                    else if (r >= (max - c + 1) && r <= max)
                    {
                        if (pos < lineSb.Length) lineSb[pos] = '#';
                    }
                }

                sb.Append(lineSb.ToString().TrimEnd());
                sb.Append('\n');
            }
        }

        if (baseWidth > 0)
        {
            sb.Append(new string('-', baseWidth));
            sb.Append('\n');

            var labelSb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                if (i > 0) labelSb.Append(' ');
                labelSb.Append(i + 1);
            }
            sb.Append(labelSb);
            sb.Append('\n');
        }
        else
        {
            sb.Append(new string('-', 0));
            sb.Append('\n');
            sb.Append('\n');
        }

        return sb.ToString();
    }
}