using System;

namespace Module2_Practice1_HW1
{
    // 3 same Arrays cuz it was required not to use generics
    public class ArrayProduct
    {
        private Product[] _products;
        private int _size;

        public ArrayProduct()
        {
            _size = 10;
            _products = new Product[_size];
            Count = 0;
        }

        public int Count { get; private set; }

        public void Add(Product product)
        {
            if (_size - 1 == Count)
            {
                _size *= 2;
                Array.Resize(ref _products, _size);
            }

            _products[Count++] = product;
        }

        public Product[] ToArray()
        {
            // to cut off null elements
            Product[] temp = new Product[Count];
            Array.Copy(_products, temp, Count);

            return temp;
        }
    }
}
