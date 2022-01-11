using System;

namespace Laba_12
{
    public partial class CLasses
    {
        public string Number(string num) => num.ToUpper();

        public class Automobile : ICloneable
        {
            public bool isActive { get; set; }
            public int Hash { get; set; }
            public object FuelType { get; set; }
            public object Color { get; set; }
            public object Name { get; set; }

            public Automobile(string name, string fuel, string color)
            {
                Name = name;
                FuelType = fuel;
                Color = color;
                Hash = GetHashCode();
            }
            public Automobile()
            {
                Name = "DONKERVOORT";
                FuelType = "plazma";
                Color = "green";
                Hash = GetHashCode();
            }
            public void Start()
            {
                isActive = true;
                Console.WriteLine("Car is active");
            }
            public void Stop()
            {
                isActive = false;
                Console.WriteLine("Car is inactive");
            }



            public object Clone()
            {
                return MemberwiseClone();
            }
        }

    }
}
