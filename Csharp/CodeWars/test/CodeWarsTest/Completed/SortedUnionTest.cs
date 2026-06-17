using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SortedUnionTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SortedUnion.UniteUnique([[1, 2], [3, 4]]), Is.EqualTo(new object[] { 1, 2, 3, 4 }));
            Assert.That(SortedUnion.UniteUnique([[1, 3, 2], [5, 2, 1, 4], [2, 1]]), Is.EqualTo(new object[] { 1, 3, 2, 5, 4 }));
            Assert.That(SortedUnion.UniteUnique([[4, 3, 2, 2]]), Is.EqualTo(new object[] { 4, 3, 2 }));
            Assert.That(SortedUnion.UniteUnique([[4, "a", 2], []]), Is.EqualTo(new object[] { 4, "a", 2 }));
            Assert.That(SortedUnion.UniteUnique([[], [4, "a", 2]]), Is.EqualTo(new object[] { 4, "a", 2 }));
            Assert.That(SortedUnion.UniteUnique([[], [4, "a", 2], []]), Is.EqualTo(new object[] { 4, "a", 2 }));
            Assert.That(SortedUnion.UniteUnique([[]]), Is.EqualTo(Array.Empty<object>()));
            Assert.That(SortedUnion.UniteUnique([[], []]), Is.EqualTo(Array.Empty<object>()));
            Assert.That(SortedUnion.UniteUnique([[], [1, 2]]), Is.EqualTo(new object[] { 1, 2 }));
            Assert.That(SortedUnion.UniteUnique([[], [1, 2, 1, 2], [2, 1, 1, 2, 1]]), Is.EqualTo(new object[] { 1, 2 }));
        }
    }
}
