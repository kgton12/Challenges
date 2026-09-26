namespace LeetCode;

public class _232ImplementQueueUsingStacks // FIFO FIRST IN FIRST OUT
{
    private readonly Stack<int> _stack;

    public _232ImplementQueueUsingStacks()
    {
        _stack = new();
    }

    public void Push(int x)
    {
        _stack.Push(x);

    }

    public int Pop()
    {


    }

    public int Peek()
    {
    }

    public bool Empty()
    {
        return _stack.Count == 0;
    }
}