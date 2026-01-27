namespace CodeWars.Resolutions;

public class FindTheNthDigitOfaNumber
{
    public static int FindDigit(int num, int nth)
    {
        if (nth <= 0) return -1;

        string absNum = Math.Abs(num).ToString();

        if (nth > absNum.Length) return 0;

        char digitChar = absNum[^nth];
        return digitChar - '0';
    }
}
