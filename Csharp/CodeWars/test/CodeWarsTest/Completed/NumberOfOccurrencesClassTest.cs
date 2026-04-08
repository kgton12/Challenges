using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class NumberOfOccurrencesClassTest
{
    [Test, Order(1)]
    public void Should_Work_On_Empty_List()
    {
        Assert.That(NumberOfOccurrencesClass.NumberOfOccurrences(2, []), Is.EqualTo(0));
    }

    [Test, Order(2)]
    public void Should_Work_On_Examples()
    {
        var example = new int[] { 4, 0, 4 };

        using (Assert.EnterMultipleScope())
        {
            Assert.That(NumberOfOccurrencesClass.NumberOfOccurrences(4, example), Is.EqualTo(2));

            Assert.That(NumberOfOccurrencesClass.NumberOfOccurrences(1, example), Is.EqualTo(0));

            Assert.That(NumberOfOccurrencesClass.NumberOfOccurrences(0, example), Is.EqualTo(1));
        }
    }
}
