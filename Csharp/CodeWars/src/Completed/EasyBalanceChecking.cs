using System.Globalization;

namespace CodeWars.Completed;

public static class EasyBalanceChecking
{
    public static string Balance(string book)
    {
        var lines = book
            .Split(["\r\n", "\n", "\r"], StringSplitOptions.None)
            .Select(line => new string([.. line.Where(c => char.IsLetterOrDigit(c) || c == '.' || c == ' ')]).Trim())
            .Where(line => line.Length > 0)
            .ToArray();

        var balance = decimal.Parse(
            lines[0], NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
        var originalBalance = balance;
        var totalExpense = 0m;
        var report = new List<string>
        {
            $"Original Balance: {Format(originalBalance)}"
        };

        double averageExpenseTotal = 0;

        foreach (var line in lines.Skip(1))
        {
            var fields = line.Split([' '], StringSplitOptions.RemoveEmptyEntries);
            if (fields.Length < 3)
                throw new FormatException($"Invalid check entry: {line}");

            var checkNumber = fields[0];
            var category = string.Join(" ", fields.Skip(1).Take(fields.Length - 2));
            var expense = decimal.Parse(
                fields[^1],
                NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture);

            totalExpense += expense;
            balance = decimal.Round(balance - expense, 2, MidpointRounding.AwayFromZero);

            report.Add($"{checkNumber} {category} {Format(expense)} Balance {Format(balance)}");
            averageExpenseTotal += (double)expense;
        }

        var count = lines.Length - 1;
        totalExpense = decimal.Round(totalExpense, 2, MidpointRounding.AwayFromZero);

        var averageExpense = count == 0
            ? 0d
            : averageExpenseTotal / count;

        report.Add($"Total expense  {Format(totalExpense)}");
        report.Add($"Average expense  {averageExpense.ToString("F2", CultureInfo.InvariantCulture)}");

        return string.Join("\n", report);
    }

    private static string Format(decimal value) =>
        value.ToString("F2", CultureInfo.InvariantCulture);
}