using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class RegexpBasicsParsingPricesTest
{
    [Test]
    public void _0_BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That("".ToCents(), Is.Null);
            Assert.That("1".ToCents(), Is.Null);
            Assert.That("1.23".ToCents(), Is.Null);
            Assert.That("$1".ToCents(), Is.Null);
            Assert.That("$1.23".ToCents(), Is.EqualTo(123));
            Assert.That("$99.99".ToCents(), Is.EqualTo(9999));
            Assert.That("$12345678.90".ToCents(), Is.EqualTo(1234567890));
            Assert.That("$9.69".ToCents(), Is.EqualTo(969));
            Assert.That("$9.70".ToCents(), Is.EqualTo(970));
            Assert.That("$9.71".ToCents(), Is.EqualTo(971));
            Assert.That("$0.69".ToCents(), Is.EqualTo(69));
            Assert.That("$9.69$4.3.7".ToCents(), Is.Null);
            Assert.That("$9.692".ToCents(), Is.Null);
        }
    }
}