namespace CodeWars.Completed;

public class EsolangInterpreters1IntroductionToEsolangsAndMyFirstInterpreterMinistringfuck
{
    public static string MyFirstInterpreter(string code)
    {
        List<char> output = [];
        int memoryCell = 0;

        foreach (var c in code)
        {
            if (c == '+')
                memoryCell = (memoryCell + 1) % 256;
            else if (c == '.')
                output.Add(Convert.ToChar(memoryCell));
        }

        return string.Concat(output);
    }
}