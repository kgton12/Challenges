namespace CodeWars.Completed;

public class AlphabetSymmetry
{
    public static List<int> Solve(List<string> arr) => [..arr
      .Select(w => w.ToLower().Where((letter, i) => char.ToLower(letter) - 'a' == i)
      .Count())];
}
