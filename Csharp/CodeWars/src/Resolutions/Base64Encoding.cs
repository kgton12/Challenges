using System.Text;

namespace CodeWars.Resolutions;

public class Base64Encoding
{
    private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

    public static string ToBase64(byte[] data)
    {

        if (data.Length == 0)
            return string.Empty;

        var sb = new StringBuilder((data.Length * 4 + 2) / 3);

        int i = 0;

        while (i + 3 <= data.Length)
        {
            int b0 = data[i++];
            int b1 = data[i++];
            int b2 = data[i++];

            int triple = (b0 << 16) | (b1 << 8) | b2;

            sb.Append(Alphabet[(triple >> 18) & 0x3F]);
            sb.Append(Alphabet[(triple >> 12) & 0x3F]);
            sb.Append(Alphabet[(triple >> 6) & 0x3F]);
            sb.Append(Alphabet[triple & 0x3F]);
        }

        int rem = data.Length - i;
        if (rem == 1)
        {
            int b0 = data[i] << 16;
            sb.Append(Alphabet[(b0 >> 18) & 0x3F]);
            sb.Append(Alphabet[(b0 >> 12) & 0x3F]);
        }
        else if (rem == 2)
        {
            int b0b1 = (data[i] << 16) | (data[i + 1] << 8);
            sb.Append(Alphabet[(b0b1 >> 18) & 0x3F]);
            sb.Append(Alphabet[(b0b1 >> 12) & 0x3F]);
            sb.Append(Alphabet[(b0b1 >> 6) & 0x3F]);
        }

        return sb.ToString();
    }

    public static byte[] FromBase64(string encoded)
    {
        if (encoded.Length == 0)
            return [];

        var map = BuildDecodeMap();

        List<int> sextets = new(encoded.Length);
        foreach (char c in encoded)
        {
            if (char.IsWhiteSpace(c))
                continue;

            int v = c < map.Length ? map[c] : -1;

            sextets.Add(v);
        }

        if (sextets.Count == 0)
            return [];

        List<byte> output = new(sextets.Count * 6 / 8);
        int buffer = 0;
        int bits = 0;

        foreach (int s in sextets)
        {
            buffer = (buffer << 6) | s;
            bits += 6;

            while (bits >= 8)
            {
                bits -= 8;
                output.Add((byte)((buffer >> bits) & 0xFF));
            }
        }
        return [.. output];
    }
    private static sbyte[] BuildDecodeMap()
    {
        var map = new sbyte[256];
        for (int i = 0; i < map.Length; i++) map[i] = -1;

        for (int i = 0; i < 26; i++)
        {
            map['A' + i] = (sbyte)i;
            map['a' + i] = (sbyte)(26 + i);
        }
        for (int i = 0; i < 10; i++)
        {
            map['0' + i] = (sbyte)(52 + i);
        }
        map['+'] = 62;
        map['/'] = 63;

        return map;
    }
}