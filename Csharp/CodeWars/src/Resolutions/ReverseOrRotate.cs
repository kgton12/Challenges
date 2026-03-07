namespace CodeWars.Resolutions;

public class ReverseOrRotate
{
    public static string RevRot(string s, int sz)
    {
        if (string.IsNullOrWhiteSpace(s) || sz <= 0 || sz > s.Length)
            return string.Empty;

        var output = new List<string>();
        int len = s.Length / sz;

        for (int index = 0; index < len; index++)
        {
            var slice = s.AsSpan(index * sz, sz);


            var arrayValue = new List<int>(sz);
            foreach (var ch in slice)
                arrayValue.Add(ch - '0');

            bool isEven = arrayValue.Sum() % 2 == 0;

            if (isEven)
            {
                arrayValue.Reverse();
                output.Add(string.Concat(arrayValue));
            }
            else
            {
                int first = arrayValue[0];
                arrayValue.RemoveAt(0);
                arrayValue.Add(first);

                output.Add(string.Concat(arrayValue));
            }
        }

        return string.Concat(output);
    }
}