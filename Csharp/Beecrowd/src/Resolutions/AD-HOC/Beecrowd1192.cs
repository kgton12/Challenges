namespace BeeCrowd.src;

public class Beecrowd1192
{
    public static void PaulasMathematicalGame()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] lineValues = (Console.ReadLine() ?? string.Empty).ToCharArray().Select(c => c.ToString()).ToArray();

            int A = Convert.ToInt32(lineValues[0]);
            string letter = lineValues[1];
            int B = Convert.ToInt32(lineValues[2]);

            if (A == B)
                Console.WriteLine(B * A);
            else if (letter.Equals(letter.ToUpper()))
                Console.WriteLine(B - A);
            else
                Console.WriteLine(A + B);
        }
    }
}
