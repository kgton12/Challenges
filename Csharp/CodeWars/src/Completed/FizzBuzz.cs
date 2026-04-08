namespace CodeWars.Completed;

public class FizzBuzz
{
    public static string[] GetFizzBuzzArray(int n) =>
        [.. Enumerable.Range(1, n).Select(x =>
            x % 15 == 0 ? "FizzBuzz"
            : x % 3 == 0 ? "Fizz"
            : x % 5 == 0 ? "Buzz"
            : x.ToString()
        )];
}
