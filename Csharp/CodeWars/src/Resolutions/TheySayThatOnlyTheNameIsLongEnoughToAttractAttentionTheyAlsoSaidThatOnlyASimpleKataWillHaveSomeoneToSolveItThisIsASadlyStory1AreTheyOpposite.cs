namespace CodeWars.src.Resolutions;

public class TheySayThatOnlyTheNameIsLongEnoughToAttractAttentionTheyAlsoSaidThatOnlyASimpleKataWillHaveSomeoneToSolveItThisIsASadlyStory1AreTheyOpposite
{
    public static bool IsOpposite(string s1, string s2) =>
        !string.IsNullOrEmpty(s1) && !string.IsNullOrEmpty(s2) &&
        s1.SequenceEqual(s2
                .Select(x => char.IsLower(x) ? char.ToUpper(x) : char.ToLower(x))
        );
}
