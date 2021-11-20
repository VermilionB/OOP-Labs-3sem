using System;
using System.Linq;

namespace Laba_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Set<string>.Owner[] owners = new Set<string>.Owner[3]
            {
                 new Set<string>.Owner("Ilya", "BSTU"),
                 new Set<string>.Owner("Daniil", "BNTU"),
                 new Set<string>.Owner("Egor", "BSUIR")
            };
            Console.WriteLine("List of owners: ");
            foreach (Set<string>.Owner owner in owners)
                owner.ShowOwners();
            Console.Write("\n");

            var current_date = new Set<string>.Date();
            Console.WriteLine("Current date: ");
            current_date.ShowDate();
            Console.Write("\n");

            var set1 = new Set<string>();
            set1.AddItem("Hello");
            set1.AddItem("str");

            var set2 = new Set<string>();
            set2.AddItem("Hello");
            set2.AddItem("stroooooo");
            set2.AddItem("item_of_set2");

            var set3 = new Set<int>() { };
            set3.AddItem(99);
            set3.AddItem(13);
            set3.AddItem(67);
            set3.AddItem(707);
            set3.AddItem(15);
            set3.AddItem(16);
            set3.AddItem(17);
            set3.AddItem(18);
            set3.AddItem(19);
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Add items to set1:");
            (set1 + "new_string").ShowItems();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Union of set1 and set2:");
            (set1 + set2).ShowItems();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Intersection of set1 and set2:");
            (set1 * set2).ShowItems();
            Console.WriteLine("\n");

            //Console.WriteLine("Take lower range: ");
            //int low_r = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Using 'false' operator:");
            if (set1)
            {
                Console.WriteLine("Входит в диапазон");
                set1.ShowItems();
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Не входит в диапазон\n");

            }

            if (set3)
            {
                Console.WriteLine("Входит в диапазон");
                set3.ShowItems();
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Не входит в диапазон\n");

            }
            Console.WriteLine("\n");


            Console.Write($"Конкатенация элементов: "); set1.Concat_setItems();
            Console.WriteLine();
            Console.WriteLine($"Разница между длинами максимальной и минимальной строк: {set3.Difference()}");
            Console.WriteLine($"Размер списка: {set2.Count_setItems()}");
        }
    }
}
