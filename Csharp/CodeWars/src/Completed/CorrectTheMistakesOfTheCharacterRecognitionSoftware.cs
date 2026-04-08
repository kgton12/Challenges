namespace CodeWars.Completed;

public class CorrectTheMistakesOfTheCharacterRecognitionSoftware
{
    public static string Correct(string text) =>
        text
        .Replace("5", "S")
        .Replace("0", "O")
        .Replace("1", "I");
}
