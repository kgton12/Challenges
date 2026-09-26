namespace CodeWars.Completed;

public class HiddenCubicNumbers
{
    public static string IsSumOfCubes(string s)
    {
        var numbers = string.Concat(
            s.Select(character => char.IsAsciiDigit(character) ? character : ' ')
        ).Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var result = new List<int>();

        foreach (var number in numbers)
        {
            foreach (var chunk in number.Chunk(3))
            {
                var value = int.Parse(string.Concat(chunk));
                var sum = chunk.Sum(character =>
                    Math.Pow(character - '0', 3));

                if (sum == value)
                    result.Add(value);
            }
        }

        return result.Count > 0
            ? $"{string.Join(" ", result)} {result.Sum()} Lucky"
            : "Unlucky";
    }
}