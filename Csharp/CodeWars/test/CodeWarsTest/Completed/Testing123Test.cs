using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class Testing123Test
{
    [Test]
    public void basicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(Testing123.Number([]), Is.EqualTo(new List<string>()));
            Assert.That(Testing123.Number(["a", "b", "c"]), Is.EqualTo(new List<string> { "1: a", "2: b", "3: c" }));
            Assert.That(Testing123.Number(["", "", "", "", ""]), Is.EqualTo(new List<string> { "1: ", "2: ", "3: ", "4: ", "5: " }));
        }
    }
}
