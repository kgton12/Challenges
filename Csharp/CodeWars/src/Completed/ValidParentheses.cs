namespace CodeWars.Completed;

public class ValidParenthesesClass
{
    public static bool ValidParentheses(string str)
    {
        int parantheses = 0;
        foreach (var item in str)
        {
            parantheses += item.Equals('(') ? 1 : -1;

            if (parantheses < 0) return false;
        }

        return parantheses == 0;
    }
}
