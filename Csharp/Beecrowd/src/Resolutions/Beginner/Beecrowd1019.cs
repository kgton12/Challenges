namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1019
{
    public static void TimeConversion()
    {
        int inputSeconds = Convert.ToInt32(Console.ReadLine()); ;

        int hours = (int)(inputSeconds / (60 * 60));

        int minutes = (int)((inputSeconds - (hours * 60 * 60)) / 60);

        int seconds = (int)(inputSeconds - (hours * 60 * 60) - (minutes * 60));

        Console.WriteLine($"{hours}:{minutes}:{seconds}");
    }
}
