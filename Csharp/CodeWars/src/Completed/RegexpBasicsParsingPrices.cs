namespace CodeWars.Completed;

public static class RegexpBasicsParsingPrices
{
    public static int? ToCents(this string price)
    {
        bool startsWithDollar = price.StartsWith('$');
        bool twoDecimalDigits = price.Count(x => x.Equals('.')) == 1 && price.Split('.')[1].Length == 2;
        bool decimalNumber = !string.IsNullOrEmpty(price) && price.Length > 1;
        bool onlyNumbers = price.Where(x => !x.Equals('$') && !x.Equals('.')).All(char.IsNumber);

        return startsWithDollar && twoDecimalDigits && decimalNumber && onlyNumbers
            ? Convert.ToInt32(string.Concat(price.Where(char.IsNumber)))
            : null;
    }
}