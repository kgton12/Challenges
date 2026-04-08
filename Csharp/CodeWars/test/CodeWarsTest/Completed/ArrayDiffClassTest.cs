using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ArrayDiffClassTest
{
    [Test, Order(1)]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ArrayDiffClass.ArrayDiff([1, 2], [1]), Is.EqualTo([2]));
            Assert.That(ArrayDiffClass.ArrayDiff([1, 2, 2], [1]), Is.EqualTo([2, 2]));
            Assert.That(ArrayDiffClass.ArrayDiff([1, 2, 2], [2]), Is.EqualTo([1]));
            Assert.That(ArrayDiffClass.ArrayDiff([1, 2, 2], []), Is.EqualTo([1, 2, 2]));
            Assert.That(ArrayDiffClass.ArrayDiff([], [1, 2]), Is.EqualTo(Array.Empty<int>()));
            Assert.That(ArrayDiffClass.ArrayDiff([1, 2, 3], [1, 2]), Is.EqualTo([3]));
        }
    }
}
