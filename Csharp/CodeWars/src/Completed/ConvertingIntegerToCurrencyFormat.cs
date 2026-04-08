namespace CodeWars.Completed;

public class ConvertingIntegerToCurrencyFormat
{
    public static string ToCurrency(int price) =>
        string.Concat(
            price
            .ToString()
            .Reverse()
            .Select((x, i) => i % 3 == 0 && i != 0 ? $"{x}," : x.ToString())
            .Reverse()
        );
}