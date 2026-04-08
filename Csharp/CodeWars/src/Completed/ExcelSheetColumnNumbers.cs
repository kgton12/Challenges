namespace CodeWars.Completed;

public class ExcelSheetColumnNumbers
{
    public static long TitleToNumber(string title)
    {
        long result = 0;
        foreach (char chr in title)
            result = result * 26 + (chr - 'A' + 1);

        return result;
    }
}