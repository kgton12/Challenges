namespace BeeCrowd.src.Resolutions.String;

public class Beecrowd1273
{
    public static void Justifier()
    {
        bool isFirst = true;
        while (true)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            if (N == 0) break;

            if (!isFirst) Console.WriteLine("");
            else isFirst = false;

            string[] words = new string[N];

            for (int i = 0; i < N; i++)
                words[i] = Console.ReadLine() ?? string.Empty;

            int biggerWordSize = words.OrderByDescending(x => x.Length).First().Length;

            foreach (var word in words)
                Console.WriteLine(word.PadLeft(biggerWordSize, ' '));
        }
    }
}
