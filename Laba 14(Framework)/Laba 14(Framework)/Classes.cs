//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Laba_14_Framework_
//{
//    public interface IDescription
//    {
//        void Print();
//        public int CountAge();
//    }

//    abstract class SentientBeing : IDescription
//    {
//        private int hash = 10;
//        private static int count = 0;
//        private int year = 0;

//        public string Name { get; set; }
//        public int dateOfBirth { get; set; }
//        public int Year
//        {
//            get
//            {
//                return year;
//            }
//            set
//            {
//                if (value > 2021)
//                {
//                    while (value > 2021)
//                    {
//                        Console.Write("Year is bigger than current year!\nPlease, take correct year >>> ");
//                        int correct_year = int.Parse(Console.ReadLine());
//                        if (correct_year <= 2021)
//                            value = correct_year;
//                        year = value;
//                    }
//                }
//                else year = value;
//            }
//        }
//        public static int Count
//        {
//            get => count;
//            set => count = value;
//        }

//        public SentientBeing(string name)
//        {
//            Name = name;
//        }

//        public int CountAge()
//        {
//            return 2021 - Year;
//        }

//        void IDescription.Print()
//        {
//            Console.WriteLine("|Interface| This is a sentient being");
//        }

//        public override int GetHashCode() => hash * new Random().Next(10, 50);
//        public override bool Equals(object obj) => GetType().Name == obj.ToString();
//        public override string ToString()
//        {
//            string description = $"Object name: {nameof(SentientBeing)}\n" +
//                $"Name: {Name}\n" + $"Age: {this.CountAge()}";

//            return description;
//        }

//    }

//    sealed class Transformer/* : SentientBeing, IDescription*/
//    {
//        private int year = 0;
//        public string Name { get; set; }
//        public int Power { get; set; }
//        public string Type { get; set; }

//        private bool isActive;
//        public enum TypesOfGun
//        {
//            pushka, lazer, minigun
//        }

//        public int Year
//        {
//            get
//            {
//                return year;
//            }
//            set
//            {
//                if (value > 2021)
//                {
//                    while (value > 2021)
//                    {
//                        Console.Write("Year is bigger than current year!\nPlease, take correct year >>> ");
//                        int correct_year = int.Parse(Console.ReadLine());
//                        if (correct_year <= 2021)
//                            value = correct_year;
//                        year = value;
//                    }
//                }
//                else year = value;
//            }
//        }


//        public Transformer(string name, string type, int power)/* : base(name)*/
//        {
//            Console.WriteLine("Take date of creating: ");
//            Year = Convert.ToInt32(Console.ReadLine());
//            Name = name;
//            Type = type;
//            Power = power;
//        }
//        public void Start()
//        {
//            isActive = true;
//            Console.WriteLine($"{Name} is active");
//        }
//        public void Stop()
//        {
//            isActive = false;
//            Console.WriteLine($"{Name} is inactive");
//        }
//        public void Fire(TypesOfGun gun)
//        {
//            if (isActive == false)
//            {
//                Console.WriteLine("Tranformer can't fire, beacuse it is inactive");
//            }
//            else Console.WriteLine($"{Name} is firing with {gun}");
//        }
//        //public override string ToString()
//        //{
//        //    Console.WriteLine(new String('-', 20));
//        //    return $"Name: {Name}\nAge: {this.CountAge()}\nType: {Type}\nPower: {Power}\n";
//        //}

//        //public void Print() => Console.WriteLine(ToString());
//    }

//    sealed class Human : SentientBeing, IDescription
//    {
//        public string SkinColor { get; set; }
//        public Human(string name, string skin) : base(name)
//        {
//            Console.WriteLine("Take date of birth: ");
//            Year = Convert.ToInt32(Console.ReadLine());
//            SkinColor = skin;
//        }
//        public override string ToString()
//        {
//            Console.WriteLine(new String('-', 20));
//            return $"Name: {Name}\nAge: {this.CountAge()}\nSkin: {SkinColor}\n";
//        }

//        public void Print()
//        {
//            this.ToString();
//        }
//    }
//}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_14_Framework_
{
    [Serializable]
    public class Transformer
    {
        public Transformer() { }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Power { get; set; }

        [NonSerialized]
        public int price;

        public Transformer(string name, string type, int power)
        {
            Name = name;
            Type = type;
            Power = power;
        }

        public override string ToString()
        {
            Console.WriteLine(new String('-', 20));
            return $"Name: {Name}\nType: {Type}\nPower: {Power}\n";
        }
    }
}
