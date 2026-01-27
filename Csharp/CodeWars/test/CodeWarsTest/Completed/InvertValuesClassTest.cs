using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class InvertValuesClassTest
{
    private static readonly int[] expected = [0];

    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(InvertValuesClass.InvertValues([1, 2, 3, 4, 5]), Is.EqualTo(new int[] { -1, -2, -3, -4, -5 }));
            Assert.That(InvertValuesClass.InvertValues([1, -2, 3, -4, 5]), Is.EqualTo(new int[] { -1, 2, -3, 4, -5 }));
            Assert.That(InvertValuesClass.InvertValues([]), Is.EqualTo(Array.Empty<int>()));
            Assert.That(InvertValuesClass.InvertValues([0]), Is.EqualTo(expected));
        }
    }
}