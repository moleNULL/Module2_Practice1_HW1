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
                int[] productNumbers = GetProductNumbers(); // Get user's input

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
        }

        // Get int[] out of numbers that user input
        private static int[] GetProductNumbers()
        {
            ArrayInt productNumbers = new ArrayInt();

            while (true)
            {
                Console.Write("\nChoose 1-10 products (for example: 1 2 5 6 9): ");
                string? userChoice = Console.ReadLine();

                // variable to print the numbers of products which won't be stored in this order
                string? overflowChoices = null;

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
                            // user cannot chose over 10 products
                            if (productNumbers.Count < 10)
                            {
                                productNumbers.Add(num);
                            }
                            else
                            {
                                overflowChoices += number + " ";
                            }
                        }
                    }
                }

                if (productNumbers.Count == 0)
                {
                    Console.WriteLine("\tYou didn't chose any product or input was incorrect. " +
                        "Products Id must be in range [1..15]");

                    continue;
                }

                if (overflowChoices != null)
                {
                    Console.WriteLine("Warning! These products will not be " +
                        "added to your cart: " + overflowChoices);
                }

                break;
            }

            return productNumbers.ToArray();
        }
    }
}
