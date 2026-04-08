namespace CodeWars.Completed;

public class Compare2DigitNumbers
{
    public static string Compare(int a, int b)
    {
        var aString = a.ToString().ToList();
        int quantity = 0;

        b.ToString().ToList().ForEach(x =>
        {
            if (aString.Remove(x))
                quantity++;
        });

        return $"{quantity / 2.0 * 100}%";
    }
}
