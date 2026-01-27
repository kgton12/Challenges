namespace CodeWars.Resolutions;

public class CategorizeNewMember
{
    public static IEnumerable<string> OpenOrSenior(int[][] data) =>
        data.Select(member => member[0] >= 55 && member[1] > 7 ? "Senior" : "Open");
}
