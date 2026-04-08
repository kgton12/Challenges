using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class LargestElementsTest
{
    [Test, Description("Sample Tests")]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(LargestElements.Largest(2, [10, 9, 8, 7, 6, 5, 4, 3, 2, 1]), Is.EqualTo(new List<int> { 9, 10 }));
            Assert.That(LargestElements.Largest(3, [5, 1, 5, 2, 3, 1, 2, 3, 5]), Is.EqualTo(new List<int> { 5, 5, 5 }));
            Assert.That(LargestElements.Largest(7, [9, 1, 50, 22, 3, 13, 2, 63, 5]), Is.EqualTo(new List<int> { 3, 5, 9, 13, 22, 50, 63 }));
            Assert.That(LargestElements.Largest(0, [1, 2, 3, 4, 8, 7, 6, 5]), Is.EqualTo(new List<int> { }));
        }
    }
}
