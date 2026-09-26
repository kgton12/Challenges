using LeetCode.Completed;

namespace LeetCode.Test.Completed;

public class ImplementStackUsingQueuesTest
{
    [Fact]
    public void NewStack_Should_Be_Empty()
    {
        var stack = new ImplementStackUsingQueues();

        Assert.True(stack.Empty());
    }

    [Fact]
    public void Push_Should_Make_Stack_NonEmpty()
    {
        var stack = new ImplementStackUsingQueues();

        stack.Push(1);

        Assert.False(stack.Empty());
    }

    [Fact]
    public void Top_Should_Return_Last_Pushed_Value()
    {
        var stack = new ImplementStackUsingQueues();

        stack.Push(1);
        stack.Push(2);

        Assert.Equal(2, stack.Top());
    }

    [Fact]
    public void Pop_Should_Return_Values_In_Lifo_Order()
    {
        var stack = new ImplementStackUsingQueues();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Assert.Equal(3, stack.Pop());
        Assert.Equal(2, stack.Pop());
        Assert.Equal(1, stack.Pop());
    }

    [Fact]
    public void Pop_Should_Remove_Only_The_Top_Value()
    {
        var stack = new ImplementStackUsingQueues();

        stack.Push(1);
        stack.Push(2);

        Assert.Equal(2, stack.Pop());
        Assert.False(stack.Empty());
        Assert.Equal(1, stack.Top());
    }

    [Fact]
    public void Top_Should_Not_Remove_The_Value()
    {
        var stack = new ImplementStackUsingQueues();

        stack.Push(10);

        Assert.Equal(10, stack.Top());
        Assert.Equal(10, stack.Top());
        Assert.False(stack.Empty());
    }

    [Fact]
    public void Stack_Should_Support_Duplicate_Values()
    {
        var stack = new ImplementStackUsingQueues();

        stack.Push(5);
        stack.Push(5);

        Assert.Equal(5, stack.Pop());
        Assert.Equal(5, stack.Pop());
        Assert.True(stack.Empty());
    }

    [Fact]
    public void Stack_Should_Support_Negative_Values()
    {
        var stack = new ImplementStackUsingQueues();

        stack.Push(-10);
        stack.Push(0);
        stack.Push(20);

        Assert.Equal(20, stack.Pop());
        Assert.Equal(0, stack.Pop());
        Assert.Equal(-10, stack.Pop());
        Assert.True(stack.Empty());
    }

    [Fact]
    public void Push_After_Pop_Should_Continue_To_Work()
    {
        var stack = new ImplementStackUsingQueues();

        stack.Push(1);
        stack.Push(2);

        Assert.Equal(2, stack.Pop());

        stack.Push(3);

        Assert.Equal(3, stack.Pop());
        Assert.Equal(1, stack.Pop());
        Assert.True(stack.Empty());
    }
}