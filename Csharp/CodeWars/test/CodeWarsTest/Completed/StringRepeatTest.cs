using CodeWars.Resolutions;


namespace CodeWarsTest.Completed;

public class StringRepeatTest
{
    [Test(Description = "Fixed Tests"), Order(1)]
    public void FixedTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(StringRepeat.RepeatStr(3, "*"), Is.EqualTo("***"));
            Assert.That(StringRepeat.RepeatStr(5, "#"), Is.EqualTo("#####"));
            Assert.That(StringRepeat.RepeatStr(2, "ha "), Is.EqualTo("ha ha "));
            Assert.That(StringRepeat.RepeatStr(3, ""), Is.EqualTo(""));
            Assert.That(StringRepeat.RepeatStr(0, "mystery"), Is.EqualTo(""));
            Assert.That(StringRepeat.RepeatStr(0, ""), Is.EqualTo(""));
            Assert.That(StringRepeat.RepeatStr(6, "I"), Is.EqualTo("IIIIII"));
            Assert.That(StringRepeat.RepeatStr(5, "Hello"), Is.EqualTo("HelloHelloHelloHelloHello"));
        }
    }
}
