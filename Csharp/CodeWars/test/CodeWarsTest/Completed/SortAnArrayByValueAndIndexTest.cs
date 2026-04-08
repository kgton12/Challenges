using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SortAnArrayByValueAndIndexTest
{
    [Test]
    public void ExampleTests()
    {
        var actual = SortAnArrayByValueAndIndex.SortByValueAndIndex([1, 2, 3, 4, 5]);
        var expected = new int[] { 1, 2, 3, 4, 5 };
        var message = "Your result:\n" + ArrayToString(actual) + "\n\nExpected result:\n" + ArrayToString(expected);
        Assert.That(actual, Is.EqualTo(expected), message);

        actual = SortAnArrayByValueAndIndex.SortByValueAndIndex([23, 2, 3, 4, 5]);
        expected = [2, 3, 4, 23, 5];
        message = "Your result:\n" + ArrayToString(actual) + "\n\nExpected result:\n" + ArrayToString(expected);
        Assert.That(actual, Is.EqualTo(expected), message);

        actual = SortAnArrayByValueAndIndex.SortByValueAndIndex([26, 2, 3, 4, 5]);
        expected = [2, 3, 4, 5, 26];
        message = "Your result:\n" + ArrayToString(actual) + "\n\nExpected result:\n" + ArrayToString(expected);
        Assert.That(actual, Is.EqualTo(expected), message);

        actual = SortAnArrayByValueAndIndex.SortByValueAndIndex([9, 5, 1, 4, 3]);
        expected = [1, 9, 5, 3, 4];
        message = "Your result:\n" + ArrayToString(actual) + "\n\nExpected result:\n" + ArrayToString(expected);
        Assert.That(actual, Is.EqualTo(expected), message);
    }

    private String ArrayToString(int[] array)
    {
        return String.Join(", ", array);
    }
}
