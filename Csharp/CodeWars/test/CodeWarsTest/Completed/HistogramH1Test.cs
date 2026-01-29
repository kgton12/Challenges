using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class HistogramH1Test
{
    [Test]
    public void BasicTest()
    {
        string expected =
        "6|##### 5\n" +
        "5|\n" +
        "4|# 1\n" +
        "3|########## 10\n" +
        "2|### 3\n" +
        "1|####### 7\n";
        Assert.That(HistogramH1.Histogram([7, 3, 10, 1, 0, 5]), Is.EqualTo(expected));
    }
}
