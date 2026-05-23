using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ClosestToZeroTest
{
    private static IEnumerable<TestCaseData> BasicTests
    {
        get
        {
            yield return new TestCaseData(new int[] { 10, 3, 9, 1 }).Returns(1).SetDescription("Simple test");
            yield return new TestCaseData(new int[] { 2, 4, -1, -3 }).Returns(-1).SetDescription("Simple test");
            yield return new TestCaseData(new int[] { 13, 0, -6 }).Returns(0).SetDescription("Simple test");
            yield return new TestCaseData(new int[] { 13, 0, 0, -6 }).Returns(0).SetDescription("Simple test");
        }
    }

    private static IEnumerable<TestCaseData> DoubleTests
    {
        get
        {
            yield return new TestCaseData(new int[] { 5, 1, -1, 2, -10 }).Returns(null).SetDescription("Should return None for 'doubles'");
            yield return new TestCaseData(new int[] { 5, 11, 11, 2, -1, 1 }).Returns(null).SetDescription("Should return None for 'doubles'");
        }
    }

    [Test, TestCaseSource(nameof(BasicTests)), Order(1)]
    public int? BasicTest(int[] arr) => ClosestToZero.Closest(arr);

    [Test, TestCaseSource(nameof(DoubleTests)), Order(2)]
    public int? DoubleTest(int[] arr) => ClosestToZero.Closest(arr);
}
