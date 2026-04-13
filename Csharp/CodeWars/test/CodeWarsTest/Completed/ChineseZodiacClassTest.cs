using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ChineseZodiacClassTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ChineseZodiacClass.ChineseZodiac(1965), Is.EqualTo("Wood Snake"));
            Assert.That(ChineseZodiacClass.ChineseZodiac(1938), Is.EqualTo("Earth Tiger"));
            Assert.That(ChineseZodiacClass.ChineseZodiac(1998), Is.EqualTo("Earth Tiger"));
            Assert.That(ChineseZodiacClass.ChineseZodiac(2016), Is.EqualTo("Fire Monkey"));
            Assert.That(ChineseZodiacClass.ChineseZodiac(1924), Is.EqualTo("Wood Rat"));
            Assert.That(ChineseZodiacClass.ChineseZodiac(1968), Is.EqualTo("Earth Monkey"));
            Assert.That(ChineseZodiacClass.ChineseZodiac(2162), Is.EqualTo("Water Dog"));
        }
    }
}
