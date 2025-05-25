namespace BeeCrowd.src;

public class Beecrowd1467
{
    public static void ZeroOrOne()
    {
        while (true)
        {
            string input = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(input))
                break;

            string[] parts = input.Split(' ');
            if (parts.Length < 3)
                break;

            int A = Convert.ToInt32(parts[0]);
            int B = Convert.ToInt32(parts[1]);
            int C = Convert.ToInt32(parts[2]);

            if (A != B && A != C)
                Console.WriteLine("A");
            else if (B != A && B != C)
                Console.WriteLine("B");
            else if (C != A && C != B)
                Console.WriteLine("C");
            else
                Console.WriteLine("*");
        }
    }
}
