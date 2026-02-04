using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class TakeTheDerivativeTest
{
    private static object[] Basic_Test_Cases = new object[]
       {
      new object[] {7, 8, "56x^7"},
      new object[] {5, 9, "45x^8"},
       };

    [Test, TestCaseSource(typeof(TakeTheDerivativeTest), nameof(Basic_Test_Cases))]
    public void Basic_Test(double coefficient, double exponent, string expected)
    {
        Assert.That(TakeTheDerivative.Derive(coefficient, exponent), Is.EqualTo(expected));
    }
}
