namespace LeetCode.Completed;

public class ImplementStackUsingQueues
{
    private readonly Queue<int> _queue;

    public ImplementStackUsingQueues()
    {
        _queue = new Queue<int>();
    }

    public void Push(int x)
    {
        _queue.Enqueue(x);
    }

    public int Pop()
    {
        Queue<int> aux = new();
        int result;

        while (_queue.Count > 1)
            aux.Enqueue(_queue.Dequeue());

        result = _queue.Dequeue();

        while (aux.Count > 0)
            _queue.Enqueue(aux.Dequeue());

        return result;
    }

    public int Top()
    {
        Queue<int> aux = new();
        int result;

        while (_queue.Count > 1)
            aux.Enqueue(_queue.Dequeue());

        result = _queue.Dequeue();

        while (aux.Count > 0)
            _queue.Enqueue(aux.Dequeue());

        _queue.Enqueue(result);

        return result;
    }

    public bool Empty()
    {
        return _queue.Count == 0;
    }
}