using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class FindTheVowelsTest
{
    [Test, Order(1)]
    public void FixedTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FindTheVowels.VowelIndices("mmm"), Is.EqualTo(Array.Empty<int>()));
            Assert.That(FindTheVowels.VowelIndices("apple"), Is.EqualTo([1, 5]));
            Assert.That(FindTheVowels.VowelIndices("super"), Is.EqualTo([2, 4]));
            Assert.That(FindTheVowels.VowelIndices("orange"), Is.EqualTo([1, 3, 6]));
            Assert.That(FindTheVowels.VowelIndices("supercalifragilisticexpialidocious"), Is.EqualTo([2, 4, 7, 9, 12, 14, 16, 19, 21, 24, 25, 27, 29, 31, 32, 33]));
        }
    }
}
