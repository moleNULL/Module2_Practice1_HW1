namespace Module2_Practice1_HW1
{
    // Class that processes orders made in Cart class
    public class Order
    {
        public Order(int id, ArrayProduct orderedProducts)
        {
            OrderId = id;
            OrderedProducts = orderedProducts;
        }

        // unique Id that Cart class generates
        public int OrderId { get; set; }
        public ArrayProduct OrderedProducts { get; set; }
    }
}
