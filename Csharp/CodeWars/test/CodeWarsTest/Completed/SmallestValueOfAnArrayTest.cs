using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SmallestValueOfAnArrayTest
{
    private static void DoTest(int[] numbers, String mode, int expected)
    {
        String message = String.Format("for mode = \"{0}\" and array = [{1}]\n",
            mode, String.Join(", ", numbers)
        );
        int actual = SmallestValueOfAnArray.FindSmallest(numbers, mode);
        Assert.That(actual, Is.EqualTo(expected), message);
    }

    [Test]
    public void SampleTests()
    {
        DoTest([1, 2, 3, 4, 5], "value", 1);
        DoTest([1, 2, 3, 4, 5], "index", 0);
        DoTest([5, 4, 3, 2, 1], "value", 1);
        DoTest([5, 4, 3, 2, 1], "index", 4);
        DoTest([Int32.MaxValue], "value", Int32.MaxValue);
        DoTest([0, Int32.MinValue], "value", Int32.MinValue);
    }
}
