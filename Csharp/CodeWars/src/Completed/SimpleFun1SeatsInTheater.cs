namespace CodeWars.Completed;

public class SimpleFun1SeatsInTheater
{
    public static int SeatsInTheater(int nCols, int nRows, int col, int row) =>
        (nRows - row) * (nCols - col + 1);
}
