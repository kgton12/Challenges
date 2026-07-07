namespace CodeWars.Completed;

public class NumericalsOfAString
{
    public static string Numericals(string s)
    {
        Dictionary<char, int> score = [];

        return string.Concat(
            s.Select(actualChar =>
            {
                if (score.TryGetValue(actualChar, out int value))
                    score[actualChar] += 1;
                else
                    score.Add(actualChar, 1);

                return score[actualChar];
            })
        );
    }
}