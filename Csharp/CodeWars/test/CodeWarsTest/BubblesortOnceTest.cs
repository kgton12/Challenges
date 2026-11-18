using CodeWars;

namespace CodeWarsTest;

[TestFixture]
public class BubblesortOnceTest
{
    [Test]
    public void NoMutation()
    {
        int[] array = [3, 2, 1];
        int[] reference = [3, 2, 1];

        BubblesortOnce.BubbleSortOnce(array);

        Assert.That(array, Is.EqualTo(reference), "Don't modify the array");
    }
    [Test]
    public void _0_ExampleTest()
    {
        var expected = new int[] { 7, 5, 3, 1, 2, 4, 6, 8, 9 };
        var actual = new int[] { 9, 7, 5, 3, 1, 2, 4, 6, 8 };
        Assert.That(BubblesortOnce.BubbleSortOnce(actual), Is.EqualTo(expected));
    }

    [Test]
    public void _1_ExtendedTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(BubblesortOnce.BubbleSortOnce([1, 2]), Is.EqualTo([1, 2]));
            Assert.That(BubblesortOnce.BubbleSortOnce([2, 1]), Is.EqualTo([1, 2]));
            Assert.That(BubblesortOnce.BubbleSortOnce([1, 3]), Is.EqualTo([1, 3]));
            Assert.That(BubblesortOnce.BubbleSortOnce([3, 1]), Is.EqualTo([1, 3]));
            Assert.That(BubblesortOnce.BubbleSortOnce([24, 57]), Is.EqualTo([24, 57]));
            Assert.That(BubblesortOnce.BubbleSortOnce([89, 36]), Is.EqualTo([36, 89]));

            Assert.That(BubblesortOnce.BubbleSortOnce([1, 2, 3]), Is.EqualTo([1, 2, 3]));
            Assert.That(BubblesortOnce.BubbleSortOnce([2, 4, 1]), Is.EqualTo([2, 1, 4]));
            Assert.That(BubblesortOnce.BubbleSortOnce([17, 5, 11]), Is.EqualTo([5, 11, 17]));
            Assert.That(BubblesortOnce.BubbleSortOnce([25, 16, 9]), Is.EqualTo([16, 9, 25]));
            Assert.That(BubblesortOnce.BubbleSortOnce([103, 87, 113]), Is.EqualTo([87, 103, 113]));
            Assert.That(BubblesortOnce.BubbleSortOnce([1032, 3192, 2864]), Is.EqualTo([1032, 2864, 3192]));

            Assert.That(BubblesortOnce.BubbleSortOnce([1, 2, 3, 4]), Is.EqualTo([1, 2, 3, 4]));
            Assert.That(BubblesortOnce.BubbleSortOnce([2, 3, 4, 1]), Is.EqualTo([2, 3, 1, 4]));
            Assert.That(BubblesortOnce.BubbleSortOnce([3, 4, 1, 2]), Is.EqualTo([3, 1, 2, 4]));
            Assert.That(BubblesortOnce.BubbleSortOnce([4, 1, 2, 3]), Is.EqualTo([1, 2, 3, 4]));
            Assert.That(BubblesortOnce.BubbleSortOnce([7, 5, 3, 1]), Is.EqualTo([5, 3, 1, 7]));
            Assert.That(BubblesortOnce.BubbleSortOnce([5, 3, 7, 7]), Is.EqualTo([3, 5, 7, 7]));
            Assert.That(BubblesortOnce.BubbleSortOnce([3, 1, 8, 5]), Is.EqualTo([1, 3, 5, 8]));
            Assert.That(BubblesortOnce.BubbleSortOnce([1, 9, 5, 5]), Is.EqualTo([1, 5, 5, 9]));
        }
    }

    [Test]
    public void _2_AdvancedTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(BubblesortOnce.BubbleSortOnce([6, 3, 4, 9, 1, 2, 7, 8, 5]), Is.EqualTo([3, 4, 6, 1, 2, 7, 8, 5, 9]));
            Assert.That(BubblesortOnce.BubbleSortOnce([6, 3, 4, 15, 14, 9, 1, 2, 7, 8, 5, 14, 11, 15, 17, 19]), Is.EqualTo([3, 4, 6, 14, 9, 1, 2, 7, 8, 5, 14, 11, 15, 15, 17, 19]));
        }
    }
}
