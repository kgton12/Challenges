namespace CodeWars.Completed;

public class WriteNumberinExpandedForm
{
    public static string ExpandedForm(long num)
    {
        string numStr = num.ToString();
        int size = numStr.Length;
        List<string> parts = [];

        for (int i = 0; i < size; i++)
        {
            if (numStr[i] != '0')
            {
                long digit = numStr[i] - '0';
                long placeValue = digit * (long)Math.Pow(10, size - i - 1);
                parts.Add(placeValue.ToString());
            }
        }

        return string.Join(" + ", parts);
    }
}

