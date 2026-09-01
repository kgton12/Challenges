namespace CodeWars.Completed;

public class CircleCipher
{
    public static string Encode(string s)
    {
        bool isLeft = true;
        LinkedList<char> queue = new(s);
        string result = string.Empty;

        for (int i = 0; i < s.Length; i++)
        {
            if (isLeft)
            {
                result += queue?.First?.Value;
                queue?.RemoveFirst();
            }
            else
            {
                result += queue?.Last?.Value;
                queue?.RemoveLast();
            }

            isLeft = !isLeft;
        }

        return result;
    }

    public static string Decode(string s)
    {
        string firtPart = string.Concat(
                s.Where((v, i) => int.IsEvenInteger(i))
        );

        string secondPart = string.Concat(
           s.Where((v, i) => int.IsOddInteger(i)).Reverse()
        );

        return firtPart + secondPart;
    }
}
