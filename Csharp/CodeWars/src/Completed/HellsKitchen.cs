namespace CodeWars.Completed;

public class HellsKitchen
{
    public static string Gordon(string a) =>
        string.Join(" ", a.Split(' ').Select(GordonString));

    private static string GordonString(string word) =>
        string.Concat(
            word
            .Select(x => "eiou".Contains(char.ToLower(x)) ? '*' : char.ToLower(x) == 'a' ? '@' : char.ToUpper(x))
        ) + "!!!!";
}