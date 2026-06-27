using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class FindTheMineTest
{
    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData(new int[,] { { 1, 0 }, { 0, 0 } }).Returns(new Tuple<int, int>(0, 0));
            yield return new TestCaseData(new int[,] { { 1, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } }).Returns(new Tuple<int, int>(0, 0));
            yield return new TestCaseData(new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 0 } }).Returns(new Tuple<int, int>(2, 2));
        }
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public Tuple<int, int> Test(int[,] field) => FindTheMine.MineLocation(field);
}