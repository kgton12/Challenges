namespace CodeWars.Completed;

public class MultiplicationTableClass
{
    public static int[,] MultiplicationTable(int size)
    {
        int[,] output = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                output[i, j] = (i + 1) * (j + 1);
            }
        }

        return output;
    }
}
