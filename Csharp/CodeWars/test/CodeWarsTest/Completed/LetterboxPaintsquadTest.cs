using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class LetterboxPaintsquadTest
{
    private static readonly int[] expected = [1, 9, 6, 3, 0, 1, 1, 1, 1, 1];

    [Test, Description("Sample Test")]
    public void ExampleTest()
    {
        Assert.That(LetterboxPaintSquad.PaintLetterBoxes(125, 132).ToArray(), Is.EqualTo(expected));
    }
}
