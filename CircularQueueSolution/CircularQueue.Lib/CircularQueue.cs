namespace CircularQueue.Lib;

public class CircularQueue<T> : ICircularQueue<T>
{
    private T[] _queue;
    private int _count = 0;
    private int _front = 0;
    private int _back = 0;

    public CircularQueue(int maxSize)
    {
        _queue = new T[maxSize];
    }

    public void Enqueue(T item)
    {
        if (IsFull) throw new Exception("The queue is full!");

        int desiredIndex = _back++;

        for (int i = 0; i < _queue.Length; i++)
        {
            if (_queue[i].Equals(0) || _queue[i].Equals(null))
            {
                desiredIndex = i;
                break;
            }
        }

        _queue[desiredIndex] = item;
        ++_count;

    }

    public T Dequeue()
    {
        if (IsEmpty) throw new Exception("The queue is empty");

        T item = _queue[_front];

        if (_queue.GetType() == typeof(int)) _queue.SetValue(0, _front++);
        if (_queue.GetType() == typeof(char)) _queue.SetValue(null, _front++);

        --_count;

        return item;
    }

    public T Front => IsEmpty ? throw new Exception("The queue is empty") : _queue[_front];

    public T Back => IsEmpty ? throw new Exception("The queue is empty") : _queue[_back - 1];

    public void Resize(int newSize)
    {
        T[] newQueue = new T[newSize];

        if (_queue.Length > newSize)
        {
            for (int i = 0; i < newSize; i++)
            {
                newQueue[i] = _queue[i];
            }

            _back = newQueue.Count() - 1;
            _count = newSize - 1;
        }
        else
        {
            for (int i = 0; i < _queue.Length; i++)
            {
                newQueue[i] = _queue[i];
            }
        }

        _front = 0;
        _queue = newQueue;
    }

    public bool IsEmpty => _count == 0;
    public bool IsFull => _count == _queue.Length;
    public int Count => _count;
}