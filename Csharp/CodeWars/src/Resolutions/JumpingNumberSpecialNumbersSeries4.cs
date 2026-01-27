namespace CodeWars.Resolutions;

public class JumpingNumberSpecialNumbersSeries4
{
    public static string JumpingNumber(int number) =>
        Enumerable
        .Range(1, number.ToString().Length - 1)
        .All(x => Math.Abs(number.ToString()[x] - number.ToString()[x - 1]) == 1)
        ? "Jumping!!"
        : "Not!!";
}
