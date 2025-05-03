namespace task3
{
    public class MyList<T>
    {
        private T[] _items;
        private int _count;

        public MyList()
        {
            _items = new T[4];
            _count = 0;
        }

        public void Add(T item)
        {
            if (_count == _items.Length)
                Array.Resize(ref _items, _items.Length * 2);

            _items[_count++] = item;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
                    throw new IndexOutOfRangeException();
                return _items[index];
            }
        }

        public int Count => _count;
    }
}
