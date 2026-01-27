namespace CodeWars.Resolutions;

public class DidSheSayHallo
{
    public static bool ValidateHello(string greetings)
    {
        string[] hello = ["hello", "ciao", "salut", "hallo", "hola", "ahoj", "czesc"];

        foreach (string word in hello)
            if (greetings.Contains(word, StringComparison.CurrentCultureIgnoreCase))
                return true;

        return false;
    }
}
