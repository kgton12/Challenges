namespace CodeWars.Completed;

public class OnesAndZeros
{
    public static int BinaryArrayToNumber(int[] BinaryArray) =>
        Convert.ToInt32(string.Concat(BinaryArray), 2);
}