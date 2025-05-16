namespace CodeWars.src.Resolutions;

public class ForUFCFansTotalBeginnersConorMcGregorvsGeorgeSaintPierre
{
    public static string Quote(string fighter)
    {
        return fighter.Equals("George Saint Pierre", StringComparison.CurrentCultureIgnoreCase)
            ? "I am not impressed by your performance."
            : "I'd like to take this chance to apologize.. To absolutely NOBODY!";
    }
}

