using CodeWars.Completed;

namespace CodeWarsTest.Completed;


[TestFixture]
public class BackspacesInStringTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(BackspacesInString.CleanString("abc#d##c"), Is.EqualTo("ac"));
            Assert.That(BackspacesInString.CleanString("abc####d##c#"), Is.EqualTo(""));
        }
    }

    [Test]
    public void FixedTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(BackspacesInString.CleanString("abjd####jfk#"), Is.EqualTo("jf"));
            Assert.That(BackspacesInString.CleanString("gfh#jds###d#dsd####dasdaskhj###dhkjs####df##s##d##"), Is.EqualTo("gdasda"));
            Assert.That(BackspacesInString.CleanString("831####jns###s#cas/*####-5##s##6+yqw87e##hfklsd-=-28##fds##"), Is.EqualTo("6+yqw8hfklsd-=-f"));
            Assert.That(BackspacesInString.CleanString("######831###dhkj####jd#dsfsdnjkf###d####dasns"), Is.EqualTo("jdsfdasns"));
            Assert.That(BackspacesInString.CleanString(""), Is.EqualTo(""));
            Assert.That(BackspacesInString.CleanString("#######"), Is.EqualTo(""));
            Assert.That(BackspacesInString.CleanString("####gfdsgf##hhs#dg####fjhsd###dbs########afns#######sdanfl##db#####s#a"), Is.EqualTo("sa"));
            Assert.That(BackspacesInString.CleanString("#hskjdf#gd"), Is.EqualTo("hskjdgd"));
            Assert.That(BackspacesInString.CleanString("hsk48hjjdfgd"), Is.EqualTo("hsk48hjjdfgd"));
            Assert.That(BackspacesInString.CleanString("fjnwui#NI#(*N#ION#Onfjen################Io4f"), Is.EqualTo("Io4f"));
            Assert.That(BackspacesInString.CleanString("####6d87hbaskjdnf###$$%W#$@#$2332fr#f"), Is.EqualTo("6d87hbaskj$$%$$2332ff"));
            Assert.That(BackspacesInString.CleanString("#9#9#9#9o#9#9#9#Oooooo#OOOooO#OO######"), Is.EqualTo("9OooooO"));
            Assert.That(BackspacesInString.CleanString("0###0###0"), Is.EqualTo("0"));
            Assert.That(BackspacesInString.CleanString("904rfn#jlkcn#####Djva2###*(#fsdgfd####fsdg###09849###mfenf##dnjn##kmfd;l#mg03###"), Is.EqualTo("904rfDj*fsf09mfednkmfd;m"));
        }
    }
}