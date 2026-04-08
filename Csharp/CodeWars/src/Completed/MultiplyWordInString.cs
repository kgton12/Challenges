namespace CodeWars.Completed;

public class MultiplyWordInString
{
    public static string ModifyMultiply(string str, int loc, int num) =>
        string.Join("-", Enumerable.Repeat(str.Split(" ")[loc], num));
}
