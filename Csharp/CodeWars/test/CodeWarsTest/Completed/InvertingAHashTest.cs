using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class InvertingAHashTest
{
    [Test]
    public void BasicTestCases()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(InvertingAHash.InvertHash(new Dictionary<string, string> { { "hello", "world" } }),
                    Is.EqualTo(new Dictionary<string, string> { { "world", "hello" } }));

            Assert.That(InvertingAHash.InvertHash(new Dictionary<string, int> { { "a", 1 }, { "b", 2 }, { "c", 3 } }),
                Is.EqualTo(new Dictionary<int, string> { { 1, "a" }, { 2, "b" }, { 3, "c" } }));

            Assert.That(InvertingAHash.InvertHash(new Dictionary<object, object> { { Tuple.Create(1, 2), "x" }, { "y", Tuple.Create(3, 4) } }),
                Is.EqualTo(new Dictionary<object, object> { { "x", Tuple.Create(1, 2) }, { Tuple.Create(3, 4), "y" } }));
        }
    }
}
