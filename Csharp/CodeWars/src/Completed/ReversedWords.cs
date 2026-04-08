namespace CodeWars.Completed;

public class ReversedWords
{
    public static string ReverseWords(string str) =>
        string.Join(" ",
            str
            .Split(" ")
            .Reverse()
        );
}
