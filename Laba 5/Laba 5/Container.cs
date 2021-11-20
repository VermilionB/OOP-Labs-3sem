using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_5
{
    class Army<T>: IGeneric<T> where T:SentientBeing
    {
        public List<T> list;

        public Army()
        {
            list = new List<T>();
        }
        public object Clone()
        {
            return MemberwiseClone();
        }
       
        public void Add(T item)
        {
            list.Add(item);
        }

        public void SearchByAge()
        {
            Console.WriteLine("Take age of units you want to see:\n");

            int search_age = Convert.ToInt32(Console.ReadLine()); 
            foreach(T item in list)
            {
                if(search_age == item.CountAge())
                {
                    Console.WriteLine("Unit with given age was found.There is info about this unit:\n");
                    Console.WriteLine(item.ToString());
                }
                else
                {
                    throw new Exception("Unit with given age was not found!");
                }
            }
        }

        public void ShowTransformersWithGivenPower()
        {
            Console.WriteLine("Take power of transformers you want to see:\n");
            int search_power = Convert.ToInt32(Console.ReadLine());
            foreach (T item in list)
            {
                if (search_power <= (item as Transformer)?.Power)
                {
                    Console.WriteLine("Unit with given power was found.There is info about this unit:\n");
                    Console.WriteLine(item.ToString());
                }
                else
                {
                    throw new Exception("Transformers with power, bigger than given, was not found!");
                }
            }
        }

        public void Delete(int index)
        {
            try
            {
                list.RemoveAt(index);
            }
            catch
            {
                Console.WriteLine("Incorrect index!");
            }
        }

        public void Show()
        {
            Console.WriteLine("Info about Army: ");
            foreach (T item in list)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine($"Current amount of units in army is: {list.Count}\n");
            Console.WriteLine(new String('-', 20));
        }
    }
}
