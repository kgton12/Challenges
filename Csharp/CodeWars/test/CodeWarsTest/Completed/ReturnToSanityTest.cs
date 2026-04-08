using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ReturnToSanityTest
{
    [Test]
    public void Is_It_Sane()
    {
        var sanity = new Dictionary<string, string> { { "sanity", "hello" } };
        Assert.That(ReturnToSanity.Mystery(), Is.EqualTo(sanity), "Mystery has not returned to sanity.");
    }
}
