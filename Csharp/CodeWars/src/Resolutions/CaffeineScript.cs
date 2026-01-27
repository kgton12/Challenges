namespace CodeWars.Resolutions;

public class CaffeineScript
{
    public static string CaffeineBuzz(int n)
    {
        bool divisibleBy3 = n % 3 == 0;
        bool divisibleBy4 = n % 4 == 0;
        bool isEven = n % 2 == 0;

        if (!divisibleBy3)
            return "mocha_missing!";

        string result = divisibleBy4 ? "Coffee" : "Java";

        if (isEven)
            result += "Script";

        return result;
    }
}
