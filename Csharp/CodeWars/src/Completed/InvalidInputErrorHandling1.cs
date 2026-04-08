namespace CodeWars.Completed;

public class InvalidInputErrorHandling1
{
    public static CounterClass GetCount(object word)
    {
        if (word is string)
        {
            string vowelsLetters = "aeiou";
            var s = (word.ToString() ?? string.Empty).ToLower().Where(char.IsLetter).ToArray();

            return new CounterClass(
                s.Count(vowelsLetters.Contains),
                s.Count(c => !vowelsLetters.Contains(c))
                );
        }
        else
            return new CounterClass(0, 0);
    }
}

public class CounterClass(int vowels, int consonants)
{
    public int Vowels { get; set; } = vowels;
    public int Consonants { get; set; } = consonants;
}