namespace CodeWars.src.Resolutions;

public class CountTheDigit
{
    public static int NbDig(int n, int d)
    {
        List<string> squaredNumbers = [];

        for (int i = 0; i <= n; i++)
        {
            string squareStr = Math.Pow(i, 2).ToString();

            if (squareStr.Contains(d.ToString())) squaredNumbers.Add(squareStr);
        }

        return string.Join(" ", squaredNumbers).Count((value) => char.ToString(value) == d.ToString());
    }
}

