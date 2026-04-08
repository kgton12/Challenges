namespace CodeWars.Completed;

public static class SimpleFun37HouseNumbersSum
{
    public static int HouseNumbersSum(int[] inputArray) =>
        inputArray.TakeWhile(x => x != 0).Sum();
}
