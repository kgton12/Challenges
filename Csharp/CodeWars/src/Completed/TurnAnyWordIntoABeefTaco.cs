namespace CodeWars.Completed;

public class TurnAnyWordIntoABeefTaco
{
    public static string[] Tacofy(string word)
    {
        Dictionary<char, string> menu = new()
        {
            {'a',"beef" },
            {'e',"beef" },
            {'i',"beef" },
            {'o',"beef" },
            {'u',"beef" },
            {'t',"tomato" },
            {'l',"lettuce" },
            {'c',"cheese" },
            {'g',"guacamole" },
            {'s',"salsa" }
        };
        List<string> taco = ["shell"];

        word.ToLower().ToList().ForEach(x =>
        {
            if (menu.TryGetValue(x, out string? value))
                taco.Add(value);
        });

        taco.Add("shell");
        return [.. taco];
    }
}