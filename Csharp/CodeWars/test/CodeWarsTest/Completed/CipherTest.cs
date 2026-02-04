using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class CipherTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(Cipher.Encode("Hello World!"), Is.EqualTo("ưɞʈʈʚÀȊʚʬʈɘÆ"));
            Assert.That(Cipher.Decode("ưɞʈʈʚÀȊʚʬʈɘÆ"), Is.EqualTo("Hello World!"));
        }
    }
}
