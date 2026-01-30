using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class MergeTwoSortedArraysIntoOneTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(MergeTwoSortedArraysIntoOne.MergeArrays([1, 2, 3, 4], [5, 6, 7, 8]), Is.EqualTo([1, 2, 3, 4, 5, 6, 7, 8]));

            Assert.That(MergeTwoSortedArraysIntoOne.MergeArrays([1, 3, 5, 7, 9], [10, 8, 6, 4, 2]), Is.EqualTo([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]));

            Assert.That(MergeTwoSortedArraysIntoOne.MergeArrays([1, 3, 5, 7, 9, 11, 12], [1, 2, 3, 4, 5, 10, 12]), Is.EqualTo([1, 2, 3, 4, 5, 7, 9, 10, 11, 12]));

            Assert.That(MergeTwoSortedArraysIntoOne.MergeArrays([], []), Is.EqualTo(Array.Empty<int>()));

            Assert.That(MergeTwoSortedArraysIntoOne.MergeArrays([1, 2, 3], []), Is.EqualTo([1, 2, 3]));

            Assert.That(MergeTwoSortedArraysIntoOne.MergeArrays([], [1, 2, 3, 4, 5]), Is.EqualTo([1, 2, 3, 4, 5]));

            Assert.That(MergeTwoSortedArraysIntoOne.MergeArrays([-3, -2, -1, 0], [1, 2, 3, 4]), Is.EqualTo([-3, -2, -1, 0, 1, 2, 3, 4]));
        }
    }
}
