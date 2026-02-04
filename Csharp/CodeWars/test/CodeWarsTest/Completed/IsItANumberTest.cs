using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class IsItANumberTest
{
    [TestCase("s2324", false)]
    [TestCase("34.65", true)]
    public void BasicTests(
         string input,
         bool expectedResult)
    {
        Assert.That(IsItANumber.IsDigit(input), Is.EqualTo(expectedResult));
    }
}
