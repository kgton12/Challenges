namespace CodeWars.src.Resolutions;

public class InvalidInputErrorHandling1
{
    public static Counter GetCount(object word)
    {
        if (word is string)
        {
            string vowelsLetters = "aeiou";
            var s = (word.ToString() ?? string.Empty).ToLower().Where(char.IsLetter).ToArray();

            return new Counter(
                s.Count(vowelsLetters.Contains),
                s.Count(c => !vowelsLetters.Contains(c))
                );
        }
        else
            return new Counter(0, 0);
    }
}

public class Counter(int vowels, int consonants)
{
    public int Vowels { get; set; } = vowels;
    public int Consonants { get; set; } = consonants;
}