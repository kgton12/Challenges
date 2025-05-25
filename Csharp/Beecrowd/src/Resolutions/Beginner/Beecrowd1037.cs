namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1037
{
    public static void Interval()
    {
        double inputValue = Convert.ToDouble(Console.ReadLine());
        string msg;

        if (inputValue >= 0 && inputValue <= 25)
            msg = "Intervalo [0,25]";
        else if (inputValue >= 25 && inputValue <= 50)
            msg = "Intervalo (25,50]";
        else if (inputValue >= 50 && inputValue <= 75)
            msg = "Intervalo (50,75]";
        else if (inputValue >= 75 && inputValue <= 100)
            msg = "Intervalo (75,100]";
        else
            msg = "Fora de intervalo";

        Console.WriteLine(msg);
    }
}
