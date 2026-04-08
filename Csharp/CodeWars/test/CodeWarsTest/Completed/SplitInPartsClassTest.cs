using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SplitInPartsClassTest
{
    [TestCase, Order(1)]
    //Fixed values
    public void SplitString1()
    {
        string str = "supercalifragilisticexpialidocious";
        Assert.That(SplitInPartsClass.SplitInParts(str, 3), Is.EqualTo("sup erc ali fra gil ist ice xpi ali doc iou s"));
    }

    [TestCase, Order(2)]
    //Fixed values
    public void SplitString2()
    {
        string str = "HelloKata";
        Assert.That(SplitInPartsClass.SplitInParts(str, 3), Is.EqualTo("Hel loK ata"));
    }

    [TestCase, Order(3)]
    //Fixed values
    public void SplitString3()
    {
        string str = "HelloKata";
        Assert.That(SplitInPartsClass.SplitInParts(str, 1), Is.EqualTo("H e l l o K a t a"));
    }

    [TestCase, Order(4)]
    //Fixed values
    public void SplitString4()
    {
        string str = "HelloKata";
        Assert.That(SplitInPartsClass.SplitInParts(str, 9), Is.EqualTo("HelloKata"));
    }
}
