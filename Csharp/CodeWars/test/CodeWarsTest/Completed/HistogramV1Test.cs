using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class HistogramV1Test
{
    [Test]
    public void BasicTest()
    {
        string expected =
        "    10\n" +
        "    #\n" +
        "    #\n" +
        "7   #\n" +
        "#   #\n" +
        "#   #     5\n" +
        "#   #     #\n" +
        "# 3 #     #\n" +
        "# # #     #\n" +
        "# # # 1   #\n" +
        "# # # #   #\n" +
        "-----------\n" +
        "1 2 3 4 5 6\n";
        Assert.That(HistogramV1.Histogram([7, 3, 10, 1, 0, 5]), Is.EqualTo(expected));
    }
}