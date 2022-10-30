namespace Module2_Practice1_HW1
{
    // class that runs in Program class and encapsulates all the work with Store class
    public class Starter
    {
        public static void Run()
        {
            Store store = new Store();
            store.WelcomeMessage(); // Print welcome message
            store.GetCatalog();     // Print the whole list of products

            while (true)
            {
                List<int> productNumbers = new List<int>();
                GetProductNumbers(productNumbers); // Get user's input

                store.HoldProducts(productNumbers); // Temporarily hold products which user chose

                Console.Write("Confirm order? (y/n): ");
                string? answer = Console.ReadLine();

                if (answer == "y")
                {
                    store.SaveOrder(); // Save previously held products

                    Console.Write("Do you want to check your order(s)? (y/n): ");
                    string? answerCheck = Console.ReadLine();

                    if (answerCheck == "y")
                    {
                        store.GetOrdersAll(); // Print each order that user made
                    }

                    Console.Write("Do you wish to make another order? (y/n): ");
                    string? answerAnother = Console.ReadLine();

                    if (answerAnother == "y")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (answer == "n")
                {
                    store.EmptyProducts(); // Clear previously held products
                    continue;
                }
            }

            Console.Write("\nPress any key to continue . . .");
            Console.ReadKey();
        }

        // Get List<int> out of numbers that user input
        private static void GetProductNumbers(List<int> productNumbers)
        {
            while (true)
            {
                Console.Write("\nChoose products (for example: 1 2 5 6 9): ");
                string? userChoice = Console.ReadLine();

                if (userChoice == null)
                {
                    continue;
                }

                string[] userNumbers = userChoice!.Split(' ');

                foreach (string number in userNumbers)
                {
                    if (int.TryParse(number, out int num))
                    {
                        if (num >= 1 && num <= 15)
                        {
                            productNumbers.Add(num);
                        }
                    }
                }

                if (productNumbers.Count == 0)
                {
                    Console.WriteLine("\tYou didn't chose any product or input was incorrect. " +
                        "Products Id must be in range [1..15]");

                    continue;
                }

                break;
            }
        }
    }
}
