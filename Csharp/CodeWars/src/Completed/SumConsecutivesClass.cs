namespace CodeWars.Completed;

public class SumConsecutivesClass
{
    public static List<int> SumConsecutives(List<int> s)
    {
        List<int> result = [];
        int consecutiveSum = 0;

        for (int i = 0; i < s.Count; i++)
        {
            if (i < s.Count - 1 && s[i] == s[i + 1])
                consecutiveSum += s[i];
            else
            {
                result.Add(consecutiveSum + s[i]);
                consecutiveSum = 0;
            }
        }

        return result;
    }
}