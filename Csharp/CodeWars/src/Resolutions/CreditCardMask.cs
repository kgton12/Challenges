namespace CodeWars.src.Resolutions;

public class CreditCardMask
{
    public static string Maskify(string cc) =>
        string.Concat(
            cc.Select((x, i) => i >= cc.Length - 4 ? x : '#')
        );
}
