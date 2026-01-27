namespace CodeWars.Resolutions;

public class LeonardoDicaprioAndOscars
{
    public static string Leo(int oscar)
    {
        return oscar switch
        {
            88 => "Leo finally won the oscar! Leo is happy",
            86 => "Not even for Wolf of wallstreet?!",
            < 88 => "When will you give Leo an Oscar?",
            > 88 => "Leo got one already!"
        };
    }
}
