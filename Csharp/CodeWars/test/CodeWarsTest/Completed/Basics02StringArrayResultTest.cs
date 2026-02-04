using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class Basics02StringArrayResultTest
{
    [Test, Order(1)]
    public void Smile67KataTest_withoutRandom1()
    {
        Assert.That(Basics02StringArrayResult.CalculateArray("1;2;4;7;11;100;15;451;662;774;2227;11;-120;14446451;662;774;342227;2311;123420;-14446"), Is.EqualTo("745277,32,FALSE"));
    }
    [Test, Order(2)]
    public void Smile67KataTest_withoutRandom2()
    {
        Assert.That(Basics02StringArrayResult.CalculateArray("4wre51;645462;776774;-2227;16165;-456120;14446;5765671;882;477;766;141;100;18;645;dfg;;-100;200"), Is.EqualTo("422706,21,FALSE"));
    }
    [Test, Order(3)]
    public void Smile67KataTest_withoutRandom3()
    {
        Assert.That(Basics02StringArrayResult.CalculateArray("-500;500;1500;-;+;;;abc"), Is.EqualTo("500,5,TRUE"));
    }
}
