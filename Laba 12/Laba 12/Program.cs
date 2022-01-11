using System;
using static Laba_12.CLasses;

namespace Laba_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Automobile car = new Automobile("Porsche", "Gasoline", "red");
            Console.WriteLine(++i + ". " + Reflector.GetAssemblyVesion());

            Console.WriteLine(++i + ". " + (Reflector.IncludeConstructor(car) ? "Car include public constructor" :
                "Car doesn't include public constructor"));

            Console.Write($"{++i}. ");
            Reflector.GetPublicMethods(car);
            Console.WriteLine();

            Console.Write($"{++i}. ");
            Reflector.GetPropetry(car);
            Reflector.GetFields(car);
            Console.WriteLine();

            Console.Write($"{++i}. ");
            Reflector.GetInterfaces(car);
            Console.WriteLine();

            Console.Write($"{++i}. ");
            Reflector.GetMethodsByParam(car, "Int32");
            Console.WriteLine();

            Console.Write($"{++i}. ");
            Reflector.InvokeFromFile();

            object ob = Reflector.Create("BMW", 20000, "Diesel", "white", 347);
            Console.Write($"{++i}. {(ob as Engine).Name} {(ob as Engine).Mileage} {(ob as Engine).FuelType} {(ob as Automobile).Color} {(ob as Engine).HorsePowers}");
        }
    }
}
