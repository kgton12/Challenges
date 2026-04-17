using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CIsForCodewarsTest
{
    [Test]
    public void SimpleCases()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CIsForCodewars.GenerateC(1), Is.EqualTo("CCCCC\nC\nC\nC\nCCCCC"));

            Assert.That(CIsForCodewars.GenerateC(2), Is.EqualTo(
                "CCCCCCCCCC\nCCCCCCCCCC\nCC\nCC\nCC\nCC\nCC\nCC\nCCCCCCCCCC\nCCCCCCCCCC"
            ));

            Assert.That(CIsForCodewars.GenerateC(3), Is.EqualTo(
                "CCCCCCCCCCCCCCC\nCCCCCCCCCCCCCCC\nCCCCCCCCCCCCCCC\n" +
                "CCC\nCCC\nCCC\nCCC\nCCC\nCCC\nCCC\nCCC\nCCC\n" +
                "CCCCCCCCCCCCCCC\nCCCCCCCCCCCCCCC\nCCCCCCCCCCCCCCC"
            ));

            Assert.That(CIsForCodewars.GenerateC(4), Is.EqualTo(
                "CCCCCCCCCCCCCCCCCCCC\nCCCCCCCCCCCCCCCCCCCC\nCCCCCCCCCCCCCCCCCCCC\nCCCCCCCCCCCCCCCCCCCC\n" +
                "CCCC\nCCCC\nCCCC\nCCCC\nCCCC\nCCCC\nCCCC\nCCCC\nCCCC\nCCCC\nCCCC\nCCCC\n" +
                "CCCCCCCCCCCCCCCCCCCC\nCCCCCCCCCCCCCCCCCCCC\nCCCCCCCCCCCCCCCCCCCC\nCCCCCCCCCCCCCCCCCCCC"
            ));
        }
    }
}
