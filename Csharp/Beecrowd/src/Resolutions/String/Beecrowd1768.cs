namespace BeeCrowd.src.Resolutions.String;

public class Beecrowd1768
{
    public static void ChristmasTree()
    {
        while (true)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            if (N == 0) break;

            int space;
            char asterisk = '*';

            for (int i = 1; i <= N; i += 2)
            {
                space = (N - i) / 2;
                string lineValue = $"{new string(' ', space)}{new string(asterisk, i)}";
                Console.WriteLine(lineValue);
            }

            for (int i = 1; i <= 3; i += 2)
            {
                space = (N - i) / 2;
                string lineValue = $"{new string(' ', space)}{new string(asterisk, i)}";
                Console.WriteLine(lineValue);
            }

            Console.WriteLine("");
        }
    }
}
