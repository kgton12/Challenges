namespace CodeWars.Resolutions;

public class WellOfIdeasEasyVersion
{
    public static string Well(string[] x) =>
        x.Count(x => x.Equals("good")) switch
        {
            >= 1 and <= 2 => "Publish!",
            > 2 => "I smell a series!",
            _ => "Fail!"
        };
}
