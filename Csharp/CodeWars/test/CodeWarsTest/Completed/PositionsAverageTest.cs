using CodeWars.Completed;

namespace CodeWarsTest.Completed;

[TestFixture]
internal class PositionsAverageTest
{

    private static void AssertFuzzy(string s, double exp)
    {
        bool inrange;
        double merr = 1e-9;
        double actual = PositionsAverage.PosAverage(s);
        inrange = Math.Abs(actual - exp) <= merr;

        if (inrange == false)
        {
            Console.WriteLine("Expected mean must be near " + exp + ", got " + actual);
        }
        Assert.That(inrange, Is.True);
    }

    [Test]
    public static void Test1()
    {
        AssertFuzzy("466960, 069060, 494940, 060069, 060090, 640009, 496464, 606900, 004000, 944096", 26.6666666667);
        AssertFuzzy("444996, 699990, 666690, 096904, 600644, 640646, 606469, 409694, 666094, 606490", 29.2592592593);
        AssertFuzzy("449404, 099090, 600999, 694460, 996066, 906406, 644994, 699094, 064990, 696046", 24.4444444444);
        AssertFuzzy("660999, 969060, 044604, 009494, 609009, 640090, 994446, 949940, 046999, 609444", 22.9629629630);
        AssertFuzzy("996060, 606494, 964494, 460409, 609449, 969600, 960944, 960006, 666049, 090996", 24.8148148148);

        AssertFuzzy("40664064, 60460960, 00669664, 94040464, 04006499, 00466666, 90966460, 64494990", 29.0178571429);
        AssertFuzzy("64040600, 64464440, 60006040, 49609906, 46664409, 99464446, 90446964, 96940090", 20.5357142857);
        AssertFuzzy("99494909, 60004094, 60090496, 64664669, 49909604, 49999064, 46009964, 44494444", 25.4464285714);
        AssertFuzzy("46904946, 60996660, 64040460, 40449469, 46440460, 96090699, 06600440, 44046966", 27.6785714286);
        AssertFuzzy("46099969, 64096999, 44949949, 06409969, 09064604, 90490494, 04600696, 94469969", 25.8928571429);
        AssertFuzzy("4444444, 4444444, 4444444, 4444444, 4444444, 4444444, 4444444, 4444444", 100);
        AssertFuzzy("0, 0, 0, 0, 0, 0, 0, 0", 100);
        AssertFuzzy("0, 0, 1", 33.3333333333);
    }
}
