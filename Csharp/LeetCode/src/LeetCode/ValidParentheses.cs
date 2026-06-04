namespace LeetCode;

public class ValidParentheses
{
    public static bool IsValid(string s)
    {
        int parantheses = 0;
        foreach (var item in s)
        {
            parantheses += item.Equals('(') ? 1 : -1;

            if (parantheses < 0)
                return false;
        }

        return parantheses == 0;
    }
}
