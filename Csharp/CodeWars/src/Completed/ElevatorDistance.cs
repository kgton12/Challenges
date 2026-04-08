namespace CodeWars.Completed;

public class ElevatorDistanceClass
{
    public static int ElevatorDistance(int[] array) => Enumerable.Range(0, array.Length - 1).Sum(i => Math.Abs(array[i] - array[i + 1]));
}
