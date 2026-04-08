namespace CodeWars.Completed;

public static class TribonacciSequence
{
    public static double[] Tribonacci(double[] signature, int n)
    {
        List<double> output = [.. signature, signature.Sum()];

        for (int i = 3; i < n - 1; i++)
            output.Add(output[i] + output[i - 1] + output[i - 2]);

        return [.. output.Take(n)];
    }
}
