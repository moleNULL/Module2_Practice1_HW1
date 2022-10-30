namespace Module2_Practice1_HW1
{
    public class Cart
    {
        private static int _orderId = 0;
        private List<Order> _orders;
        private List<Product>? _products;

        public Cart()
        {
            _orders = new List<Order>();
            _products = new List<Product>();
        }

        // Temporarily hold products before saving
        public void HoldProducts(List<Product> products)
        {
            _products = products;
        }

        // Clear previously held products in case user changed his mind about buying them
        public void EmptyProducts()
        {
            _products = null;
        }

        // Save (generate unique OrderId) previously held products
        public void SaveOrder()
        {
            if (_products == null)
            {
                throw new Exception("Exception! Attempt to save null List<Product>");
            }

            ++_orderId;
            _orders.Add(new Order(_orderId, _products));

            Console.WriteLine($"\t\t\t\t\tOrder #{_orderId} has been successfully created");
        }

        // Get a unique OrderId and list of products of the latest order
        public string? GetOrderLatest()
        {
            if (_orders.Count == 0)
            {
                return null;
            }

            return GetOrderPrintInfo(_orders[^1]);
        }

        // Get a unique OrderId and list of products of the order with a particular OrderId
        public string? GetOrderById(int id)
        {
            Order? currentOrder = null;

            foreach (var order in _orders)
            {
                if (order.OrderId == id)
                {
                    currentOrder = order;
                }
            }

            if (currentOrder == null)
            {
                return null;
            }

            return GetOrderPrintInfo(currentOrder);
        }

        // Get unique OrderIds and lists of products of the each order
        public string? GetOrdersAll()
        {
            if (_orders.Count == 0)
            {
                return null;
            }

            string orderInfo = $"\n  Currently you have {_orders.Count} orders";

            foreach (var order in _orders)
            {
                orderInfo += GetOrderPrintInfo(order);
            }

            return orderInfo;
        }

        // Generate common string which consists of only OrderId and the list of products
        private string GetOrderPrintInfo(Order order)
        {
            string orderInfo = "\n";
            orderInfo += new string('.', 100);
            orderInfo += $"\n\t\t\t\t\tOrder #{order.OrderId}. List of products:\n\n";

            foreach (Product product in order.OrderedProducts!)
            {
                orderInfo += $"\t{product.Number}. {product.Name} ({product.Price} UAH)\n";
            }

            orderInfo += $"\n\t\t\t\t\tTotal price: {TotalPrice(order.OrderedProducts)} UAH\n";
            orderInfo += new string('.', 100);
            orderInfo += "\n";

            return orderInfo;
        }

        // Count total price of the chosen products
        private decimal TotalPrice(List<Product> chosenProducts)
        {
            decimal price = 0;

            foreach (Product product in chosenProducts)
            {
                price += product.Price;
            }

            return price;
        }
    }
}
