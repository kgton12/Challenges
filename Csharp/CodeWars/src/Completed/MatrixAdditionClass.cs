namespace CodeWars.Completed;

public class MatrixAdditionClass
{
    public static int[][] MatrixAddition(int[][] a, int[][] b)
    {
        for (int i = 0; i < a[0].Length; i++)
        {
            for (int j = 0; j < a[0].Length; j++)
            {
                a[i][j] += b[i][j];
            }
        }

        return a;
    }
}