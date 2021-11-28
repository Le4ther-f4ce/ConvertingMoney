using System;

namespace ConvertingMoney
{
    class Program
    {
        /*
         * При старте программы пользователь вводит начальное количество золота.
         * Потом ему предлагается купить какое-то количество 
         * кристаллов по цене N(задать в программе самому). 
         * Пользователь вводит число и его золото конвертируется в кристаллы.
         * Остаток золота и кристаллов выводится на экран.
         */
        static void Main(string[] args)
        {
            int priceCrystal = 100;

            Console.Write("Введите количество ваших золотых: ");
            int usersGold = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Цена одного кристала - {priceCrystal},\n" +
                $"сколько кристалов приобрести: ");
            int purchasedCrystals = Convert.ToInt32(Console.ReadLine());

            usersGold -= (purchasedCrystals * priceCrystal);
            Console.WriteLine($"У вас {usersGold}" +
                $" золотых и {purchasedCrystals} кристалов");
        }
    }
}
