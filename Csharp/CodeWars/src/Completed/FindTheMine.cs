namespace CodeWars.Completed;

public class FindTheMine
{
    public static Tuple<int, int> MineLocation(int[,] field)
    {
        for (int row = 0; row < field.GetLength(0); row++)
        {
            for (int col = 0; col < field.GetLength(1); col++)
            {
                if (field[row, col] == 1)
                    return Tuple.Create(row, col);
            }
        }
        return Tuple.Create(-1, -1);
    }
}