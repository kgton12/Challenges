using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class FindTheIndexOfTheSecondOccurrenceOfALetterInAStringTest
{
    [Test]
    public void SampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FindTheIndexOfTheSecondOccurrenceOfALetterInAString.SecondSymbol("Hello world!!", 'l'), Is.EqualTo(3), "Find the index of the second symbol \"l\" in the string");
            Assert.That(FindTheIndexOfTheSecondOccurrenceOfALetterInAString.SecondSymbol("Hello world!!", 'o'), Is.EqualTo(7), "Find the index of the second symbol \"o\" in the string");
            Assert.That(FindTheIndexOfTheSecondOccurrenceOfALetterInAString.SecondSymbol("Hello world!!", 'A'), Is.EqualTo(-1), "The symbol \"A\" is not in the string");
            Assert.That(FindTheIndexOfTheSecondOccurrenceOfALetterInAString.SecondSymbol("", 'q'), Is.EqualTo(-1), "The symbol \"q\" is not in the string");
            Assert.That(FindTheIndexOfTheSecondOccurrenceOfALetterInAString.SecondSymbol("Hello", '!'), Is.EqualTo(-1), "The symbol \"!\" is not in the string");
        }
    }
}
