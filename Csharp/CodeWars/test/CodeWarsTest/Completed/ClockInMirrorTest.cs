using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ClockInMirrorTest
{
    [Test]
    public void FirstTest()
    {
        Assert.That(ClockInMirror.WhatIsTheTime("05:25"), Is.EqualTo("06:35").IgnoreCase);
    }

    [Test]
    public void SecondTest()
    {
        Assert.That(ClockInMirror.WhatIsTheTime("12:01"), Is.EqualTo("11:59").IgnoreCase);
    }

    [Test]
    public void ThirdTest()
    {
        Assert.That(ClockInMirror.WhatIsTheTime("11:58"), Is.EqualTo("12:02").IgnoreCase);
    }

    [Test]
    public void FourhTest()
    {
        Assert.That(ClockInMirror.WhatIsTheTime("12:00"), Is.EqualTo("12:00").IgnoreCase);
    }

    [Test]
    public void FifthTest()
    {
        Assert.That(ClockInMirror.WhatIsTheTime("10:00"), Is.EqualTo("02:00").IgnoreCase);
    }
}
