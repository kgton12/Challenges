namespace CodeWars.Completed;

public class JennysSecretMessage
{
    public static string Greet(string name)
    {
        if (name.Equals("Johnny"))
            return "Hello, my love!";

        return $"Hello, {name}!";
    }
}
