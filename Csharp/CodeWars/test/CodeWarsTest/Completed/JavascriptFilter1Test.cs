using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class JavascriptFilter1Test
{
    [Test]
    public void Test1()
    {
        string[][] a = [["foo", "foo@foo.com"], ["bar_", "bar@bar.com"]];
        string[][] b = [["bar_", "bar@bar.com"]];
        Assert.That(b, Is.EquivalentTo(JavascriptFilter1.SearchNames(a)));
    }

    [Test]
    public void Test2()
    {
        string[][] a = [["foo_", "foo@foo.com"], ["bar_", "bar@bar.com"]];
        string[][] b = [["foo_", "foo@foo.com"], ["bar_", "bar@bar.com"]];
        Assert.That(b, Is.EquivalentTo(JavascriptFilter1.SearchNames(a)));
    }

    [Test]
    public void Test3()
    {
        string[][] a = [["foo", "foo@foo.com"], ["bar", "bar@bar.com"]];
        string[] b = [];
        Assert.That(b, Is.EquivalentTo(JavascriptFilter1.SearchNames(a)));
    }
}
