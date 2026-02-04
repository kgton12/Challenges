using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SortAnArrayByValueAndIndexTest
{
    [Test]
    public void ExampleTests()
    {
        var actual = SortAnArrayByValueAndIndex.SortByValueAndIndex(new int[] { 1, 2, 3, 4, 5 });
        var expected = new int[] { 1, 2, 3, 4, 5 };
        var message = "Your result:\n" + ArrayToString(actual) + "\n\nExpected result:\n" + ArrayToString(expected);
        Assert.That(actual, Is.EqualTo(expected), message);

        actual = SortAnArrayByValueAndIndex.SortByValueAndIndex(new int[] { 23, 2, 3, 4, 5 });
        expected = new int[] { 2, 3, 4, 23, 5 };
        message = "Your result:\n" + ArrayToString(actual) + "\n\nExpected result:\n" + ArrayToString(expected);
        Assert.That(actual, Is.EqualTo(expected), message);

        actual = SortAnArrayByValueAndIndex.SortByValueAndIndex(new int[] { 26, 2, 3, 4, 5 });
        expected = new int[] { 2, 3, 4, 5, 26 };
        message = "Your result:\n" + ArrayToString(actual) + "\n\nExpected result:\n" + ArrayToString(expected);
        Assert.That(actual, Is.EqualTo(expected), message);

        actual = SortAnArrayByValueAndIndex.SortByValueAndIndex(new int[] { 9, 5, 1, 4, 3 });
        expected = new int[] { 1, 9, 5, 3, 4 };
        message = "Your result:\n" + ArrayToString(actual) + "\n\nExpected result:\n" + ArrayToString(expected);
        Assert.That(actual, Is.EqualTo(expected), message);
    }

    private String ArrayToString(int[] array)
    {
        return String.Join(", ", array);
    }
}
