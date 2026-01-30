using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class IsThereAVowelInThereTest
{
    [Test, Order(1)]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(IsThereAVowelInThere.IsVow(
                    [118, 117, 120, 121, 117, 98, 122, 97, 120, 106, 104, 116, 113, 114, 113, 120, 106]), Is.EqualTo(
                    new object[] { 118, "u", 120, 121, "u", 98, 122, "a", 120, 106, 104, 116, 113, 114, 113, 120, 106 }));
            Assert.That(IsThereAVowelInThere.IsVow(
                [101, 121, 110, 113, 113, 103, 121, 121, 101, 107, 103]), Is.EqualTo(
                new object[] { "e", 121, 110, 113, 113, 103, 121, 121, "e", 107, 103 }));
        }
    }
}
