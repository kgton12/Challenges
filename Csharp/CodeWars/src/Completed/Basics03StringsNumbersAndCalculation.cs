using System.Data;
using System.Text.RegularExpressions;

namespace CodeWars.Completed;

public class Basics03StringsNumbersAndCalculation
{
    public static string CalculateString(string calcIt)
    {
        string expression = Regex.Replace(calcIt, @"[^\d*/+-.]+", "");

        double result = Convert.ToDouble(new DataTable().Compute(expression, null));

        return Math.Round(result).ToString();
    }
}
