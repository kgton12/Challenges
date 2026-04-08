namespace CodeWars.Completed;

public static class MeetingClass
{
    public static string Meeting(string s)
    {
        return string.Concat(
            s.ToUpper()
            .Split(';')
            .Select(x =>
                {
                    string[] valueNames = x.Split(':');
                    return new { Name = valueNames[0], LastName = valueNames[1] };
                })
            .OrderBy(x => x.LastName)
            .ThenBy(x => x.Name)
            .Select(x => $"({x.LastName}, {x.Name})"));
    }
}
