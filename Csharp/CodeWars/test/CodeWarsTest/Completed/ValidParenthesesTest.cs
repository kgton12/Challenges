using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ValidParenthesesTest
{
    [Test]
    public void TestValidParentheses()
    {
        DoTest(true, "()");
        DoTest(true, "((()))");
        DoTest(true, "()()()");
        DoTest(true, "(()())()");
        DoTest(true, "()(())((()))(())()");
    }

    [Test]
    public void TestInvalidParentheses()
    {
        DoTest(false, ")(");
        DoTest(false, "()()(");
        DoTest(false, "((())");
        DoTest(false, "())(()");
        DoTest(false, ")()");
        DoTest(false, ")");
    }

    [Test]
    public void TestEmptyString()
    {
        DoTest(true, "");
    }

    private static void DoTest(bool expected, string str)
    {
        Assert.That(ValidParenthesesClass.ValidParentheses(str), Is.EqualTo(expected), $"Incorrect answer for str = \"{str}\"");
    }
}
