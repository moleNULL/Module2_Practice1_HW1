namespace Module2_Practice1_HW1
{
    // Singleton class that contains all the products that Internet Store has
    public class Catalog
    {
        private static Catalog? _catalog = null;

        private Product[] _products = new Product[]
        {
            new Product(1, "iPhone X", 13000),
            new Product(2, "Powerbank Baseus 30000 mAh", 3000),
            new Product(3, "Macbook Air 2022", 53000),
            new Product(4, "Acer Aspire E5", 14500),
            new Product(5, "Sony PlayStation 5", 12000),
            new Product(6, "HDD Western Digital 1Tb", 1900),
            new Product(7, "SSD Samsung EVO 950", 3200),
            new Product(8, "realme Air 3", 2200),
            new Product(9, "Samsung TV UE43AU7100UXUA", 17500),
            new Product(10, "Lenovo Tab M10", 10300),
            new Product(11, "Fridge Whirlpool W7X 81O", 20200),
            new Product(12, "Stove GORENJE MEKS5121W", 14200),
            new Product(13, "NVIDIA RTX3060", 25000),
            new Product(14, "Microsoft Surface Pro 9", 33600),
            new Product(15, "Router TP-LINK Archer AX23", 2500)
        };
        private Catalog()
        {
        }

        public static Catalog Instance
        {
            get
            {
                if (_catalog == null)
                {
                    _catalog = new Catalog();
                }

                return _catalog;
            }
        }

        public Product[] Products
        {
            get
            {
                return _products;
            }
        }
    }
}
