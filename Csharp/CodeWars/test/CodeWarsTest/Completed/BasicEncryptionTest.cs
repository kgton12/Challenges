using CodeWars.Completed;
using System.Text;

namespace CodeWarsTest.Completed;

[TestFixture]
public class BasicEncryptionTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(BasicEncryption.Encrypt("", 1), Is.EqualTo(""));
            Assert.That(BasicEncryption.Encrypt("a", 1), Is.EqualTo("b"));
            Assert.That(BasicEncryption.Encrypt("please encrypt me", 2), Is.EqualTo("rngcug\"gpet{rv\"og"));
        }
    }

    [Test]
    public void RandomTest()
    {
        Random rnd = new();

        for (int i = 0; i < 100; ++i)
        {
            int rule = rnd.Next(0, 451);
            string text = new char[rnd.Next(1, 40)].Aggregate(new StringBuilder(), (p, c) => { p.Append((char)rnd.Next(0, 256)); return p; }).ToString();
            string expected = BasicEncryption.Encrypt(text, rule);

            Assert.That(BasicEncryption.Encrypt(text, rule), Is.EqualTo(expected));
        }
    }
}
