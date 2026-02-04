using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SpongebobMemeClassTest
{
    private static readonly object[] Basic_Test_Cases =
       [
      new object[] {"stop Making spongebob Memes!", "StOp mAkInG SpOnGeBoB MeMeS!"},
       ];

    [Test, TestCaseSource(typeof(SpongebobMemeClassTest), nameof(Basic_Test_Cases))]
    public void Basic_Test(string test, string expected)
    {
        Assert.That(SpongebobMemeClass.SpongeMeme(test), Is.EqualTo(expected));
    }
}
