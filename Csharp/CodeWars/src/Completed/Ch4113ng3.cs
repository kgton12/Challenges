namespace CodeWars.Completed;

public class Ch4113ng3
{
    public static string Nerdify(string str)
    {
        var letters = new Dictionary<char, char>
        {
            {'a', '4'},
            {'A', '4'},
            {'e', '3'},
            {'E', '3'},
            {'l', '1'}
        };

        return str is null
            ? throw new ArgumentNullException()
            : string.Concat(str.Select(x => letters.TryGetValue(x, out char value) ? value : x));
    }
}
