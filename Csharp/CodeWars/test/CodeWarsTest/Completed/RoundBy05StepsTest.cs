using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class RoundBy05StepsTest
{
    private static readonly object[] SampleTestCases =
    [
        new object[] {4.0, 4},
        new object[] {4.1, 4},
        new object[] {4.2, 4},
        new object[] {4.4, 4.5},
        new object[] {4.6, 4.5},
        new object[] {4.7, 4.5},
        new object[] {4.8, 5},
        new object[] {4.9, 5},
    ];

    [Test, TestCaseSource(nameof(SampleTestCases))]
    public void SampleTest(double n, double expected)
    {
        Assert.That(RoundBy05Steps.Solution(n), Is.EqualTo(expected));
    }
}
