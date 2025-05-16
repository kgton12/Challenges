namespace CodeWars.src.Resolutions;

public class DoYouSpeakEnglish
{
    public static bool SpeakEnglish(string sentence)
    {
        return sentence.Contains("english", StringComparison.CurrentCultureIgnoreCase);
    }
}

