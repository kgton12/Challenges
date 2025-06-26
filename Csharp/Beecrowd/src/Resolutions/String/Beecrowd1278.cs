namespace BeeCrowd.src.Resolutions.String;

public class Beecrowd1278
{
    public static void JustifierII()
    {
        bool isFirst = true;
        while (true)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            if (N == 0) break;

            if (!isFirst)
                Console.WriteLine("");
            else
                isFirst = false;

            List<string> words = new List<string>();

            for (int i = 0; i < N; i++)
                words.Add(NormalizeString(Console.ReadLine() ?? string.Empty));

            foreach (var item in LeftPadStrings(words))
                Console.WriteLine(item);
        }
    }
    private static string NormalizeString(string str) => string.Join(" ", str.Split(' ').Where(x => x.Trim() != ""));

    private static List<string> LeftPadStrings(List<string> words)
    {
        int maxLength = words.Select(x => x.Length).Max();

        return words.Select(s => s.PadLeft(maxLength, ' ')).ToList();
    }
}
