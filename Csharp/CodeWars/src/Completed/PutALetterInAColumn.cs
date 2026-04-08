namespace CodeWars.Completed;

public class PutALetterInAColumn
{
    public static string BuildRowText(int index, char character) =>
        string
            .Concat("| | | | | | | | | |"
            .Select((v, i) => i + 1 == (index + 1) * 2 ? character : v));
}