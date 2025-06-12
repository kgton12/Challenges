namespace CodeWars.src.Resolutions;

public class TheIfFunction
{
    public static void If(bool condition, Action func1, Action func2)
    {
        (condition ? func1 : func2)();
    }
}
