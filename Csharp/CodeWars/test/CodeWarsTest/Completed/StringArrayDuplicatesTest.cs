using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class StringArrayDuplicatesTest
{
    [Test]
    public void ExampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(StringArrayDuplicates.Dup(new String[] { "ccooddddddewwwaaaaarrrrsssss", "piccaninny", "hubbubbubboo" }), Is.EqualTo(new String[] { "codewars", "picaniny", "hubububo" }));
            Assert.That(StringArrayDuplicates.Dup(new String[] { "abracadabra", "allottee", "assessee" }), Is.EqualTo(new String[] { "abracadabra", "alote", "asese" }));
            Assert.That(StringArrayDuplicates.Dup(new String[] { "kelless", "keenness" }), Is.EqualTo(new String[] { "keles", "kenes" }));
        }
    }
}
