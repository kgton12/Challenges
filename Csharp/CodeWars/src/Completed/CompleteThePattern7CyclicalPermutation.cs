using System.Text;

namespace CodeWars.Completed;

public class CompleteThePattern7CyclicalPermutation
{
    public static string Pattern(int n)
    {
        if (n <= 0)
            return string.Empty;

        var result = new StringBuilder();

        for (int i = 1; i <= n; i++)
            result.Append(CreateLine(n, i) + "\n");

        return result.ToString().Trim('\n');
    }

    private static string CreateLine(int finalNum, int valueActual)
    {
        var result = new StringBuilder();

        for (int i = 0; i < finalNum; i++)
        {
            result.Append(valueActual);

            if (valueActual == finalNum)
                valueActual = 1;
            else
                valueActual++;
        }

        return result.ToString();
    }
}