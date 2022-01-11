using System;

namespace Laba_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(User);

            Console.WriteLine(myType.ToString());
            Console.ReadLine();
        }
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public User(string n, int a)
        {
            Name = n;
            Age = a;
        }
        public void Display()
        {
            Console.WriteLine($"Имя: {Name}  Возраст: {Age}");
        }
        public int Payment(int hours, int perhour)
        {
            return hours * perhour;
        }
    }
}
