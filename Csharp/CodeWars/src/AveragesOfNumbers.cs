namespace CodeWars.src;

public class AveragesOfNumbers
{
    public static double[] Averages(int[] numbers) =>
        (numbers is null || numbers.Length < 2)
        ? []
        : [.. Enumerable
              .Range(1, numbers.Length - 1)
              .Select((x) => (numbers[x] + numbers[x - 1]) / 2.0)
        ];
}
