using System.Text;

namespace CodeWars.Resolutions;

public class BinaryToTextAsciiConversion
{
    public static string BinaryToString(string binary)
    {
        byte[] bytesArr = [.. binary
                            .Chunk(8)
                            .Select(x => Convert.ToByte(string.Concat(x), 2))
                          ];

        return Encoding.ASCII.GetString(bytesArr);
    }
}