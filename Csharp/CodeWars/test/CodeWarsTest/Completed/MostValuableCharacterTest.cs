using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class MostValuableCharacterTest
{
    [Test]
    public void ExampleTests()
    {
        Assert.That(MostValuableCharacter.Solve("a"), Is.EqualTo('a'));
        Assert.That(MostValuableCharacter.Solve("aa"), Is.EqualTo('a'));
        Assert.That(MostValuableCharacter.Solve("bcd"), Is.EqualTo('b'));
        Assert.That(MostValuableCharacter.Solve("axyzxyz"), Is.EqualTo('x'));
        Assert.That(MostValuableCharacter.Solve("dcbadcba"), Is.EqualTo('a'));
        Assert.That(MostValuableCharacter.Solve("aabccc"), Is.EqualTo('c'));
        Assert.That(MostValuableCharacter.Solve("efgefg"), Is.EqualTo('e'));
        Assert.That(MostValuableCharacter.Solve("efghijefghi"), Is.EqualTo('e'));
        Assert.That(MostValuableCharacter.Solve("acefacef"), Is.EqualTo('a'));
        Assert.That(MostValuableCharacter.Solve("acefacefacef"), Is.EqualTo('a'));
    }
}
