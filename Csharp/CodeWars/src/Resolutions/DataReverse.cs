namespace CodeWars.Resolutions;

public class DataReverseClass
{
    public static int[] DataReverse(int[] data)
    {
        int byteCount = data.Length / 8;
        int[] result = new int[data.Length];

        for (int i = 0; i < byteCount; i++)
        {
            int sourceIndex = i * 8;
            int destIndex = (byteCount - 1 - i) * 8;

            Array.Copy(data, sourceIndex, result, destIndex, 8);
        }

        return result;
    }
}
