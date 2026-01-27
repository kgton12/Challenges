namespace CodeWars.Resolutions;

public class CreditCardIssuerChecking
{
    public static string GetIsSuer(long number)
    {
        string str = number.ToString();

        if ((str[..2] == "34" || str[..2] == "37") && str.Length == 15)
            return "AMEX";
        else if (str[..4] == "6011" && str.Length == 16)
            return "Discover";
        else if (new string[] { "51", "52", "53", "54", "55" }.Contains(str[..2]) && str.Length == 16)
            return "Mastercard";
        else if (str[..1] == "4" && (str.Length == 13 || str.Length == 16))
            return "VISA";
        else return "Unknown";
    }
}
