namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1018
{
    public static void Ballots()
    {
        int value = Convert.ToInt32(Console.ReadLine());

        int change, hundred, fifty, twenty, ten, five, two;

        change = value;

        hundred = change / 100;

        change -= (hundred * 100);

        fifty = change / 50;

        change -= (fifty * 50);

        twenty = change / 20;

        change -= (twenty * 20);

        ten = change / 10;

        change -= (ten * 10);

        five = change / 5;

        change -= (five * 5);

        two = change / 2;

        change -= (two * 2);

        Console.WriteLine($"{value}");
        Console.WriteLine($"{hundred} nota(s) de R$ 100,00");
        Console.WriteLine($"{fifty} nota(s) de R$ 50,00");
        Console.WriteLine($"{twenty} nota(s) de R$ 20,00");
        Console.WriteLine($"{ten} nota(s) de R$ 10,00");
        Console.WriteLine($"{five} nota(s) de R$ 5,00");
        Console.WriteLine($"{two} nota(s) de R$ 2,00");
        Console.WriteLine($"{change} nota(s) de R$ 1,00");
    }
}
