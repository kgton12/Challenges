using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ExclamationMarksSeries13CountTheNumberOfExclamationMarksAndQuestionMarksReturnTheProductTest
{
    [Test]
    public void MyTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ExclamationMarksSeries13CountTheNumberOfExclamationMarksAndQuestionMarksReturnTheProduct.Product(""), Is.Zero);
            Assert.That(ExclamationMarksSeries13CountTheNumberOfExclamationMarksAndQuestionMarksReturnTheProduct.Product("!?"), Is.EqualTo(1));
            Assert.That(ExclamationMarksSeries13CountTheNumberOfExclamationMarksAndQuestionMarksReturnTheProduct.Product("!??"), Is.EqualTo(2));
            Assert.That(ExclamationMarksSeries13CountTheNumberOfExclamationMarksAndQuestionMarksReturnTheProduct.Product("!!?"), Is.EqualTo(2));
            Assert.That(ExclamationMarksSeries13CountTheNumberOfExclamationMarksAndQuestionMarksReturnTheProduct.Product("!!???"), Is.EqualTo(6));
            Assert.That(ExclamationMarksSeries13CountTheNumberOfExclamationMarksAndQuestionMarksReturnTheProduct.Product("!!!??"), Is.EqualTo(6));
            Assert.That(ExclamationMarksSeries13CountTheNumberOfExclamationMarksAndQuestionMarksReturnTheProduct.Product("!!??"), Is.EqualTo(4));
            Assert.That(ExclamationMarksSeries13CountTheNumberOfExclamationMarksAndQuestionMarksReturnTheProduct.Product("!????"), Is.EqualTo(4));
            Assert.That(ExclamationMarksSeries13CountTheNumberOfExclamationMarksAndQuestionMarksReturnTheProduct.Product("!!!!?"), Is.EqualTo(4));
            Assert.That(ExclamationMarksSeries13CountTheNumberOfExclamationMarksAndQuestionMarksReturnTheProduct.Product("!?????"), Is.EqualTo(5));
            Assert.That(ExclamationMarksSeries13CountTheNumberOfExclamationMarksAndQuestionMarksReturnTheProduct.Product("!!????!!?"), Is.EqualTo(20));
            Assert.That(ExclamationMarksSeries13CountTheNumberOfExclamationMarksAndQuestionMarksReturnTheProduct.Product("!!???????!!!!!"), Is.EqualTo(49));
            Assert.That(ExclamationMarksSeries13CountTheNumberOfExclamationMarksAndQuestionMarksReturnTheProduct.Product("!!???????????!!!!!?!?!?!?!"), Is.EqualTo(165));
            Assert.That(ExclamationMarksSeries13CountTheNumberOfExclamationMarksAndQuestionMarksReturnTheProduct.Product("!!aabbcc??"), Is.EqualTo(4));
            Assert.That(ExclamationMarksSeries13CountTheNumberOfExclamationMarksAndQuestionMarksReturnTheProduct.Product("! !aa bb   c c??   "), Is.EqualTo(4));
        }
    }
}
