using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SortTheGiftCodeTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SortTheGiftCode.SortGiftCode("abcdef"), Is.EqualTo("abcdef"));
            Assert.That(SortTheGiftCode.SortGiftCode("pqksuvy"), Is.EqualTo("kpqsuvy"));
            Assert.That(SortTheGiftCode.SortGiftCode("zyxwvutsrqponmlkjihgfedcba"), Is.EqualTo("abcdefghijklmnopqrstuvwxyz"));
        }
    }
}
