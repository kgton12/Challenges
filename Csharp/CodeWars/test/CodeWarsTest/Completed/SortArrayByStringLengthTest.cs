using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SortArrayByStringLengthTest
{
    [Test]
    public void ExampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SortArrayByStringLength.SortByLength(["Beg", "Life", "I", "To"]), Is.EqualTo(["I", "To", "Beg", "Life"]));
            Assert.That(SortArrayByStringLength.SortByLength(["", "Moderately", "Brains", "Pizza"]), Is.EqualTo(["", "Pizza", "Brains", "Moderately"]));
            Assert.That(SortArrayByStringLength.SortByLength(["Longer", "Longest", "Short"]), Is.EqualTo(["Short", "Longer", "Longest"]));
        }
    }
}
