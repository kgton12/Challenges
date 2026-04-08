namespace CodeWars.Completed;

public class OddOrEvenClass
{
    public static string OddOrEven(int[] array) =>
        array.Sum() % 2 == 0 ? "even" : "odd";
}
