using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class FindTheDuplicatedNumberInAConsecutiveUnsortedListTest
{
    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData(new[] { new int[] { 1, 1, 2, 3 } }).Returns(1);
            yield return new TestCaseData(new[] { new int[] { 5, 4, 3, 2, 1, 1 } }).Returns(1);
            yield return new TestCaseData(new[] { new int[] { 1, 3, 2, 5, 4, 5, 7, 6 } }).Returns(5);
            yield return new TestCaseData(new[] { new int[] { 8, 2, 6, 3, 7, 2, 5, 1, 4 } }).Returns(2);
        }
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int Test(int[] arr) => FindTheDuplicatedNumberInAConsecutiveUnsortedList.FindDup(arr);
}
