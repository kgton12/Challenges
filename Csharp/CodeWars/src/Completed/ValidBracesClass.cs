namespace CodeWars.Completed;

public class ValidBracesClass
{
    public static bool ValidBraces(string s)
    {
        Stack<char> stack = new();
        Dictionary<char, char> pairs = new()
        {
            {')', '('},
            {']', '['},
            {'}', '{'}
        };

        foreach (char ch in s)
        {
            if (ch == '(' || ch == '[' || ch == '{')
            {
                stack.Push(ch);
            }
            else
            {
                if (stack.Count == 0 || stack.Pop() != pairs[ch])
                    return false;
            }
        }

        return stack.Count == 0;
    }
}