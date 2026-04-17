namespace CodeWars.Completed;

public class DiagonalsSum
{
    public static int SumDiagonals(int[,] matrix) =>
        Enumerable
            .Range(0, matrix.GetLength(0))
            .Sum(x => matrix[x, x] + matrix[x, (matrix.GetLength(0) - 1) - x]);
}
