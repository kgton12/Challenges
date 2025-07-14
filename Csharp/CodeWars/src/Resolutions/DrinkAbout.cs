namespace CodeWars.src.Resolutions;

public class DrinkAbout
{
    public static string PeopleWithAgeDrink(int old) =>
        old switch
        {
            < 14 => "drink toddy",
            < 18 => "drink coke",
            < 21 => "drink beer",
            _ => "drink whisky"
        };
}