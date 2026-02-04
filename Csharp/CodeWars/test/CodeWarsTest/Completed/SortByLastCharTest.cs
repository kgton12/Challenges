using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SortByLastCharTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SortByLastChar.Last("abc cba cab"), Is.EqualTo(["cba", "cab", "abc"]));
            Assert.That(SortByLastChar.Last("bbb ccc aaa ddd"), Is.EqualTo(["aaa", "bbb", "ccc", "ddd"]));
            Assert.That(SortByLastChar.Last("co de wa rs"), Is.EqualTo(["wa", "de", "co", "rs"]));
            Assert.That(SortByLastChar.Last("axa ava asa"), Is.EqualTo(["axa", "ava", "asa"]));

            Assert.That(SortByLastChar.Last("man i need a taxi up to ubud"), Is.EqualTo(["a", "need", "ubud", "i", "taxi", "man", "to", "up"]));

            Assert.That(SortByLastChar.Last("what time are we climbing up the volcano"), Is.EqualTo(["time", "are", "we", "the", "climbing", "volcano", "up", "what"]));

            Assert.That(SortByLastChar.Last("take me to semynak"), Is.EqualTo(["take", "me", "semynak", "to"]));

            Assert.That(SortByLastChar.Last("massage yes massage yes massage"), Is.EqualTo(["massage", "massage", "massage", "yes", "yes"]));

            Assert.That(SortByLastChar.Last("take bintang and a dance please"), Is.EqualTo(["a", "and", "take", "dance", "please", "bintang"]));
        }
    }
}
