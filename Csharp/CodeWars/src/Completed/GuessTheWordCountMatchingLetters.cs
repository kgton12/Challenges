namespace CodeWars.Completed;

public class GuessTheWordCountMatchingLetters
{
    public static int CountCorrectCharacters(string correctWord, string guess) =>
        correctWord.Length != guess.Length
            ? throw new InvalidOperationException()
            : correctWord.Select((v, i) => v.Equals(guess[i]) ? 1 : 0).Sum();

}