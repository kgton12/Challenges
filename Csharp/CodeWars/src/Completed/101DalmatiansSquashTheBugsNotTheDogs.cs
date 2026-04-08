namespace CodeWars.Completed;

public static class _101DalmatiansSquashTheBugsNotTheDogs
{
    public static string HowManyDalmatians(int n)
    {
        List<string> dogs =
        [
            "Hardly any",
            "More than a handful!",
            "Woah that's a lot of dogs!",
            "101 DALMATIONS!!!"
        ];

        return n switch
        {
            <= 10 => dogs[0],
            <= 50 => dogs[1],
            101 => dogs[3],
            _ => dogs[2]
        };
    }
}
