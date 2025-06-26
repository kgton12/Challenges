namespace BeeCrowd.src.Resolutions.String;

public class Beecrowd2651
{
    public static void BoladoLink()
    {
        string lineValue = Console.ReadLine() ?? string.Empty;

        bool bolado = lineValue.ToLower().Contains("zelda");

        Console.WriteLine(bolado ? "Link Bolado" : "Link Tranquilo");
    }
}

