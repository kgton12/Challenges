using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SumArraysTest
{
    private static readonly object[] TestCases =
        [
          new object[] {new double[] {1, 5.2, 4, 0, -1}, 9.2},
          new object[] { Array.Empty<double>(), 0},
        ];

    [Test, TestCaseSource(nameof(TestCases))]
    public void Test(double[] array, double expected) => Assert.That(SumArrays.SumArray(array), Is.EqualTo(expected));
}
