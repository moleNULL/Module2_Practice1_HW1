using System;

namespace Module2_Practice1_HW1
{
    // 3 same Arrays cuz it was required not to use generics
    public class ArrayOrder
    {
        private Order[] _orders;
        private int _size;

        public ArrayOrder()
        {
            _size = 10;
            _orders = new Order[_size];
            Count = 0;
        }

        public int Count { get; private set; }

        public void Add(Order order)
        {
            if (_size - 1 == Count)
            {
                _size *= 2;
                Array.Resize(ref _orders, _size);
            }

            _orders[Count++] = order;
        }

        public Order GetLastElement()
        {
            return _orders[Count];
        }

        public Order[] ToArray()
        {
            // to cut off null elements
            Order[] temp = new Order[Count];
            Array.Copy(_orders, temp, Count);

            return temp;
        }
    }
}
