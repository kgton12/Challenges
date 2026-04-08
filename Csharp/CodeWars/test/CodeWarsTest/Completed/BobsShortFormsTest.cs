using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class BobsShortFormsTest
{
    [Test]
    public void TestCase()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(BobsShortForms.ShortForm("typhoid"), Is.EqualTo("typhd"));
            Assert.That(BobsShortForms.ShortForm("fire"), Is.EqualTo("fre"));
            Assert.That(BobsShortForms.ShortForm("destroy"), Is.EqualTo("dstry"));
            Assert.That(BobsShortForms.ShortForm("kata"), Is.EqualTo("kta"));
            Assert.That(BobsShortForms.ShortForm("codewars"), Is.EqualTo("cdwrs"));

            // Should ignore vowels at beginning or end of word
            Assert.That(BobsShortForms.ShortForm("assert"), Is.EqualTo("assrt"));
            Assert.That(BobsShortForms.ShortForm("insane"), Is.EqualTo("insne"));
            Assert.That(BobsShortForms.ShortForm("nice"), Is.EqualTo("nce"));
            Assert.That(BobsShortForms.ShortForm("amazing"), Is.EqualTo("amzng"));
            Assert.That(BobsShortForms.ShortForm("incorrigible"), Is.EqualTo("incrrgble"));

            // Should be case-insenstive
            Assert.That(BobsShortForms.ShortForm("HeEllO"), Is.EqualTo("HllO"));
            Assert.That(BobsShortForms.ShortForm("inCRediBLE"), Is.EqualTo("inCRdBLE"));
            Assert.That(BobsShortForms.ShortForm("IMpOsSiblE"), Is.EqualTo("IMpsSblE"));
            Assert.That(BobsShortForms.ShortForm("UnInTENtiONAl"), Is.EqualTo("UnnTNtNl"));
            Assert.That(BobsShortForms.ShortForm("AWESOme"), Is.EqualTo("AWSme"));

            // Should support input with no vowels
            Assert.That(BobsShortForms.ShortForm("rhythm"), Is.EqualTo("rhythm"));
            Assert.That(BobsShortForms.ShortForm("hymn"), Is.EqualTo("hymn"));
            Assert.That(BobsShortForms.ShortForm("lynx"), Is.EqualTo("lynx"));
            Assert.That(BobsShortForms.ShortForm("nymph"), Is.EqualTo("nymph"));
            Assert.That(BobsShortForms.ShortForm("pygmy"), Is.EqualTo("pygmy"));
        }
    }

}
