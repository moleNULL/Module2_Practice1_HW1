namespace Module2_Practice1_HW1
{
    public class Product
    {
        public Product(int number, string name, decimal price)
        {
            Number = number;
            Name = name;
            Price = price;
        }

        public int Number { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }
}
