using System;

namespace Laba_12
{
    public partial class CLasses
    {
        public class Engine : Automobile
        {
            public int HorsePowers { get; set; }
            public int Mileage { get; set; }

            public Engine(string name, int mileage, string fuel, string color, int horsePowers = 0) : base(name, fuel, color)
            {
                Mileage = mileage;
                HorsePowers = horsePowers;
            }

            public void StartEngine() => Console.WriteLine("Start engine...");
            public void StopEngine() => Console.WriteLine("Stop engine...");
            public override string ToString() => $"Name{Name}\nMileage: {Mileage}\nHorse powers: {HorsePowers}\nFuelType: {FuelType}";
        }
    }
}
