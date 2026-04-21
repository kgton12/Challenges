using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ConvertAnArrayOfStringsToArrayOfNumbersTest
{
    [Test]
    public void ExampleTest()
    {
        Assert.That(ConvertAnArrayOfStringsToArrayOfNumbers.ToDoubleArray(["1.1", "2.2", "3.3"]), Is.EqualTo([1.1, 2.2, 3.3]));
    }
}
