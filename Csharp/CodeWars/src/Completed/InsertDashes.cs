namespace CodeWars.Completed;

public class InsertDashes
{
    public static string InsertDash(int num)
    {
        var numString = num.ToString();
        if (numString.Length < 2)
            return numString;

        var sb = new System.Text.StringBuilder();
        sb.Append(numString[0]);

        for (int i = 1; i < numString.Length; i++)
        {
            if (IsOdd(numString[i - 1]) && IsOdd(numString[i]))
                sb.Append('-');
            sb.Append(numString[i]);
        }

        return sb.ToString();
    }

    private static bool IsOdd(char c) => (c - '0') % 2 != 0;
}