namespace CodeWars.Resolutions;

public static class IsTheStringUppercase
{
    public static bool IsUpperCase(this string text) =>
        text.Equals(text.ToUpper());
}
