namespace LeetCode.Test;

public class SqrtXTest
{
    [Theory]
    [InlineData(4, 2)]
    [InlineData(8, 2)]
    public void SqrtX_Should_Return_Correct_Values(int num, int expected)
    {
        var result = SqrtX.MySqrt(num);

        Assert.Equal(expected, result);
    }
}
