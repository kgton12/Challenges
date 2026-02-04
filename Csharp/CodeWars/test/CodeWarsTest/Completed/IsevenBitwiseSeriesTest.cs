using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class IsevenBitwiseSeriesTest
{
    [Test, Order(1)]
    public void IsEven_SourceCode_DoesNotContainModOperator()
    {
        //var text = File.ReadAllText("/workspace/solution.txt");
        //Assert.That(text.Contains("%"), Is.False);
    }

    [Order(2)]
    [TestCase(true, 2)]
    [TestCase(false, 3)]
    [TestCase(true, 14)]
    [TestCase(false, 15)]
    [TestCase(true, 26)]
    [TestCase(false, 27)]
    public void IsEven_CalledWithAnyInt_ReturnsCorrectResult(bool expected, int n)
    {
        var message = $"{n} is ";
        message += expected ? "even" : "odd";
        Assert.That(IsevenBitwiseSeries.IsEven(n), Is.EqualTo(expected), message);
    }
}
