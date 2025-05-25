namespace CodeWars.src.Resolutions;

public class FindTheStrayNumber
{
    public static int Stray(int[] numbers)
    {
        int result = 0;
        foreach (var num in numbers)
            result ^= num;

        return result;
    }
}
