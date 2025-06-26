namespace BeeCrowd.src.Resolutions.String;

public class Beecrowd2137
{
    public static void MrSeverinoSLibrary()
    {
        while (int.TryParse(Console.ReadLine() ?? string.Empty, out int N))
        {
            List<string> books = new List<string>();

            for (int i = 0; i < N; i++)
                books.Add(Console.ReadLine() ?? string.Empty);

            foreach (var item in books.OrderBy(Convert.ToInt32).ToArray())
                Console.WriteLine(item);
        }
    }
}
