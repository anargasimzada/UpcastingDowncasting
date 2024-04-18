using HW_task1.Models;

namespace HW_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Apple apple = new Apple(30, "apple", 20, 5);
            Pineapple pineapple = new Pineapple(15, "pineapple", 90, 60);
            Orange orange = new Orange(60, "orange", 35);

            Fruit[] Basket = { apple, orange, pineapple };




            foreach (var fruit in Basket)
            {



                var types = fruit.GetType().GetFields();
                Console.WriteLine(Basket.GetType);

                foreach (var type in types)
                {
                    Console.WriteLine(type.GetValue(fruit));

                }
            }
        }
    }
}

