namespace CodeWars.Completed;

public class Noobcode03CheckTheseLettersSeeIfLettersInString2ArePresentInString1
{
    public static bool LetterCheck(string[] arr) =>
        arr[1].All(x => arr[0].Contains(x, StringComparison.OrdinalIgnoreCase));
}
