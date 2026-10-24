using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class IndTheCapitalsTest
{
    [Test]
    public void CodEWaRs()
    {
        Assert.That(FindTheCapitals.Capitals("CodEWaRs"), Is.EqualTo([0, 3, 4, 6]), "Input: \"CodEWaRs\"");
    }

    [Test]
    public void Empty()
    {
        Assert.That(FindTheCapitals.Capitals(""), Is.EqualTo(new int[0]), "Input: \"\"");
    }

    [Test]
    public void AllCapitals()
    {
        Assert.That(FindTheCapitals.Capitals("AAA"), Is.EqualTo([0, 1, 2]), "Input: \"AAA\"");
    }

    [Test]
    public void aAbB()
    {
        Assert.That(FindTheCapitals.Capitals("aAbB"), Is.EqualTo([1, 3]), "Input: \"aAbB\"");
    }
}
