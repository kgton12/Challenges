namespace CodeWars.Completed;

public class PositionsAverage
{
    public static double PosAverage(string s)
    {
        string[] arrNums = s.Split(',');

        int totalMatches = 0;
        int stringCount = arrNums.Length;
        int stringLength = arrNums[0].Trim().Length;

        for (int i = 0; i < stringCount; i++)
        {
            for (int j = i + 1; j < stringCount; j++)
            {
                totalMatches += ComparerIndexValue(
                    arrNums[i].Trim(),
                    arrNums[j].Trim());
            }
        }

        int pairCount = stringCount * (stringCount - 1) / 2;
        int totalPositions = pairCount * stringLength;

        return Math.Round((double)totalMatches / totalPositions * 100, 10);
    }

    private static int ComparerIndexValue(string s1, string s2)
    {
        return Enumerable
            .Range(0, s1.Length)
            .Count(index => s1[index] == s2[index]);
    }
}