using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class MultiplyWordInStringTest
{
    [Test]
    public void MyTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(MultiplyWordInString.ModifyMultiply("is very easy to resolve that kata", 0, 3), Is.EqualTo("is-is-is"), "should return 'is-is-is'");
            Assert.That(MultiplyWordInString.ModifyMultiply("Talk is cheap Show me the code", 2, 4), Is.EqualTo("cheap-cheap-cheap-cheap"), "should return 'cheap-cheap-cheap'");
            Assert.That(MultiplyWordInString.ModifyMultiply("Everyone in this country should learn how to program because it teaches you how to think", 15, 6), Is.EqualTo("think-think-think-think-think-think"), "should return is-is-is");
            Assert.That(MultiplyWordInString.ModifyMultiply("Is sloppiness in code caused by ignorance or apathy? I don't know and I don't care.", 6, 8), Is.EqualTo("ignorance-ignorance-ignorance-ignorance-ignorance-ignorance-ignorance-ignorance"), "should return 'ignorance-ignorance-ignorance-ignorance-ignorance-ignorance-ignorance-ignorance'");
            Assert.That(MultiplyWordInString.ModifyMultiply("Everything happening around me is very random. I am enjoying the phase, as the journey is far more enjoyable than the destination.", 2, 5), Is.EqualTo("around-around-around-around-around"), "should return'around-around-around-around-around'");
        }
    }
}
