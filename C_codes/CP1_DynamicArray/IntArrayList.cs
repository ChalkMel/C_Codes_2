namespace CP1_DynamicArray;

public class IntArrayList
{
    private int[] _buffer;
    private int _count;
    private int _capacity;

    private readonly int _defaultCapacity = 2;

    public int Count => _count;
    public int Capacity => _capacity;

    public int this[int index]
    {
        get => _buffer[index];
        set => _buffer[index] = value;
    }

    public IntArrayList()
    {
        _buffer = new int[_defaultCapacity];
        _capacity = _defaultCapacity;
        _count = 0;
    }

    public IntArrayList(int capacity)
    {
        if (capacity <= 0)
            capacity = _defaultCapacity;

        _buffer = new int[capacity];
        _capacity = capacity;
        _count = 0;
    }

    public void PushBack(int value)
    {
        DoubleCapacity();
        _buffer[_count++] = value;
    }

    public void PopBack()
    {
        if (_count > 0)
            _count--;
    }

    public bool TryInsert(int index, int value)
    {
        if (index < 0 || index > _count)
            return false;

        if (index == _count)
        {
            PushBack(value);
            return true;
        }

        DoubleCapacity();
        
        Array.Copy(_buffer, index, _buffer, index + 1, _count - index);
        _buffer[index] = value;
        _count++;
        return true;
    }

    public bool TryErase(int index)
    {
        if (index < 0 || index >= _count)
            return false;
        
        Array.Copy(_buffer, index + 1, _buffer, index, _count - index - 1);
        _count--;
        return true;
    }

    public bool TryGetAt(int index, out int result)
    {
        if (index < 0 || index >= _count)
        {
            result = 0;
            return false;
        }

        result = _buffer[index];
        return true;
    }

    public void Clear()
    {
        _count = 0;
    }

    public bool TryForceCapacity(int newCapacity)
    {
        if (newCapacity < 0 || newCapacity < _count)
            return false;

        int[] newBuffer = new int[newCapacity];
        Array.Copy(_buffer, 0, newBuffer, 0, _count);
        _buffer = newBuffer;
        _capacity = newCapacity;
        return true;
    }

    public int Find(int value)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_buffer[i] == value)
                return i;
        }
        return -1;
    }

    private void DoubleCapacity()
    {
        if (_count < _capacity)
            return;
        
        int newCapacity = _capacity == 0 ? _defaultCapacity : _capacity * 2;
        int[] newBuffer = new int[newCapacity];
        Array.Copy(_buffer, 0, newBuffer, 0, _count);
        _buffer = newBuffer;
        _capacity = newCapacity;
    }
}