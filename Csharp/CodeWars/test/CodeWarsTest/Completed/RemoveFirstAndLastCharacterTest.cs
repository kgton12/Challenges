using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class RemoveFirstAndLastCharacterTest
{
    [Test, Order(1)]
    public void Test1()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(RemoveFirstAndLastCharacter.RemoveChar("eloquent"), Is.EqualTo("loquen").IgnoreCase);
            Assert.That(RemoveFirstAndLastCharacter.RemoveChar("country"), Is.EqualTo("ountr").IgnoreCase);
            Assert.That(RemoveFirstAndLastCharacter.RemoveChar("person"), Is.EqualTo("erso").IgnoreCase);
            Assert.That(RemoveFirstAndLastCharacter.RemoveChar("place"), Is.EqualTo("lac").IgnoreCase);
            Assert.That(RemoveFirstAndLastCharacter.RemoveChar("ok"), Is.EqualTo("").IgnoreCase);
        }
    }
}
