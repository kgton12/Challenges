namespace BeeCrowd.src.Resolutions.String;

public static class Beecrowd2356
{
    public static void BacteriaI()
    {
        while (true)
        {
            string D = (Console.ReadLine() ?? string.Empty).Trim();
            string S = (Console.ReadLine() ?? string.Empty).Trim();

            if (D == "") break;

            Console.WriteLine(D.Contains(S) ? "Resistente" : "Nao resistente");
        }
    }
}
