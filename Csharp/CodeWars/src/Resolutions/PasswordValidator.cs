namespace CodeWars.Resolutions;

public class PasswordValidator
{
    public static bool Password(string st)
    {
        return st.Length >= 8 &&
               st.Any(char.IsUpper) &&
               st.Any(char.IsLower) &&
               st.Any(char.IsDigit);
    }
}
