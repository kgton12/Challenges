namespace CodeWars.Completed;

public class MostDigits
{
    public static int FindLongest(int[] number) =>
        number.Aggregate(0, (value, acc) => acc.ToString().Length > value.ToString().Length ? acc : value);
}
