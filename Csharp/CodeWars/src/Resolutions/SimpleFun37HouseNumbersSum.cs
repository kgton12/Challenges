namespace CodeWars.src.Resolutions;

public class SimpleFun37HouseNumbersSum
{
    public static int HouseNumbersSum(int[] inputArray) =>
        inputArray.TakeWhile(x => x != 0).Sum();
}
