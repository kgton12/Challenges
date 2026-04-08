namespace CodeWars.Completed;

public class BandNameGeneratorClass
{
    public static string BandNameGenerator(string str)
    {
        string formattedName = string.Concat(str.Select((value, i) => i == 0 ? char.ToUpper(value) : value));

        if (str.First() == str.Last())
            return $"{formattedName}{string.Concat(str.Skip(1))}";
        else
            return $"The {formattedName}";
    }
}
