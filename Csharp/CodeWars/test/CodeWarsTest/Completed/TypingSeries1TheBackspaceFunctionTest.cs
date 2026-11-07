using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class TypingSeries1TheBackspaceFunctionTest
{
    [Test, Description("Easy")]
    public void Test_Easy()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(TypingSeries1TheBackspaceFunction.Solve("abcde[backspace]"), Is.EqualTo("abcd"));
            Assert.That(TypingSeries1TheBackspaceFunction.Solve("oopp[backspace]s"), Is.EqualTo("oops"));
            Assert.That(TypingSeries1TheBackspaceFunction.Solve("ooppp[backspace][backspace]s"), Is.EqualTo("oops"));
        }
    }

    [Test, Description("Mutiple backspaces")]
    public void Test_MutipleBackspaces()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(TypingSeries1TheBackspaceFunction.Solve("ooppp[backspace]*2s"), Is.EqualTo("oops"));
            Assert.That(TypingSeries1TheBackspaceFunction.Solve("oop[backspace]*1oo[backspace]*2pppp[backspace]*3s"), Is.EqualTo("oops"));
            Assert.That(TypingSeries1TheBackspaceFunction.Solve("This isss[backspace]*2 aaa[backspace]*2aa[backspace]*2 testtt[backspace]*2"), Is.EqualTo("This is a test"));
            Assert.That(TypingSeries1TheBackspaceFunction.Solve("[backspace]t[backspace]tto [backspace][backspace][backspace]*3[backspace]*15nani"), Is.EqualTo("nani"));
        }
    }

    [Test, Description("Edge cases")]
    public void Test_EdgeCases()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(TypingSeries1TheBackspaceFunction.Solve(""), Is.EqualTo(""));
            Assert.That(TypingSeries1TheBackspaceFunction.Solve("[backspace]"), Is.EqualTo(""));
            Assert.That(TypingSeries1TheBackspaceFunction.Solve("[backspace]*1a"), Is.EqualTo("a"));
            Assert.That(TypingSeries1TheBackspaceFunction.Solve("No backspaces"), Is.EqualTo("No backspaces"));
            Assert.That(TypingSeries1TheBackspaceFunction.Solve("TT[backspace]*3Thn[backspace]is is is[backspace]*3 an edge case[backspace]*10 edge case[backspace]e"), Is.EqualTo("This is an edge case"));
            Assert.That(TypingSeries1TheBackspaceFunction.Solve("[backspace]*10e[backspace][backspace]e[backspace][backspace]*2wut is this[backspace]*2is[backspace][backspace]is"), Is.EqualTo("wut is this"));
        }
    }
}
