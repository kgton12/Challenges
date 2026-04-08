using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ExcelSheetColumnNumbersTest
{
    [Test]
    public void Test1()
    {
        Console.WriteLine("****** Basic Tests");
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ExcelSheetColumnNumbers.TitleToNumber("A"), Is.EqualTo(1));
            Assert.That(ExcelSheetColumnNumbers.TitleToNumber("AA"), Is.EqualTo(27));
            Assert.That(ExcelSheetColumnNumbers.TitleToNumber("AZ"), Is.EqualTo(52));
            Assert.That(ExcelSheetColumnNumbers.TitleToNumber("BA"), Is.EqualTo(53));
            Assert.That(ExcelSheetColumnNumbers.TitleToNumber("CODEWARS"), Is.EqualTo(28779382963L));
        }
    }
}
