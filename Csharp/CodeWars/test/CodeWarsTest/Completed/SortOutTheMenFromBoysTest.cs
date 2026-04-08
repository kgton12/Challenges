using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SortOutTheMenFromBoysTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SortOutTheMenFromBoys.MenFromBoys([7, 3, 14, 17]), Is.EqualTo([14, 17, 7, 3]));
            Assert.That(SortOutTheMenFromBoys.MenFromBoys([2, 43, 95, 90, 37]), Is.EqualTo([2, 90, 95, 43, 37]));
            Assert.That(SortOutTheMenFromBoys.MenFromBoys([20, 33, 50, 34, 43, 46]), Is.EqualTo([20, 34, 46, 50, 43, 33]));
            Assert.That(SortOutTheMenFromBoys.MenFromBoys([82, 91, 72, 76, 76, 100, 85]), Is.EqualTo([72, 76, 82, 100, 91, 85]));
            Assert.That(SortOutTheMenFromBoys.MenFromBoys([2, 15, 17, 15, 2, 10, 10, 17, 1, 1]), Is.EqualTo([2, 10, 17, 15, 1]));
            Assert.That(SortOutTheMenFromBoys.MenFromBoys([-32, -39, -35, -41]), Is.EqualTo([-32, -35, -39, -41]));
            Assert.That(SortOutTheMenFromBoys.MenFromBoys([-64, -71, -63, -66, -65]), Is.EqualTo([-66, -64, -63, -65, -71]));
            Assert.That(SortOutTheMenFromBoys.MenFromBoys([-94, -99, -100, -99, -96, -99]), Is.EqualTo([-100, -96, -94, -99]));
            Assert.That(SortOutTheMenFromBoys.MenFromBoys([-53, -26, -53, -27, -49, -51, -14]), Is.EqualTo([-26, -14, -27, -49, -51, -53]));
            Assert.That(SortOutTheMenFromBoys.MenFromBoys([-17, -45, -15, -33, -85, -56, -86, -30]), Is.EqualTo([-86, -56, -30, -15, -17, -33, -45, -85]));
            Assert.That(SortOutTheMenFromBoys.MenFromBoys([12, 89, -38, -78]), Is.EqualTo([-78, -38, 12, 89]));
            Assert.That(SortOutTheMenFromBoys.MenFromBoys([2, -43, 95, -90, 37]), Is.EqualTo([-90, 2, 95, 37, -43]));
            Assert.That(SortOutTheMenFromBoys.MenFromBoys([82, -61, -87, -12, 21, 1]), Is.EqualTo([-12, 82, 21, 1, -61, -87]));
            Assert.That(SortOutTheMenFromBoys.MenFromBoys([63, -57, 76, -85, 88, 2, -28]), Is.EqualTo([-28, 2, 76, 88, 63, -57, -85]));
            Assert.That(SortOutTheMenFromBoys.MenFromBoys([49, 818, -282, 900, 928, 281, -282, -1]), Is.EqualTo([-282, 818, 900, 928, 281, 49, -1]));
        }
    }
}
