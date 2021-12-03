using Laba_5.Exeptions;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5
{

    abstract class Vehicle
    {
        public bool isActive;
        public string Name { get; set; }
        public string Color { get; set; }
        public string FuelType { get; set; }
        public int Hash { get; set; }

        protected int carCount = 0;
        public override string ToString() => GetType().Name;
        public override int GetHashCode() => carCount * new Random().Next(10, 50);
        public override bool Equals(object obj) => GetType().Name == obj.ToString();
        public abstract void Start();
        public abstract void Stop();
        public int CountAge()
        {
            Console.WriteLine("Take date of creating: ");
            int year = Convert.ToInt32(Console.ReadLine());
            return 2021 - year;
        }

        
        public Vehicle(string name, string fuel, string color)
        {
            Name = name;
            FuelType = fuel;
            Color = color;
        }
        public virtual string Brand => "Mercedes-Benz";
    }

    class Automobile : Vehicle
    {
        private float price = 5000f;
        public override string ToString() => $"New car: {Name}\nFuelType: {FuelType}\nColor: {Color}\nHash: {Hash}\nAge: {this.CountAge()}";

        public Automobile(string name, string fuel, string color) : base(name, fuel, color)
        {
            carCount++;
            Hash = GetHashCode();
        }

        public override void Start()
        {
            isActive = true;
            Console.WriteLine("Car is active");
        }
        public override void Stop()
        {
            isActive = false;
            Console.WriteLine("Car is inactive");
        }

    }

    class Engine : Automobile
    {
        public int HorsePowers { get; set; }
        public int Mileage { get; set; }

        public Engine(string name, int mileage, string fuel,string color, int horsePowers = 0) : base(name, fuel, color)
        {
            Mileage = mileage;
            HorsePowers = horsePowers;
        }

        private void StartEngine() => Console.WriteLine("Start engine...");
        private void StopEngine() => Console.WriteLine("Stop engine...");
        public override string ToString() => $"Name{Name}\nMileage: {Mileage}\nHorse powers: {HorsePowers}\nFuelType: {FuelType}";
    }

    class Controls : Engine
    {
        public bool Movable { get; set; }

        public Controls(string name, int mileage, string fuel, bool movable, string color)
            : base(name, mileage, fuel, color)
        {
            Movable = movable;
        }
        public override string ToString()
        {
            string description = $"Object name: {nameof(Controls)}\n" +
                $"Name: {Name}\n" +
                $"Mileage: {Mileage}\n" +
                $"FuelType: {FuelType}\n" +
                $"Movable: {Movable}";

            return description;
        }
    }
    abstract class SentientBeing : IDescription
    {
        private int hash = 10;
        private static int count = 0;
        private int year = 0;

        public string Name { get; set; }
        public int dateOfBirth { get; set; }
        public int Year {
            get
            {
                return year;
            }
            set
            {
                if (value > 2021)
                {
                    while (value > 2021)
                    {
                        Console.Write("Year is bigger than current year!\nPlease, take correct year >>> ");
                        int correct_year = int.Parse(Console.ReadLine());
                        if (correct_year <= 2021)
                            value = correct_year;
                        year = value;
                    }
                }
                else year = value;
            }
        }
        public static int Count
        {
            get => count;
            set => count = value;
        }
                
        public SentientBeing(string name)
        {
            Name = name;
        }

        public int CountAge()
        {
            return 2021 - Year;
        }

        void IDescription.Print()
        {
            Console.WriteLine("|Interface| This is a sentient being");
        }

        public override int GetHashCode() => hash * new Random().Next(10, 50);
        public override bool Equals(object obj) => GetType().Name == obj.ToString();
        public override string ToString()
        {
            string description = $"Object name: {nameof(SentientBeing)}\n" +
                $"Name: {Name}\n"+ $"Age: {this.CountAge()}";

            return description;
        }

    }

    sealed class Transformer : SentientBeing, IDescription
    {
        public int Power { get; set; }
        public string Type { get; set; }

        private bool isActive;
        public enum TypesOfGun
        {
            pushka, lazer, minigun
        }

        
        public Transformer(string name, string type, int power) : base(name)
        {
            Console.WriteLine("Take date of creating: ");
            Year = Convert.ToInt32(Console.ReadLine());
                    
            Type = type;
            Power = power;
        }
        public void Start()
        {
            isActive = true;
            Console.WriteLine($"{Name} is active");
        }
        public void Stop()
        {
            isActive = false;
            Console.WriteLine($"{Name} is inactive");
        }
        public void Fire(TypesOfGun gun)
        {
            if (isActive == false)
            {
                Console.WriteLine("Tranformer can't fire, beacuse it is inactive");
            }
            else Console.WriteLine($"{Name} is firing with {gun}");
        }
        public override string ToString()
        {
            Console.WriteLine(new String('-', 20));
            return $"Name: {Name}\nAge: {this.CountAge()}\nType: {Type}\nPower: {Power}\n";
        }

        public void Print() => Console.WriteLine(ToString());
    }

    sealed class Human : SentientBeing, IDescription
    {
        public string SkinColor { get; set; }
        public Human(string name, string skin) : base(name)
        {
            Console.WriteLine("Take date of birth: ");
            Year = Convert.ToInt32(Console.ReadLine());
            SkinColor = skin;
        }
        public override string ToString()
        {
            Console.WriteLine(new String('-', 20));
            return $"Name: {Name}\nAge: {this.CountAge()}\nSkin: {SkinColor}\n";
        }

        public void Print()
        {
            this.ToString();
        }
    }
    
}
