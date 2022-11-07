namespace Module2_Practice1_HW1
{
    // 3 same Arrays cuz it was required not to use generics
    public class ArrayInt
    {
        private int[] _nums;
        private int _size;

        public ArrayInt()
        {
            _size = 10;
            _nums = new int[_size];
            Count = 0;
        }

        public int Count { get; private set; }

        public void Add(int i)
        {
            if (_size - 1 == Count)
            {
                _size *= 2;
                Array.Resize(ref _nums, _size);
            }

            _nums[Count++] = i;
        }

        public int[] ToArray()
        {
            // to cut off 0 elements
            int[] temp = new int[Count];
            Array.Copy(_nums, temp, Count);

            return temp;
        }
    }
}
