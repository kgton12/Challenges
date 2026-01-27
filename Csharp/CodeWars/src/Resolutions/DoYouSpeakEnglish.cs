namespace CodeWars.Resolutions;

public class DoYouSpeakEnglish
{
    public static bool SpeakEnglish(string sentence)
    {
        return sentence.Contains("english", StringComparison.CurrentCultureIgnoreCase);
    }
}

