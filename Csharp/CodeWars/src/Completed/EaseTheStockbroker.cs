using System.Globalization;

namespace CodeWars.Completed;

public class EaseTheStockbroker
{
    public static String BalanceStatements(String lst)
    {
        string result;
        string[] dataLines = lst.Split(',');
        decimal buy = 0M;
        decimal sell = 0M;
        List<string> badlyFormed = [];

        foreach (var item in dataLines)
        {
            string[] values = item.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            if (values.Length != 4)
            {
                string str = item.Replace(" ", "");

                if (str.Length > 0)
                    badlyFormed.Add(item);
                continue;
            }

            Stockbroker stockBroker = new(values[0], values[1], values[2], values[3]);

            if (stockBroker.IsValidStockBroker)
            {
                if (stockBroker.Options.Equals('S'))
                    sell += stockBroker.CalculatedAmount;
                else
                    buy += stockBroker.CalculatedAmount;
            }
            else
            {
                badlyFormed.Add(item);
            }
        }

        result = $"Buy: {(int)Math.Round(buy)} Sell: {(int)Math.Round(sell)}";

        if (badlyFormed.Count > 0)
            result += $"; Badly formed {badlyFormed.Count}: " + string.Join(" ;", badlyFormed.Select(x => x.Trim())) + " ;";

        return result;
    }

    private static bool NameIsValid(string name)
    {
        return name.All(c => !char.IsLetter(c) || !c.Equals('.'));
    }

    private static bool QuantityIsValid(string quantity)
    {
        bool isConversionPossible = int.TryParse(quantity, out int result);

        return isConversionPossible && result.ToString().Equals(quantity);
    }

    private static bool AmountIsValid(string amount)
    {
        bool valueIsDecimal = decimal.TryParse(amount, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal result);

        return valueIsDecimal && amount.Contains('.');
    }

    private static bool OptionsIsValid(string options)
    {
        return "SB".Contains(options) && options.Length == 1;
    }

    private class Stockbroker
    {
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public char Options { get; set; }
        public bool IsValidStockBroker = true;
        public decimal CalculatedAmount => Quantity * Amount;

        public Stockbroker(string name, string quantity, string amount, string options)
        {
            if (NameIsValid(name) && QuantityIsValid(quantity) && AmountIsValid(amount) && OptionsIsValid(options))
            {
                Name = name;
                Quantity = int.Parse(quantity);
                Amount = decimal.Parse(amount, CultureInfo.InvariantCulture);
                Options = char.Parse(options);
            }
            else
                IsValidStockBroker = false;
        }
    }
}