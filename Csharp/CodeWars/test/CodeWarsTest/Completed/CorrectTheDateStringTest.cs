using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CorrectTheDateStringTest
{
    [Test, Order(1)]
    public void NullTest()
    {
        Assert.That(CorrectTheDateString.Correct(null), Is.Null);
    }

    [Test, Order(2)]
    public void EmptyTest()
    {
        Assert.That(CorrectTheDateString.Correct(""), Is.EqualTo(""));
    }

    [Test, Order(3)]
    public void InvalidFormatTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CorrectTheDateString.Correct("01112016"), Is.Null);
            Assert.That(CorrectTheDateString.Correct("01,11,2016"), Is.Null);
            Assert.That(CorrectTheDateString.Correct("0a.1c.2016"), Is.Null);
        }
    }

    [Test, Order(4)]
    public void CorrectionTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CorrectTheDateString.Correct("30.02.2016"), Is.EqualTo("01.03.2016"));
            Assert.That(CorrectTheDateString.Correct("40.06.2015"), Is.EqualTo("10.07.2015"));
            Assert.That(CorrectTheDateString.Correct("11.13.2014"), Is.EqualTo("11.01.2015"));
            Assert.That(CorrectTheDateString.Correct("99.11.2010"), Is.EqualTo("07.02.2011"));
        }
    }
}
