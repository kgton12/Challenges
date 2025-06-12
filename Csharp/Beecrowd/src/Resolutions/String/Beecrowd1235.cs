namespace BeeCrowd.src.Resolutions.String;

public class Beecrowd1235
{
    public static void FromTheInsideOut()
    {
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string inputLine = Console.ReadLine() ?? string.Empty;
            int half = (int)Math.Ceiling(inputLine.Length / 2.0);

            string firstHalfWord = inputLine.Substring(0, half);
            string secondHalfWord = inputLine.Substring(half);

            var reversedFirstHalf = firstHalfWord.Reverse().ToArray();
            var reversedSecondHalf = secondHalfWord.Reverse().ToArray();

            var combinedReversedWords = reversedFirstHalf.Concat(reversedSecondHalf).ToArray();

            Console.WriteLine(string.Concat(combinedReversedWords));
        }
    }
}
