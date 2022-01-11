using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laba_16
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //task1
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Task task1 = Task.Run(Vector100000);
            Console.WriteLine("Task 1 ID: " + task1.Id);
            if (task1.IsCompleted)
                Console.WriteLine("Task 1 was completed");
            else Console.WriteLine("Task 1 wasn't completed");
            Console.WriteLine("Task 1 status: " + task1.Status);

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime: " + elapsedTime);
            task1.Wait();

            //task2
            CancellationTokenSource token_source = new CancellationTokenSource();
            CancellationToken token = token_source.Token;
            Task task2 = new Task(() =>
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Операция прервана");
                    return;
                }

                Vector100000();
            });
            task2.Start();

            Console.Write("Enter '0' to cancel the operation > ");
            string s = Console.ReadLine();
            if (s == "0")
                token_source.Cancel();

            Console.WriteLine("Task 1 status: " + task2.Status);

            task2.Wait();

            //task3
            var task3 = new Task<int>[]
            {
                new Task<int>(Task1),
                new Task<int>(Task2),
                new Task<int>(Task3)
            };

            foreach (var task in task3)
            {
                task.Start();
            }
            Task.WaitAll(task3);

            //task4
            var task4 = new Task<int>
                (() =>
                {
                    int res = (int)(Task3() / (Task1() + Task2()));
                    return res;
                });
            task4.Start();
            task4.Wait();
            var cont_task = task4.ContinueWith(res => ContinueTask3(res.Result));
            cont_task.Wait();
            Console.WriteLine("GetAwaiter() + GetResult() -> " + cont_task.GetAwaiter().GetResult());

            //task5
            Random rand = new Random();
            var arr = new int[10000];

            stopWatch.Start();
            Parallel.For(0, arr.Length, (res) =>
            {
                arr[res] = rand.Next(100000) /20;
                Console.WriteLine(arr[res]);

            });
            stopWatch.Stop();
            TimeSpan ts1 = stopWatch.Elapsed;


            var arr1 = new int[10000];
            stopWatch.Start();

            for(int rrr = 0; rrr < arr1.Length; rrr++)
            {
                arr1[rrr] = rand.Next(100000) / 20;
                Console.WriteLine(arr[rrr]);
            }
            stopWatch.Stop();

            TimeSpan ts2 = stopWatch.Elapsed;



            string elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts1.Hours, ts1.Minutes, ts1.Seconds,
                ts1.Milliseconds / 10);
            Console.WriteLine("RunTime: " + elapsedTime1);
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts2.Hours, ts2.Minutes, ts2.Seconds,
                ts2.Milliseconds / 10);
            Console.WriteLine("RunTime: " + elapsedTime2);

            Parallel.ForEach(new int[] { 1, 234, 324, 12, 94, 34302 }, Task5);

            //task6
            Parallel.Invoke(Vector100000, () => Console.WriteLine(Task3()));

            //task7
            BlockingCollection<string> warehouse = new BlockingCollection<string>();
            warehouse.Add("Fridge");
            warehouse.Add("Microwave");
            warehouse.Add("Vacuum cleaner");
            warehouse.CompleteAdding();

            string str;
            while (!warehouse.IsCompleted)
            {
                if (warehouse.TryTake(out str))
                    Console.WriteLine("Consumed string: " + str);
            }

            //task8
            SumOf9();
            Console.WriteLine("Hello, world!");
            Console.WriteLine("Random text");

            Console.ReadKey();
        }
    }
}
