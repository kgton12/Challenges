namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1038
{
    public static void Snack()
    {
        string[] input = (Console.ReadLine() ?? string.Empty).Split(' ');
        int cod = Convert.ToInt32(input[0]);
        int qtd = Convert.ToInt32(input[1]);
        double[] val = [0.00, 4.00, 4.50, 5.00, 2.00, 1.50];

        Console.WriteLine($"Total: R$ {qtd * val[cod]:F2}");
    }
}
