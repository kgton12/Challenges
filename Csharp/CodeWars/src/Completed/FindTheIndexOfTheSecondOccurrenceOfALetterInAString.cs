namespace CodeWars.Completed;

public class FindTheIndexOfTheSecondOccurrenceOfALetterInAString
{
    public static int SecondSymbol(string str, char symbol)
    {
        var result = str
            .Select((ch, idx) => new { ch, idx })
            .Where(x => x.ch == symbol)
            .Skip(1)
            .FirstOrDefault();

        return result != null ? result.idx : -1;
    }
}
