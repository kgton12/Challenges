namespace CodeWars.Completed;

public class BowlingPinsClass
{
    public static string BowlingPins(int[] arr)
    {
        var pins = Enumerable.Range(1, 10)
            .Select(x => arr.Contains(x) ? " " : "I")
            .ToArray();

        return $"{pins[6]} {pins[7]} {pins[8]} {pins[9]}\n {pins[3]} {pins[4]} {pins[5]} \n  {pins[1]} {pins[2]}  \n   {pins[0]}   ";
    }
}
