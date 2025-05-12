namespace CodeWars.Resolutions;

public class SleighAuthentication
{
    public static bool Authenticate(string name, string password)
    {
        const string correctLogin = "Santa Claus";
        const string correctPassword = "Ho Ho Ho!";

        return name == correctLogin && password == correctPassword;
    }
}

