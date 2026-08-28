using System.Numerics;

namespace CodeWars.Completed;

public class SumOfGroups
{
    private record Num(BigInteger Value, string ValueOrdered);

    public static int SumOfDigitGroups(BigInteger[] numbers)
    {
        var sum = numbers
            .Select(x => new Num(x, OrderByNum(x)))
            .GroupBy(x => x.ValueOrdered)
            .Where(x => x.Count() > 1)
            .Select(x => x.MinBy(r => r.Value))
            .Where(x => x != null)
            .Aggregate(BigInteger.Zero, (acc, x) => acc + x!.Value);

        return SumDigit(sum);
    }

    private static string OrderByNum(BigInteger n) =>
        string.Concat(n.ToString().OrderBy(c => c));

    public static int SumDigit(BigInteger n) =>
        n.ToString().Sum(c => (int)char.GetNumericValue(c));
}