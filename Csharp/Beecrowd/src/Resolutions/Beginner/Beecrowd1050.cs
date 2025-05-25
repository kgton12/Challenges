

namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1050
{
    public static void DDD()
    {
        var dddMap = new Dictionary<string, string>
        {
            { "61", "Brasilia" },
            { "71", "Salvador" },
            { "11", "Sao Paulo" },
            { "21", "Rio de Janeiro" },
            { "32", "Juiz de Fora" },
            { "19", "Campinas" },
            { "27", "Vitoria" },
            { "31", "Belo Horizonte" }
        };

        string ddd = Console.ReadLine() ?? string.Empty;

        if (dddMap.TryGetValue(ddd, out var city))
            Console.WriteLine(city);
        else
            Console.WriteLine("DDD nao cadastrado");
    }
}
