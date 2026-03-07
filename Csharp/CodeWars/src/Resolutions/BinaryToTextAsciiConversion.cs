namespace CodeWars.Resolutions;

public class BinaryToTextAsciiConversion
{
    public static string BinaryToString(string binary)
    {
        if (string.IsNullOrWhiteSpace(binary))
            return string.Empty;

        binary = new string([.. binary.Where(c => c == '0' || c == '1')]);

        if (binary.Length % 8 != 0)
            throw new ArgumentException("A string binária deve ter comprimento múltiplo de 8.");

        var chars = Enumerable.Range(0, binary.Length / 8)
            .Select(i => (char)Convert.ToByte(binary.Substring(i * 8, 8), 2));

        return new string([.. chars]);
    }
}