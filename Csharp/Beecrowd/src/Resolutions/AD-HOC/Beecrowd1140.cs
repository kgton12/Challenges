namespace BeeCrowd.src;

public class Beecrowd1140
{
    public static void FlowersBloomFromFrance()
    {
        while (true)
        {
            string input = Console.ReadLine() ?? string.Empty;

            if (input.Equals("*")) break;

            char firstLetter = char.ToLower(input[0]);
            string[] inputWords = input.Split(' ');

            Console.WriteLine(inputWords.All(a => char.ToLower(a[0]) == firstLetter) ? "Y" : "N");
        }
    }
}
