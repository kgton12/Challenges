namespace CodeWars.Completed;

public class LowercaseStringsInArray
{
    public static object[] ArrayLowerCase(object[] arr)
    {
        return [.. arr.Select(x =>
        {
            if (!int.TryParse(x.ToString(), out int _))
                return (x.ToString()??string.Empty).ToLower();
            else
                return x;
        })];
    }
}
