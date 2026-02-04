using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SortAndStarTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SortAndStar.TwoSort(["bitcoin", "take", "over", "the", "world", "maybe", "who", "knows", "perhaps"]), Is.EqualTo("b***i***t***c***o***i***n"));
            Assert.That(SortAndStar.TwoSort(["turns", "out", "random", "test", "cases", "are", "easier", "than", "writing", "out", "basic", "ones"]), Is.EqualTo("a***r***e"));
        }
    }
}
