using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class GrasshopperBasicFunctionFixerTest
{
    [TestCase(5, ExpectedResult = 10)]
    [TestCase(0, ExpectedResult = 5)]
    [TestCase(-5, ExpectedResult = 0)]

    [Test]
    public static int FixedTest(int num)
    {
        return GrasshopperBasicFunctionFixer.AddFive(num);
    }
}