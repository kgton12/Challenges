using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CrashOverrideTest
{
    [Test]
    public void BasicTest()
    {
        Dictionary<string[], string> bisics = new()
        {
            {new []{"Mike", "Millington"},  "Mighty Master"},
            {new []{"123abc", "Pinkman"},"Your name must start with a letter from A - Z."}
        };
        foreach (KeyValuePair<string[], string> keyValuePair in bisics)
        {
            Assert.That(CrashOverride.AliasGen(keyValuePair.Key[0], keyValuePair.Key[1]), Is.EqualTo(keyValuePair.Value).IgnoreCase);
        }
    }
}
