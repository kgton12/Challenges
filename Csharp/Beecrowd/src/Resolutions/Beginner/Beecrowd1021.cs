namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1021
{
    public static void NotesAndCoins()
    {
        int intValue, hundred, fifty, fiftyRest, twenty, twentyRest, ten, tenRest, five, fiveRest, two, twoRest;

        int coins, one, oneRest, fiftyCent, twentyFiveCent, tenCent, fiveCent, oneCent;

        double value;

        value = Convert.ToDouble(Console.ReadLine());
        intValue = (int)value;
        value -= intValue;

        coins = (int)(value * 100 + 0.0001);

        hundred = intValue / 100;
        fifty = intValue % 100;
        fiftyRest = fifty / 50;
        twenty = fifty % 50;
        twentyRest = twenty / 20;
        ten = twenty % 20;
        tenRest = ten / 10;
        five = ten % 10;
        fiveRest = five / 5;
        two = five % 5;
        twoRest = two / 2;

        one = two % 2;
        oneRest = one / 1;

        Console.WriteLine($"NOTAS:");
        Console.WriteLine($"{hundred} nota(s) de R$ 100.00");
        Console.WriteLine($"{fiftyRest} nota(s) de R$ 50.00");
        Console.WriteLine($"{twentyRest} nota(s) de R$ 20.00");
        Console.WriteLine($"{tenRest} nota(s) de R$ 10.00");
        Console.WriteLine($"{fiveRest} nota(s) de R$ 5.00");
        Console.WriteLine($"{twoRest} nota(s) de R$ 2.00");

        fiftyCent = coins / 50;
        twentyFiveCent = (coins % 50) / 25;
        tenCent = (((coins % 50) % 25) / 10);
        fiveCent = ((((coins % 50) % 25) % 10) / 5);
        oneCent = ((((coins % 50) % 25) % 10) % 5) / 1;

        Console.WriteLine($"MOEDAS:");
        Console.WriteLine($"{oneRest} moeda(s) de R$ 1.00");
        Console.WriteLine($"{fiftyCent} moeda(s) de R$ 0.50");
        Console.WriteLine($"{twentyFiveCent} moeda(s) de R$ 0.25");
        Console.WriteLine($"{tenCent} moeda(s) de R$ 0.10");
        Console.WriteLine($"{fiveCent} moeda(s) de R$ 0.05");
        Console.WriteLine($"{oneCent} moeda(s) de R$ 0.01");
    }
}
