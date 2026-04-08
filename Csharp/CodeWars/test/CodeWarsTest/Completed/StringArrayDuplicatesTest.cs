using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class StringArrayDuplicatesTest
{
    [Test]
    public void ExampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(StringArrayDuplicates.Dup(["ccooddddddewwwaaaaarrrrsssss", "piccaninny", "hubbubbubboo"]), Is.EqualTo(["codewars", "picaniny", "hubububo"]));
            Assert.That(StringArrayDuplicates.Dup(["abracadabra", "allottee", "assessee"]), Is.EqualTo(["abracadabra", "alote", "asese"]));
            Assert.That(StringArrayDuplicates.Dup(["kelless", "keenness"]), Is.EqualTo(["keles", "kenes"]));
        }
    }
}
