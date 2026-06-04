namespace LeetCode.Test
{
    public class ValidParenthesesTest
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("([])", true)]
        [InlineData("([)]", false)]
        public void ValidParentheses_Should_Return_Correct_Values(string s, bool expected)
        {
            var result = ValidParentheses.IsValid(s);

            Assert.Equal(expected, result);
        }
    }
}
