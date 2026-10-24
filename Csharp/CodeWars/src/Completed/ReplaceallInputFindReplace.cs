namespace CodeWars.Completed;

public class ReplaceallInputFindReplace
{
    public static string ReplaceAll(string input, string find, string replace)
    {
        //return Regex.Replace(input, Regex.Escape(find), replace);

        if (string.IsNullOrEmpty(input) && !string.IsNullOrEmpty(replace))
        {
            if (string.IsNullOrEmpty(find))
                return replace;
            else
                return string.Empty;
        }

        if (string.IsNullOrEmpty(find))
        {
            string result = string.Empty;

            for (int i = 0; i <= input.Length * 2; i++)
                result += i % 2 == 0 ? replace : input[i / 2];

            return result;
        }

        return input.Replace(find, replace);
    }
}
