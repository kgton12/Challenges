using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ArrhGrabscrabTest
{
    [Test, Description("should pass sample test cases")]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ArrhGrabscrab.Grabscrab("trisf", ["first"]), Is.EqualTo(new List<string> { "first" }), "Should have found 'first'");
            Assert.That(ArrhGrabscrab.Grabscrab("oob", ["bob", "baobab"]), Is.EqualTo(new List<string> { }), "Should not have found anything");
            Assert.That(ArrhGrabscrab.Grabscrab("ainstuomn", ["mountains", "hills", "mesa"]), Is.EqualTo(new List<string> { "mountains" }), "Should have found 'mountains'");
            Assert.That(ArrhGrabscrab.Grabscrab("oolp", ["donkey", "pool", "horse", "loop"]), Is.EqualTo(new List<string> { "pool", "loop" }), "Should have found 'pool' and 'loop'");
            Assert.That(ArrhGrabscrab.Grabscrab("ortsp", ["sport", "parrot", "ports", "matey"]), Is.EqualTo(new List<string> { "sport", "ports" }), "Should have found 'sport' and 'ports'");
            Assert.That(ArrhGrabscrab.Grabscrab("ourf", ["one", "two", "three"]), Is.EqualTo(new List<string> { }), "Should not have found anything");
        }
    }
}
