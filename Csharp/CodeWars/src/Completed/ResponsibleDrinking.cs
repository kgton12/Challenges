namespace CodeWars.Completed;

public static class ResponsibleDrinking
{
    public static string Hydrate(string drinkString)
    {
        int result = (int)drinkString.Where(char.IsDigit).Sum(char.GetNumericValue);

        return result != 1 ?
            $"{result} glasses of water" :
            $"1 glass of water";
    }
}
