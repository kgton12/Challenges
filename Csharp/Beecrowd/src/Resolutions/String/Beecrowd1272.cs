namespace BeeCrowd.src.Resolutions.String;

public class Beecrowd1272
{
    public static void HiddenMessage()
    {
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string word = string.Concat(
                (Console.ReadLine() ?? string.Empty).Split(' ').Where(x => !string.IsNullOrEmpty(x)).Select(z => z[0]));
            Console.WriteLine(word);
        }
    }
}

