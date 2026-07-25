using CodeWars.Completed;

namespace CodeWarsTest.Completed;

[TestFixture]
public class ClockyMcClockFaceTest
{
    private static readonly object[] Example_Test_Cases =
    [
      new object[] {"12:00", 0},
      new object[] {"12:00", 360},
      new object[] {"03:00", 90},
      new object[] {"06:00", 180},
      new object[] {"09:00", 270},
      new object[] {"01:20", 40},
      new object[] {"01:30", 45},
      new object[] {"01:40", 50},
      new object[] {"11:28", 344.23d},
    ];

    [Test, TestCaseSource(nameof(Example_Test_Cases))]
    public void Example_Test(string expected, double test)
    {
        Assert.That(ClockyMcClockFace.WhatTimeIsIt(test), Is.EqualTo(expected));
    }
}
