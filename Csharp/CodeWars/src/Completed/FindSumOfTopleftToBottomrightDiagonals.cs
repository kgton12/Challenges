namespace CodeWars.Completed;

public class FindSumOfTopleftToBottomrightDiagonals
{
    public static int DiagonalSum(int[,] matrix) =>
        Enumerable.Range(0, matrix.GetLength(0)).Sum(i => matrix[i, i]);
}
