namespace CodeWars.Completed;

public class BackspacesInString
{
    public static string CleanString(string s)
    {
        Stack<char> stack = [];

        foreach (var chr in s)
        {
            if (chr.Equals('#'))
            {
                if (stack.Count > 0)
                    stack.Pop();
            }
            else
                stack.Push(chr);
        }

        return string.Concat(stack.Reverse().ToArray());
    }
}