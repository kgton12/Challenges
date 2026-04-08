using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ShorterConcatReverseLongerTest
{
    [Test, Order(1)]
    public void ReverLongerTest_1()
    {
        try
        {
            string input_a = "first";
            string input_b = "abcde";
            string expected = "abcdetsrifabcde";

            string actual = ShorterConcatReverseLonger.ShorterReverseLonger(input_a, input_b);

            Assert.That(actual, Is.EqualTo(expected));
        }
        catch (Exception ex)
        {
            Assert.Fail("There seems to be an error in your code. The exception message reads as follow: " + ex.Message);
        }
    }

    [Test, Order(2)]
    public void ReverLongerTest_2()
    {
        try
        {
            string input_a = "hello";
            string input_b = "bau";
            string expected = "bauollehbau";

            string actual = ShorterConcatReverseLonger.ShorterReverseLonger(input_a, input_b);

            Assert.That(actual, Is.EqualTo(expected));
        }
        catch (Exception ex)
        {
            Assert.Fail("There seems to be an error in your code. The exception message reads as follow: " + ex.Message);
        }
    }

    [Test, Order(3)]
    public void ReverLongerTest_3()
    {
        try
        {
            string input_a = "abcde";
            string input_b = "fghi";
            string expected = "fghiedcbafghi";

            string actual = ShorterConcatReverseLonger.ShorterReverseLonger(input_a, input_b);

            Assert.That(actual, Is.EqualTo(expected));
        }
        catch (Exception ex)
        {
            Assert.Fail("There seems to be an error in your code. The exception message reads as follow: " + ex.Message);
        }
    }
}
