namespace CodeWars.Resolutions;

public class SuzukiNeedsHelpLiningUpHisStudents
{
    public static String[] LineupStudents(String str)
    {
        return [.. str
            .Split(' ')
            .OrderByDescending(x => x.Length)
            .ThenByDescending(p => p)
         ];
    }
}
