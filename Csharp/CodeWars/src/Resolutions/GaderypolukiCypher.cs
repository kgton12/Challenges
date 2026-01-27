using System.Text;

namespace CodeWars.Resolutions;

public class GaderypolukiCypher
{
    private static readonly List<char> encodeCharArray = ['a', 'e', 'y', 'o', 'u', 'i', 'A', 'E', 'Y', 'O', 'U', 'I', 'g', 'd', 'r', 'p', 'l', 'k', 'G', 'D', 'R', 'P', 'L', 'K'];
    private static readonly List<char> decodeCharArray = ['g', 'd', 'r', 'p', 'l', 'k', 'G', 'D', 'R', 'P', 'L', 'K', 'a', 'e', 'y', 'o', 'u', 'i', 'A', 'E', 'Y', 'O', 'U', 'I'];

    public static string Encode(string str) =>
         StringProcess(str);

    public static string Decode(string str) =>
         StringProcess(str);

    private static string StringProcess(string str)
    {
        var result = new StringBuilder();

        foreach (var item in str)
        {
            int indexFound = encodeCharArray.IndexOf(item);
            result.Append(indexFound == -1 ? item : decodeCharArray[indexFound]);
        }

        return result.ToString();
    }
}