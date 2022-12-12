using System;

namespace IJ_Buy_crystals
{
    class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystals = 50;
            int numberCrystals;
            int costCrystals;
            Console.WriteLine("В ведите количество золота");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какое количестов крмсталлов вы хотите купить");
            numberCrystals = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Цене кристалла");
            costCrystals = Convert.ToInt32(Console.ReadLine());
            crystals -= numberCrystals;
            numberCrystals *= costCrystals;
            gold -= numberCrystals;
            if (costCrystals > gold)
            {
                Console.WriteLine("Недостаточно золота для покупки кристаллов");
            }
            else
            {
                Console.WriteLine($"остаток золота {gold} остаток кристаллов {crystals}");
            }
        }
    }
}
