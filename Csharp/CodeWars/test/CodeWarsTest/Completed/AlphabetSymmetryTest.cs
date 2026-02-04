using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class AlphabetSymmetryTest
{
    [Test]
    public void BasicTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(AlphabetSymmetry.Solve(["abode", "ABc", "xyzD"]), Is.EqualTo(new List<int> { 4, 3, 1 }));
            Assert.That(AlphabetSymmetry.Solve(["abide", "ABc", "xyz"]), Is.EqualTo(new List<int> { 4, 3, 0 }));
            Assert.That(AlphabetSymmetry.Solve(["IAMDEFANDJKL", "thedefgh", "xyzDEFghijabc"]), Is.EqualTo(new List<int> { 6, 5, 7 }));
            Assert.That(AlphabetSymmetry.Solve(["encode", "abc", "xyzD", "ABmD"]), Is.EqualTo(new List<int> { 1, 3, 1, 3 }));
        }
    }
}
