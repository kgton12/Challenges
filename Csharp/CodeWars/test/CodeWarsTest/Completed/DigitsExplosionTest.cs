using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class DigitsExplosionTest
{

    [TestCase("312", "333122")]
    [TestCase("102269", "12222666666999999999")]
    public static void ExplodeTests(string s, string result)
    {
        Assert.That(DigitsExplosion.Explode(s), Is.EqualTo(result), $"\"{s}\" is exploded incorrectly");
    }
}
