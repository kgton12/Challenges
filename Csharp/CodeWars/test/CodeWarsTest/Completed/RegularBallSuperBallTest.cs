using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class RegularBallSuperBallTest
{
    [Test]
    public void DefaultConstructorShouldSetBallTypeToRegular()
    {
        Assert.That(new Ball().BallType, Is.EqualTo("regular"));
    }

    [Test]
    public void ConstructorWithArgumentShouldSetBallTypeAsExpected()
    {
        Assert.That(new Ball("super").BallType, Is.EqualTo("super"));
    }
}
