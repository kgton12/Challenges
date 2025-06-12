namespace BeeCrowd.src.Resolutions.String;

public class Beecrowd1120
{
    public static void ContractReview()
    {
        while (true)
        {
            string[] lineValue = (Console.ReadLine() ?? string.Empty).Split(" ");

            string digitToRemove = lineValue[0];
            string contractValue = lineValue[1];

            if (digitToRemove == "0" && contractValue == "0") break;

            string cleanedValue = contractValue.Replace(digitToRemove, string.Empty).TrimStart('0');

            Console.WriteLine(string.IsNullOrEmpty(cleanedValue) ? "0" : cleanedValue);
        }
    }
}
