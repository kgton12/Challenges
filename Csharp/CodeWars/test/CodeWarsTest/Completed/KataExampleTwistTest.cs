using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class KataExampleTwistTest
{
    [Test]
    public static void Tests()
    {
        Assert.That(KataExampleTwist.Websites, Is.Not.Null);
        Assert.That(KataExampleTwist.Websites.Length, Is.EqualTo(1000));
        using (Assert.EnterMultipleScope())
        {
            Assert.That(KataExampleTwist.Websites.GetType().GetElementType(), Is.EqualTo(typeof(System.String)));
            Assert.That(Array.TrueForAll(KataExampleTwist.Websites, (v) => v == "codewars"));
        }
    }
}
