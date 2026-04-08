namespace CodeWars.Completed;

public class HelpSuzukiRakeHisGarden
{
    private static readonly string[] sourceArray = ["rock", "gravel"];

    public static string RakeGarden(string garden) =>
        string.Join(" ",
            garden
            .Split(' ')
            .Select(x => sourceArray.Contains(x) ? x : "gravel")
        );
}
