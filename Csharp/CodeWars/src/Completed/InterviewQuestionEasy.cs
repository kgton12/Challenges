namespace CodeWars.Completed;

public class InterviewQuestionEasy
{
    public static string GetStrings(string city)
    {
        var lowerCity = city.ToLower().Replace(" ", "");
        var charCounts = lowerCity
            .GroupBy(c => c)
            .ToDictionary(g => g.Key, g => g.Count());

        return string.Join(",",
            lowerCity
                .Distinct()
                .Select(c => $"{c}:{new string('*', charCounts[c])}")
        );
    }
}
