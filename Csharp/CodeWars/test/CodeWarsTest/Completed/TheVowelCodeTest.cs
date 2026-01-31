using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class TheVowelCodeTest
{
    [TestCase("hello", ExpectedResult = "h2ll4")]
    [TestCase("How are you today?", ExpectedResult = "H4w 1r2 y45 t4d1y?")]
    [TestCase("This is an encoding test.", ExpectedResult = "Th3s 3s 1n 2nc4d3ng t2st.")]
    public string Encode(string msg) => TheVowelCode.Encode(msg);

    [TestCase("h2ll4", ExpectedResult = "hello")]
    [TestCase("H4w 1r2 y45 t4d1y?", ExpectedResult = "How are you today?")]
    [TestCase("Th3s 3s 1n 2nc4d3ng t2st.", ExpectedResult = "This is an encoding test.")]
    public string Decode(string msg) => TheVowelCode.Decode(msg);
}
