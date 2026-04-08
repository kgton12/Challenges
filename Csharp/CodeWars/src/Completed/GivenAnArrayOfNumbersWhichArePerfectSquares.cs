namespace CodeWars.Completed;

public class GivenAnArrayOfNumbersWhichArePerfectSquares
{
    public static int[] GetSquares(int[] array)
    {
        return [..
            array
            .Distinct()
            .OrderBy(x => x)
            .Where(x => Math.Sqrt(x) % 1 == 0)
        ];
    }
}
