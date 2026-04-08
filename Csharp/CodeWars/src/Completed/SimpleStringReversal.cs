namespace CodeWars.Completed;

public class SimpleStringReversal
{
    public static String Solve(String s)
    {
        string invertedWord = string.Concat(s.Replace(" ", string.Empty).Reverse());
        int[] spaces = [.. s.Select((v, i) => new { Key = v, Index = i }).Where(x => x.Key == ' ').Select(x => x.Index)];
        List<char> result = [];
        int i = 0;

        if (spaces.Length == 0) return invertedWord;

        foreach (var item in invertedWord)
        {
            if (spaces.Contains(i))
            {
                result.Add(' ');
                i++;
            }

            result.Add(item);

            i++;
        }

        return string.Concat(result);
    }
}