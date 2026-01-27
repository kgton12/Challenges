namespace CodeWars.Resolutions;

public static class SayMePleaseOperations
{
    public static string SayMeOperations(string stringNumbers)
    {
        int[] n = [.. stringNumbers.Split(' ').Select(x => Convert.ToInt32(x))];
        List<string> result = [];

        for (int i = 2; i < n.Length; i++)
        {
            if (n[i - 2] + n[i - 1] == n[i])
                result.Add("addition");
            else if (n[i - 2] - n[i - 1] == n[i])
                result.Add("subtraction");
            else if (n[i - 2] * n[i - 1] == n[i])
                result.Add("multiplication");
            else
                result.Add("division");
        }

        return string.Join(", ", result);
    }
}