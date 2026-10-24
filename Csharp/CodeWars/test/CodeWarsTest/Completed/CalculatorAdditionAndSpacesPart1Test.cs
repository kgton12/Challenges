using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CalculatorAdditionAndSpacesPart1Test
{
    private static readonly object[] Basic_Test_Cases =
    [
        new object[] {"1+2+3", 6},
        new object[] {"1+2 3", 24},
        new object[] {"1 2 3", 123},
    ];

    [Test, TestCaseSource(typeof(CalculatorAdditionAndSpacesPart1Test), nameof(Basic_Test_Cases)), Order(1)]
    public void Basic_Test(string test, int expected)
    {
        Assert.That(CalculatorAdditionAndSpacesPart1.Calculate(test), Is.EqualTo(expected));
    }
}
