using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class RegularBallSuperBallTest
{
    [Test, Order(1)]
    public void DefaultConstructorShouldSetBallTypeToRegular()
    {
        Assert.That(new Ball().BallType, Is.EqualTo("regular"));
    }

    [Test, Order(2)]
    public void ConstructorWithArgumentShouldSetBallTypeAsExpected()
    {
        Assert.That(new Ball("super").BallType, Is.EqualTo("super"));
    }
}
