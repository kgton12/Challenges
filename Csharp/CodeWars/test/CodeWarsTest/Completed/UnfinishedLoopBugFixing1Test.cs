using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class UnfinishedLoopBugFixing1Test
{
    [Test]
    public static void FixedTest()
    {
        List<int> myValues = [.. new int[] { 1 }];
        Assert.That(UnfinishedLoopBugFixing1.CreateList(1), Is.EqualTo(myValues));

        myValues = [.. new int[] { 1, 2 }];
        Assert.That(UnfinishedLoopBugFixing1.CreateList(2), Is.EqualTo(myValues));

        myValues = [.. new int[] { 1, 2, 3, 4, 5, 6 }];
        Assert.That(UnfinishedLoopBugFixing1.CreateList(6), Is.EqualTo(myValues));
    }
}
