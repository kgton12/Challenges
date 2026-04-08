namespace CodeWars.Completed;

public class ArrayLeadersArraySeries3
{
    public static int[] ArrayLeaders(int[] numbers)
    {
        var result = new List<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            int sumOfRest = numbers.Skip(i + 1).Sum();

            if (numbers[i] > sumOfRest)
                result.Add(numbers[i]);

        }

        return [.. result];
    }
}
