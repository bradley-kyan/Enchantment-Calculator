using EnchantmentCalculator;
using System;
using System.Dynamic;

namespace EnchantmentCalculator
{
    class Header
    {
        public static readonly Header header = new Header();
        public static string Title()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ________________________ ");
            Console.WriteLine("|                        |");
            Console.WriteLine("| Enchantment Calculator |");
            Console.WriteLine("|________________________|");
            Console.ResetColor();
            return "";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            lifeClothing();
        }

        static void lifeClothing()
        {
            try
            {
                lifeCP1 PecentageCalc = new lifeCP1();
                double equipment_Base_price;
                double repair_item_cost;
                string correct = "n";

                Console.Clear();
                Console.WriteLine(Header.Title());
                Console.WriteLine("Enter Life Clothing Upgrade (1, 2, 3, 4, 5)");
                double Upgrade = Convert.ToInt64(Console.ReadLine());
                Console.Clear();

                do
                {

                    Console.WriteLine(Header.Title());
                    Console.WriteLine("Enter Desired Failstacks");
                    lifeCP1.Instance.fs_amount = Convert.ToInt64(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine(Header.Title());
                    Console.WriteLine("Enter Repair Item Cost");
                    repair_item_cost = Convert.ToInt64(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine(Header.Title());
                    Console.WriteLine("Enter Enchantment Item Cost");
                    equipment_Base_price = Convert.ToInt64(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine(Header.Title());
                    Console.WriteLine("Desired Failstacks: " + lifeCP1.Instance.fs_amount);
                    Console.WriteLine("Failstacks Percentage : " + lifeCP1.Percentage(lifeCP1.Instance.fs_amount));
                    Console.WriteLine("'Repair Item' Cost : " + repair_item_cost);
                    Console.WriteLine("'Enchant Item' Cost : " + repair_item_cost);

                    Console.WriteLine();
                    Console.WriteLine("Is This Correct? (Y/N)");
                    correct = Convert.ToString(Console.ReadLine());

                    Console.Clear();

                }
                while (correct == "n");
            }
            catch
            {
                lifeClothing();
            }


        }
    }
}


