using System.Numerics;

namespace CodeWars.Completed;

public class SumConsecutiveSum
{
    public static int ConsecutiveSum(BigInteger[] arr)
    {
        List<BigInteger> distinctNumbers = [.. arr.Distinct().OrderBy(x => x)];
        HashSet<BigInteger> result = [];
        BigInteger sum = BigInteger.Zero;

        for (int i = 0; i < distinctNumbers.Count - 1; i++)
        {
            if (distinctNumbers[i + 1] - distinctNumbers[i] == 1)
            {
                result.Add(distinctNumbers[i]);
                result.Add(distinctNumbers[i + 1]);
            }
        }

        foreach (var item in result)
            sum += item;

        return (int)sum.ToString().Sum(char.GetNumericValue);
    }
}