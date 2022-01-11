using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_10
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;

    namespace Laba_10
    {
        interface IOrderedDictionary
        {
            public void Add(Product product);
            public void Delete(string a);
            public void Search(string b);
            public void ShowAll();
        }
        public class Shop : IOrderedDictionary
        {
            public string Name { get; set; }
            public List<Product> products = new();
            public void Add(Product product)
            {
                products.Add(product);
            }
            public void ShowAll()
            {
                foreach (var item in products)
                {
                    Console.WriteLine(item.ToString());
                };
            }
            public void Delete(string a)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].Name == a)
                    {
                        products.RemoveAt(i);
                        Console.WriteLine("Товар удален");
                        return;
                    }
                }
                Console.WriteLine("Товар не найден");
            }
            public void Search(string b)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].Name == b)
                    {
                        Console.WriteLine(products[i].ToString());
                        return;
                    }
                }
                Console.WriteLine("Товар не найден");
            }
        }
        public class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public override string ToString()
            {
                return "Название:" + Name + " " + "Цена:" + Price;
            }
        }
        class Program
        {
            static void DelN(ConcurrentBag<int> bag, int n)
            {
                foreach (var item in bag)
                {
                    while (n > 0)
                    {
                        bag.TryTake(out int k);
                        n--;
                    }

                }
            }
            static void ShowBag(ConcurrentBag<int> bag)
            {
                foreach (var item in bag)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            static void BagToList(ConcurrentBag<int> bag, List<int> list)
            {
                int[] a;
                a = bag.ToArray();
                foreach (var item in a)
                {
                    list.Add(item);
                }

            }
            static void ShowList(List<int> list)
            {
                Console.WriteLine("Это List:");
                foreach (var item in list)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            static void FindInList(List<int> list, int a)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == a)
                    {
                        Console.Write("Элемент найден " + list[i] + ",его индекс-" + i);
                        Console.WriteLine();
                        return;
                    }
                }
                Console.WriteLine("Элемент не найден");
            }
            static void ShowObserv(ObservableCollection<Product> a)
            {
                foreach (var item in a)
                {
                    Console.WriteLine(item.ToString() + " ");
                }
                Console.WriteLine();
            }
            static void Main(string[] args)
            {
                Shop green = new() { Name = "Green" };
                Product milk = new() { Name = "Молоко", Price = 2 };
                Product chocolate = new() { Name = "Шоколад", Price = 3 };
                Product meat = new() { Name = "Мясо", Price = 8 };
                Product bisquit = new() { Name = "Печенье", Price = 1 };
                green.Add(bisquit);
                green.Add(milk);
                green.Add(chocolate);
                green.Add(meat);
                green.ShowAll();
                Console.WriteLine("---------------------------------------------------------");
                green.Search("Молоко");
                Console.WriteLine("---------------------------------------------------------");
                green.Delete("Шоколад");
                Console.WriteLine("---------------------------------------------------------");
                green.ShowAll();
                //2 задание 
                Console.WriteLine("---------------------------2 задание-----------------------------");
                ConcurrentBag<int> myBag = new();
                myBag.Add(1);
                myBag.Add(123);
                myBag.Add(584);
                myBag.Add(12);
                myBag.Add(858);
                myBag.Add(432);
                myBag.Add(345);
                ShowBag(myBag);
                DelN(myBag, 3);
                ShowBag(myBag);
                List<int> myList = new();
                BagToList(myBag, myList);
                ShowList(myList);
                FindInList(myList, 123);
                //3 задание 
                Console.WriteLine("---------------------------3 задание-----------------------------");
                ObservableCollection<Product> observ = new();
                observ.Add(milk);
                observ.Add(meat);
                observ.Add(chocolate);
                ShowObserv(observ);
                observ.CollectionChanged += Product_CollectionChanged;
                observ.Add(bisquit);
                ShowObserv(observ);
                observ.RemoveAt(1);
                ShowObserv(observ);
            }
            private static void Product_CollectionChanged(object sender, NotifyCollectionChangedEventArgs eventArgs)
            {
                switch (eventArgs.Action)
                {
                    case NotifyCollectionChangedAction.Add:
                        Product newProduct = eventArgs.NewItems[0] as Product;
                        Console.WriteLine($"Добавлен новый товар: {newProduct.Name}, его цена - {newProduct.Price}");
                        break;
                    case NotifyCollectionChangedAction.Remove:
                        Product oldProduct = eventArgs.OldItems[0] as Product;
                        Console.WriteLine($"Удален товар: {oldProduct.Name}");
                        break;
                }
            }
        }
    }

}
