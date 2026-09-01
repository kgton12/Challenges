using CodeWars.Completed;
using System.Text;

namespace CodeWarsTest.Completed;

public class CircleCipherTest
{
    [Test, Order(1)]
    public void EncodeBasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CircleCipher.Encode("codewars"), Is.EqualTo("csordaew"));
            Assert.That(CircleCipher.Encode("white"), Is.EqualTo("wehti"));
            Assert.That(CircleCipher.Encode("Assert"), Is.EqualTo("Atsrse"));
            Assert.That(CircleCipher.Encode("Hello world!"), Is.EqualTo("H!edlllroo w"));
            Assert.That(CircleCipher.Encode("You have chosen to translate this kata."), Is.EqualTo("Y.oaut ahka vsei hcth oesteanl stnoa rt"));
        }
    }

    [Test, Order(2)]
    public void TrickyTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CircleCipher.Decode(""), Is.EqualTo(""));
            Assert.That(CircleCipher.Decode("a"), Is.EqualTo("a"));
            Assert.That(CircleCipher.Decode("or"), Is.EqualTo("or"));
            Assert.That(CircleCipher.Decode(""), Is.EqualTo(""));
            Assert.That(CircleCipher.Decode("a"), Is.EqualTo("a"));
            Assert.That(CircleCipher.Decode("or"), Is.EqualTo("or"));
        }

    }

    [Test, Order(3)]
    public void DecodeBasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CircleCipher.Decode("csordaew"), Is.EqualTo("codewars"));
            Assert.That(CircleCipher.Decode("wehti"), Is.EqualTo("white"));
            Assert.That(CircleCipher.Decode("Atsrse"), Is.EqualTo("Assert"));
            Assert.That(CircleCipher.Decode("H!edlllroo w"), Is.EqualTo("Hello world!"));
            Assert.That(CircleCipher.Decode("Y.oaut ahka vsei hcth oesteanl stnoa rt"), Is.EqualTo("You have chosen to translate this kata."));
        }
    }

    private static string RandomStr()
    {
        var chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789 ";
        var s = new StringBuilder();
        var random = new Random();
        var boundary = random.Next(30) + 1;
        for (var i = 0; i < boundary; i++)
        {
            s.Append(chars[random.Next(chars.Length - 1)]);
        }
        return s.ToString();
    }

    [Test, Order(4)]
    public void EncodeRandomTests()
    {
        for (int i = 0; i < 500; i++)
        {
            var s = RandomStr();
            var expected = Encode(s);
            Assert.That(CircleCipher.Encode(s), Is.EqualTo(expected));
        }
    }

    [Test, Order(5)]
    public void DecodeRandomTests()
    {
        for (var i = 0; i < 500; i++)
        {
            var s = RandomStr();
            var expected = Decode(s);
            Assert.That(CircleCipher.Decode(s), Is.EqualTo(expected));
        }
    }

    private static string Encode(string s)
    {
        var n = s.Length;
        var result = new StringBuilder();
        var i1 = 0;
        var i2 = n - 1;
        for (var i = 0; i < n; i++)
        {
            result.Append(i % 2 == 0 ? s[i1++] : s[i2--]);
        }
        return result.ToString();
    }

    private static string Decode(string s)
    {
        var n = s.Length;
        var result = new StringBuilder();
        var boundary = (int)Math.Ceiling((decimal)n / 2);
        for (var i = 0; i < boundary; i++)
        {
            result.Append(s[i * 2]);
        }
        var i2 = ((int)(n / 2)) * 2 - 1;
        for (var i = boundary; i < n; i++)
        {
            result.Append(s[i2]);
            i2 -= 2;
        }
        return result.ToString();
    }
}