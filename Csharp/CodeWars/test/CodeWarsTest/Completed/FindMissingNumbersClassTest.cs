using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class FindMissingNumbersClassTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FindMissingNumbersClass.FindMissingNumbers([-3, -2, 1, 4]), Is.EqualTo([-1, 0, 2, 3]));
            Assert.That(FindMissingNumbersClass.FindMissingNumbers([-1, 0, 1, 2, 3, 4]), Is.EqualTo(Array.Empty<int>()));
            Assert.That(FindMissingNumbersClass.FindMissingNumbers([]), Is.EqualTo(Array.Empty<int>()));
        }
    }
}
