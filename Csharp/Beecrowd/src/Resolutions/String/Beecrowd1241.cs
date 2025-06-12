namespace BeeCrowd.src.Resolutions.String;

public class Beecrowd1241
{
    public static void FitsOrNotII()
    {
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string[] lineValue = (Console.ReadLine() ?? string.Empty).Trim().Split(' ');

            string original = lineValue[0];
            string suffix = lineValue[1];

            if (original.EndsWith(suffix))
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");
        }
    }
}
