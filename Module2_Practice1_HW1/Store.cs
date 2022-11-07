namespace Module2_Practice1_HW1
{
    // Main class that operates another classes (mainly, Cart)
    public class Store
    {
        private Catalog _catalog;
        private Cart _cart;
        public Store()
        {
            _catalog = Catalog.Instance;
            _cart = new Cart();
        }

        // Print welcome message for user
        public void WelcomeMessage()
        {
            Console.WriteLine("................................:Feizalla " +
                "- the cheapest internet store:................................\n");
            Console.WriteLine("List of our products:\n");
        }

        // Print each product of the Internet store (Cart class)
        public void GetCatalog()
        {
            foreach (Product product in _catalog.Products)
            {
                Console.WriteLine($"\t{product.Number}. {product.Name} ({product.Price} UAH)");
            }
        }

        // Temporarily hold products before saving (Cart class)
        public void HoldProducts(int[] productNumbers)
        {
            var products = GenerateProductObjects(productNumbers);
            _cart.HoldProducts(products);
        }

        // Clear previously held products if user changed his mind about buying them (Cart class)
        public void EmptyProducts()
        {
            _cart.EmptyProducts();
        }

        // Save (generate unique OrderId) previously held products (Cart class)
        public void SaveOrder()
        {
            _cart.SaveOrder();
        }

        // Get a unique OrderId and list of products of the latest order (Cart class)
        public void GetOrderLatest()
        {
            string? orderInfo = _cart.GetOrderLatest();

            if (orderInfo == null)
            {
                Console.WriteLine("You haven't created any orders");
            }

            Console.WriteLine(orderInfo);
        }

        // Get a unique OrderId and list of products of the order with a particular OrderId (Cart class)
        public void GetOrderById(int id)
        {
            string? orderInfo = _cart.GetOrderById(id);

            if (orderInfo == null)
            {
                Console.WriteLine("You haven't created any orders");
            }

            Console.WriteLine(orderInfo);
        }

        // Get unique OrderIds and lists of products of the each order (Cart class)
        public void GetOrdersAll()
        {
            string? orderInfo = _cart.GetOrdersAll();

            if (orderInfo == null)
            {
                Console.WriteLine("You haven't created any orders");
            }

            Console.WriteLine(orderInfo);
        }

        // Generate ArrayProduct (Product[]) from user's ArrayInt (int[]): int[] -> ArrayProduct
        private ArrayProduct GenerateProductObjects(int[] productNumbers)
        {
            ArrayProduct products = new ArrayProduct();

            foreach (Product product in _catalog.Products)
            {
                foreach (int num in productNumbers)
                {
                    if (product.Number == num)
                    {
                        products.Add(product);
                    }
                }
            }

            return products;
        }
    }
}
