using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class PutALetterInAColumnTest
{
    [TestCase(2, 'A', ExpectedResult = "| | |A| | | | | | |")]
    [TestCase(0, 'A', ExpectedResult = "|A| | | | | | | | |")]
    [TestCase(8, 'A', ExpectedResult = "| | | | | | | | |A|")]
    public static string FixedTest(int index, char character)
    {
        return PutALetterInAColumn.BuildRowText(index, character);
    }
}
