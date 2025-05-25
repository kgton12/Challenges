namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1047
{
    public static void GameTimeWithMinutes()
    {
        int A, B, C, D;
        string[] inputLine = (Console.ReadLine() ?? string.Empty).Split(' ');

        A = Convert.ToInt32(inputLine[0]);
        B = Convert.ToInt32(inputLine[1]);
        C = Convert.ToInt32(inputLine[2]);
        D = Convert.ToInt32(inputLine[3]);

        var hour1 = new TimeSpan(A, B, 00);
        var hour2 = new TimeSpan(C, D, 00);

        TimeSpan result = new(00, 00, 00);

        if (hour1 > hour2)
        {
            TimeSpan fullDay = new(24, 00, 00);
            result = fullDay - hour1;
            result += hour2;
            Console.WriteLine($"O JOGO DUROU {result.Hours} HORA(S) E {result.Minutes} MINUTO(S)");
        }
        else if (hour1 < hour2)
        {
            result = hour2 - hour1;
            Console.WriteLine($"O JOGO DUROU {result.Hours} HORA(S) E {result.Minutes} MINUTO(S)");
        }
        else if (hour1 == hour2)
            Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
    }
}
