namespace CodeWars.Completed;

public class WillYouMakeIt
{
    public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft) =>
        mpg * fuelLeft >= distanceToPump;
}
