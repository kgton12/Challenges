namespace CodeWars.Completed;

public class ExesAndOhs
{
    public static bool XO(string input) =>
        input.ToLower().Count(x => x == 'x') == input.ToLower().Count(x => x == 'o');
}
