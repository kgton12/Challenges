using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class TheySayThatOnlyTheNameIsLongEnoughToAttractAttentionTheyAlsoSaidThatOnlyASimpleTheySayThatOnlyTheNameIsLongEnoughToAttractAttentionTheyAlsoSaidThatOnlyASimpleKataWillHaveSomeoneToSolveItThisIsASadlyStory1AreTheyOppositeWillHaveSomeoneToSolveItThisIsASadlyStory1AreTheyOppositeTest
{
    [Test, Description("Sample Tests")]
    public void SampleTest()
    {
        Assert.That(TheySayThatOnlyTheNameIsLongEnoughToAttractAttentionTheyAlsoSaidThatOnlyASimpleKataWillHaveSomeoneToSolveItThisIsASadlyStory1AreTheyOpposite.IsOpposite("ab", "AB"), Is.True, "ab, AB => true");
        Assert.That(TheySayThatOnlyTheNameIsLongEnoughToAttractAttentionTheyAlsoSaidThatOnlyASimpleKataWillHaveSomeoneToSolveItThisIsASadlyStory1AreTheyOpposite.IsOpposite("aB", "Ab"), Is.True, "aB, Ab => true");
        Assert.That(TheySayThatOnlyTheNameIsLongEnoughToAttractAttentionTheyAlsoSaidThatOnlyASimpleKataWillHaveSomeoneToSolveItThisIsASadlyStory1AreTheyOpposite.IsOpposite("aBcd", "AbCD"), Is.True, "aBcd, AbCD => true");
        Assert.That(TheySayThatOnlyTheNameIsLongEnoughToAttractAttentionTheyAlsoSaidThatOnlyASimpleKataWillHaveSomeoneToSolveItThisIsASadlyStory1AreTheyOpposite.IsOpposite("aBcde", "AbCD"), Is.False, "aBcde, AbCD => false");
        Assert.That(TheySayThatOnlyTheNameIsLongEnoughToAttractAttentionTheyAlsoSaidThatOnlyASimpleKataWillHaveSomeoneToSolveItThisIsASadlyStory1AreTheyOpposite.IsOpposite("AB", "Ab"), Is.False, "AB, Ab => false");
        Assert.That(TheySayThatOnlyTheNameIsLongEnoughToAttractAttentionTheyAlsoSaidThatOnlyASimpleKataWillHaveSomeoneToSolveItThisIsASadlyStory1AreTheyOpposite.IsOpposite("", ""), Is.False, "String.Empty, String.Empty => false");
    }
}
