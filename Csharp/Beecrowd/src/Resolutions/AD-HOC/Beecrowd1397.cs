namespace BeeCrowd.src;

public class Beecrowd1397
{
    public static void BiggestGame()
    {
        while (true)
        {
            int i = Convert.ToInt32(Console.ReadLine());

            if (i == 0) break;

            int pointsPlayer1 = 0;
            int pointsPlayer2 = 0;

            for (int j = 0; j < i; j++)
            {
                string[] lineValues = (Console.ReadLine() ?? string.Empty).Split(' ');

                int player1Input = Convert.ToInt32(lineValues[0]);
                int player2Input = Convert.ToInt32(lineValues[1]);

                if (player1Input > player2Input)
                    pointsPlayer1++;
                else if (player1Input < player2Input)
                    pointsPlayer2++;
            }

            Console.WriteLine($"{pointsPlayer1} {pointsPlayer2}");
        }
    }
}
