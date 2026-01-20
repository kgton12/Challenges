namespace CodeWars.src.Resolutions;

public class IsValidIdentifier
{
    public static bool IsValid(String idn)
    {
        if (string.IsNullOrEmpty(idn))
            return false;

        char first = idn[0];
        if (!(char.IsLetter(first) || first == '_' || first == '$'))
            return false;

        for (int i = 1; i < idn.Length; i++)
        {
            char c = idn[i];
            if (!(char.IsLetterOrDigit(c) || c == '_' || c == '$'))
                return false;
        }

        return true;
    }
}