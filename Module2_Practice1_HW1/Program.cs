/*
                                                        Задача:
                                        Реалізувати покупку в інтернет магазині.

                                                        Критерії:

● Отримати масив якихось товарів
● Вибрати з масиву декілька товарів для покупки (до 10 шт) і додати в корзину покупок
● Корзина покупок зберігає товари, поки замовлення не сформоване
● Оформити замовлення товарів
● Після оформлення необхідно повідомити покупця про те, що було сформовано замовлення з певним номером

 */

namespace Module2_Practice1_HW1
{
    // Program -> Starter -> Store -> Cart -> Order & Catalog -> Product
    public class Program
    {
        public static void Main(string[] args)
        {
            Starter.Run();

            Console.Write("\nPress any key to continue . . .");
            Console.ReadKey();
        }
    }
}