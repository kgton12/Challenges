namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1065
{
    public static void PairsBetweenFiveNumbers()
    {
        int[] linha = new int[5];
        int count = 0;

        linha[0] = Convert.ToInt32(Console.ReadLine());
        linha[1] = Convert.ToInt32(Console.ReadLine());
        linha[2] = Convert.ToInt32(Console.ReadLine());
        linha[3] = Convert.ToInt32(Console.ReadLine());
        linha[4] = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < linha.Length; i++)
        {
            if (linha[i] % 2 == 0)
                count++;
        }

        Console.WriteLine($"{count} valores pares");
    }
}
