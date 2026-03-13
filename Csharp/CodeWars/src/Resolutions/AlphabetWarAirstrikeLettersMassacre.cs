namespace CodeWars.Resolutions;

public static class AlphabetWarAirstrikeLettersMassacre
{
    public static string AlphabetWar(string fight)
    {
        List<char> fightList = [.. fight];

        Dictionary<char, int> rightSide = new()
        {
            {'m', 4},
            {'q', 3},
            {'d', 2},
            {'z', 1}
        };

        Dictionary<char, int> leftSide = new()
        {
            {'w', 4},
            {'p', 3},
            {'b', 2},
            {'s', 1}
        };


        var newList = fightList.Select((v, i) => new { Value = v, Index = i }).Where(x => x.Value.Equals('*')).ToList();

        foreach (var item in newList)
        {
            if (ExistsIndex(fightList, item.Index))
                fightList[item.Index] = '_';

            if (ExistsIndex(fightList, item.Index - 1))
                fightList[item.Index - 1] = '_';

            if (ExistsIndex(fightList, item.Index + 1))
                fightList[item.Index + 1] = '_';
        }

        int sum = fightList.Where(x => !x.Equals('_')).Sum(x =>
        {
            if (rightSide.TryGetValue(Convert.ToChar(x), out int right))
                return right;
            else if (leftSide.TryGetValue(Convert.ToChar(x), out int left))
                return left * -1;
            return 0;
        });

        if (sum > 0)
            return "Right side wins!";
        else if (sum < 0)
            return "Left side wins!";
        else
            return "Let's fight again!";
    }

    private static bool ExistsIndex<T>(this List<T> list, int index) =>
        index >= 0 && index < list.Count;
}