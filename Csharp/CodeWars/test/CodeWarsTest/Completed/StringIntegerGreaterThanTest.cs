using CodeWars;

namespace CodeWarsTest.Completed;


[TestFixture]
public class StringIntegerGreaterThanTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(StringIntegerGreaterThan.StringIntGreaterThan("31", "162"), Is.False);
            Assert.That(StringIntegerGreaterThan.StringIntGreaterThan("16", "162"), Is.False);
            Assert.That(StringIntegerGreaterThan.StringIntGreaterThan("162", "54"), Is.True);
        }
    }

    [Test]
    public void PositivesTests()
    {
        Test("31", "162", false);
        Test("16", "162", false);
        Test("162", "54", true);
        Test("23", "54", false);
        Test("1234567", "999", true);
        Test("101", "101", false);
    }

    [Test]
    public void NegativesTests()
    {
        Test("-1", "2", false);
        Test("-10", "6", false);
        Test("-1", "-4", true);
        Test("-305", "-1024", true);
        Test("-101", "-101", false);
    }

    [Test]
    public void LargeTests()
    {
        Test("1526569748979641321365465", "3598446654646546", true);
        Test("1329879643513216515489679841651615", "1329879643513216515489679841651614", true);
        Test("1329879643513216515489679841651615", "13298796435132165154896798416516156", false);
        Test("3329879643513216515489679841651615", "3298796435132165154896798416516156", true);
        Test("1329879643513216515489679841651615", "-956189648947395809432803247598442", true);
        Test("1329879643513216515489679841651615", "-4956189648947395809432803247598442", true);
        Test("-1329879643513216515489679841651615", "-956189648947395809432803247598442", false);
        Test("-1329879643513216515489679841651615", "-4956189648947395809432803247598442", true);
        Test("1329879643513216515489679841651615", "1329879643513216515489679841651615", false);
    }
    private static void Test(string a, string b, bool expectedGreater)
    {
        if (a == b)
        {
            Assert.That(StringIntegerGreaterThan.StringIntGreaterThan(a, b), Is.False, "greaterThan(" + a + ", " + b + ") should be false, because " + a + " === " + b);
        }
        else
        {
            using (Assert.EnterMultipleScope())
            {
                Assert.That(StringIntegerGreaterThan.StringIntGreaterThan(a, b), Is.EqualTo(expectedGreater), "greaterThan(" + a + ", " + b + ") should be " + expectedGreater + ", because " + a + " " + (expectedGreater ? ">" : "<") + " " + b);
                Assert.That(StringIntegerGreaterThan.StringIntGreaterThan(b, a), Is.EqualTo(!expectedGreater), "greaterThan(" + b + ", " + a + ") should be " + (!expectedGreater) + ", because " + b + " " + (expectedGreater ? "<" : ">") + " " + a);
            }
        }
    }
}
