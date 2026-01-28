namespace CodeWars.Resolutions;

public static class LetterboxPaintSquad
{
    public static IEnumerable<int> PaintLetterBoxes(int start, int end)
    {
        int[] digitCounts = new int[10];

        for (int i = start; i <= end; i++)
        {
            foreach (char c in i.ToString())
            {
                int digit = c - '0';
                digitCounts[digit]++;
            }
        }

        return digitCounts;
    }
}
