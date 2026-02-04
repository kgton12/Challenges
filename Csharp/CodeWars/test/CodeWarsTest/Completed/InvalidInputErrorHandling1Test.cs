using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class InvalidInputErrorHandling1Test
{
    [Test]
    public static void FixedTest()
    {
        CounterClass re = InvalidInputErrorHandling1.GetCount("Test");
        using (Assert.EnterMultipleScope())
        {
            Assert.That(re.Vowels, Is.EqualTo(1));
            Assert.That(re.Consonants, Is.EqualTo(3));
        }

        re = InvalidInputErrorHandling1.GetCount("Here is some text!");
        using (Assert.EnterMultipleScope())
        {
            Assert.That(re.Vowels, Is.EqualTo(6));
            Assert.That(re.Consonants, Is.EqualTo(8));
        }

        re = InvalidInputErrorHandling1.GetCount("To be a Codewarrior or not to be");
        using (Assert.EnterMultipleScope())
        {
            Assert.That(re.Vowels, Is.EqualTo(12));
            Assert.That(re.Consonants, Is.EqualTo(13));
        }

        re = InvalidInputErrorHandling1.GetCount("To Kata or not to Kata");
        using (Assert.EnterMultipleScope())
        {
            Assert.That(re.Vowels, Is.EqualTo(8));
            Assert.That(re.Consonants, Is.EqualTo(9));
        }

        re = InvalidInputErrorHandling1.GetCount("aeiou");
        using (Assert.EnterMultipleScope())
        {
            Assert.That(re.Vowels, Is.EqualTo(5));
            Assert.That(re.Consonants, Is.Zero);
        }
    }
}
