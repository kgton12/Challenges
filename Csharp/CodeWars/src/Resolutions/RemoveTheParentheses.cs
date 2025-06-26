using System.Text;

namespace CodeWars.src.Resolutions;

public static class RemoveTheParentheses
{
    public static string RemoveParentheses(string s)
    {
        var result = new StringBuilder();
        int depth = 0;

        foreach (char c in s)
        {
            if (c == '(')
            {
                depth++;
            }
            else if (c == ')')
            {
                depth--;
            }
            else if (depth == 0)
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }
}