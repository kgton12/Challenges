namespace CodeWars.Resolutions;

public class By3OrNotBy3ThatIsTheQuestion
{
    public static bool DivisibleByThree(string n) => n.Sum(x => x) % 3 == 0;
}
