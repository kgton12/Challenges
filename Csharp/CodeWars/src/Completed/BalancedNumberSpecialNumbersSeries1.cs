namespace CodeWars.Completed;

public class BalancedNumberSpecialNumbersSeries1
{
    public static string BalancedNumber(int number)
    {
        int[] arrayValues = [.. number.ToString().Select(x => x - '0')];
        int length = arrayValues.Length;

        if (length <= 2) return "Balanced";

        int halfLength = length / 2;
        bool isEven = length % 2 == 0;

        int leftEnd = isEven ? halfLength - 1 : halfLength;
        int rightStart = isEven ? halfLength + 1 : halfLength + 1;

        int sumLeft = arrayValues[..leftEnd].Sum();
        int sumRight = arrayValues[rightStart..].Sum();

        return sumLeft == sumRight ? "Balanced" : "Not Balanced";
    }
}