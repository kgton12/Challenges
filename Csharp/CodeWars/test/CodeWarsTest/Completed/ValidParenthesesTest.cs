using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ValidParenthesesTest
{
    [Test, Order(1)]
    public void TestValidParentheses()
    {
        DoTest(true, "()");
        DoTest(true, "((()))");
        DoTest(true, "()()()");
        DoTest(true, "(()())()");
        DoTest(true, "()(())((()))(())()");
    }

    [Test, Order(2)]
    public void TestInvalidParentheses()
    {
        DoTest(false, ")(");
        DoTest(false, "()()(");
        DoTest(false, "((())");
        DoTest(false, "())(()");
        DoTest(false, ")()");
        DoTest(false, ")");
    }

    [Test, Order(3)]
    public void TestEmptyString()
    {
        DoTest(true, "");
    }

    private static void DoTest(bool expected, string str)
    {
        Assert.That(ValidParenthesesClass.ValidParentheses(str), Is.EqualTo(expected), $"Incorrect answer for str = \"{str}\"");
    }
}
