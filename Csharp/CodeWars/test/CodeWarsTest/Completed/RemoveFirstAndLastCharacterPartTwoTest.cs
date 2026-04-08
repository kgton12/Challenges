using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class RemoveFirstAndLastCharacterPartTwoTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(RemoveFirstandLastCharacterPartTwo.Array(""), Is.Null);
            Assert.That(RemoveFirstandLastCharacterPartTwo.Array("1"), Is.Null);
            Assert.That(RemoveFirstandLastCharacterPartTwo.Array("1, 3"), Is.Null);
            Assert.That(RemoveFirstandLastCharacterPartTwo.Array("1,2,3"), Is.EqualTo("2"));
            Assert.That(RemoveFirstandLastCharacterPartTwo.Array("1,2,3,4"), Is.EqualTo("2 3"));
        }
    }
}
