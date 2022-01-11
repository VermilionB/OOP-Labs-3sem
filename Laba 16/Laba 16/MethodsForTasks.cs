using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laba_16
{
    partial class Program
    {

        public static void Vector100000()
        {
            Random rand = new Random();
            var arr = new int[100000];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100000) / 20 + rand.Next(2477);
            }
            //new List<int>(100).Select((el) => el * 32).ToList();
        }

        public static int Task1()
        {
            return 123;
        }

        public static int Task2()
        {
            return 231;
        }

        public static int Task3()
        {
            return 321;
        }

        public static int ContinueTask3(int x)
        {
            
            int res = (int)(Math.PI * (x + 2));
            return res;
        }

        public static void Task5(int x)
        {
            Console.WriteLine(x + 129759769);
        }

        public static void Task8()
        {
            int buf = 0;
            for (int i = 0; i < 9; i++)
            {
                buf += i;
            }
            Console.WriteLine("The sum of 9 is " + buf);
        }

        static async void SumOf9()
        {
            Console.WriteLine("SumOf9() start"); // выполняется синхронно
            await Task.Run(() => Task8());                // выполняется асинхронно
            Console.WriteLine("SumOf9() end");
        }
    }
}
