namespace CodeWars.Completed;

public class RiddleMadeCodeTwoSpies
{
    public static string GetAnswer(string challenge)
    {
        return challenge switch
        {
            "1" => "3",
            "2" => "3",
            "3" => "5",
            "4" => "4",
            "5" => "4",
            "6" => "3",
            "7" => "5",
            "8" => "5",
            "9" => "4",
            "10" => "3",
            "11" => "6",
            "12" => "6",
            "13" => "8",
            "14" => "8",
            "15" => "7",
            _ => throw new ArgumentException("Unexpected input", nameof(challenge))
        };
    }
}
