namespace CodeWars.Completed;

public class CalculatorAdditionAndSpacesPart1
{
    public static int Calculate(string str) =>
        str
        .Replace(" ", "")
        .Split('+')
        .Sum(Convert.ToInt32);
}
//return (int) new DataTable().Compute(str.Replace(" ", ""), "");