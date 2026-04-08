namespace CodeWars.Completed;

public class TurkishNumbers099
{
    private static readonly Dictionary<int, string> turkishNumbers = new()
    {
            { 0, "sıfır" },
            { 1, "bir" },
            { 2, "iki" },
            { 3, "üç" },
            { 4, "dört" },
            { 5, "beş" },
            { 6, "altı" },
            { 7, "yedi" },
            { 8, "sekiz" },
            { 9, "dokuz" },
            { 10, "on" },
            { 20, "yirmi" },
            { 30, "otuz" },
            { 40, "kırk" },
            { 50, "elli" },
            { 60, "altmış" },
            { 70, "yetmiş" },
            { 80, "seksen" },
            { 90, "doksan" }
        };
    public static string GetTurkishNumber(int num)
    {
        int val1 = num % 10;
        int val2 = (num / 10) * 10;

        return num <= 10 || num % 10 == 0
            ? turkishNumbers[num]
            : $"{turkishNumbers[val2]} {turkishNumbers[val1]}";
    }
}
