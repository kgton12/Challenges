namespace CodeWars.Completed;

public class BingoCard
{
    private static readonly Random rd = new();
    public static string[] GetCard()
    {
        List<string> bingoCard = [];

        List<Tuple<int, int>> numberValids =
        [
            new Tuple<int, int>(1,15),
            new Tuple<int, int>(16,30),
            new Tuple<int, int>(31,45),
            new Tuple<int, int>(46,60),
            new Tuple<int, int>(61,75),
        ];

        char[] bingoLetters = ['B', 'I', 'N', 'G', 'O',];

        for (int i = 0; i < 5; i++)
            bingoCard.AddRange(CreateNumberForcard(numberValids[i], bingoLetters[i]));

        return [.. bingoCard];
    }

    public static List<string> CreateNumberForcard(Tuple<int, int> minMax, char letter)
    {
        HashSet<int> result = [];
        int countLoops = letter != 'N' ? 5 : 4;

        while (result.Count < countLoops)
        {
            result.Add(rd.Next(minMax.Item1, minMax.Item2));
        }
        return [.. result.Select(x => $"{letter}{x}")];
    }
}