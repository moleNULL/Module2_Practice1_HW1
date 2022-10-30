namespace Module2_Practice1_HW1
{
    public class Order
    {
        public Order(int id, List<Product>? orderedProducts)
        {
            OrderId = id;
            OrderedProducts = orderedProducts;
        }

        // unique Id that Cart class generates
        public int OrderId { get; set; }
        public List<Product>? OrderedProducts { get; set; }
    }
}
