namespace CodeWars.Completed;

public class FirstNonRepeatingCharacter
{
    public static string FirstNonRepeatingLetter(string s)
    {
        return s.GroupBy(char.ToLower)
                .Where(gr => gr.Count() == 1)
                .Select(x => x.First().ToString())
                .DefaultIfEmpty("")
                .First();
    }
}