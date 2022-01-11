using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
namespace Laba_12
{
    public static class Reflector
    {
        public static string GetAssemblyVesion()
            => typeof(Program)
            .Assembly
            .FullName;

        public static bool IncludeConstructor(object ob)
            => Type
            .GetType(ob.ToString())
            .GetConstructors(BindingFlags.Public | BindingFlags.Instance)
            .Length != 0;

        public static void GetPublicMethods(object ob)
            => Type
            .GetType(ob.ToString())
            .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
            .ToList()
            .ForEach(x => Console.Write($"{x.Name} "));

        public static void GetPropetry(object ob)
            => Type
            .GetType(ob.ToString())
            .GetProperties()
            .ToList()
            .ForEach(x => Console.Write($"{x.Name} "));

        public static void GetFields(object ob)
            => Type
            .GetType(ob.ToString())
            .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
            .ToList()
            .ForEach(x => Console.Write($"{x.Name} "));

        public static void GetInterfaces(object ob)
            => Type
            .GetType(ob.ToString())
            .GetInterfaces()
            .ToList()
            .ForEach(x => Console.Write($"{x.Name} "));

        public static void GetMethodsByParam(object ob, string par)
            => Type
            .GetType(ob.ToString())
            .GetMethods()
            .Where(x => x.GetParameters().Any(n => n.ToString() == par))
            .ToList()
            .ForEach(x => Console.Write($"{x.Name} "));

        public static void InvokeFromFile()
        {
            StreamReader sr = new StreamReader(@"D:\УЧЕБА 3 СЕМ\OOP\OOP-Labs-3sem\Laba 12\Laba 12\Invoke.txt");
            Type type = Type.GetType("Laba_12.CLasses");
            List<string> paramValue = new List<string>();
            while (!sr.EndOfStream)
                paramValue.Add(sr.ReadLine());
            
            var method = type.GetMethod(paramValue[1]);
            var obj = Activator.CreateInstance(type);

            var res = method.Invoke(obj, new object[] { paramValue[2] });
            Console.WriteLine(res);
        }

        public static object Create(string name, int mileage, string fuel, string color, int horse)
        {
            Type type = typeof(CLasses.Engine);
            ConstructorInfo info = type.GetConstructor(new Type[] { typeof(string), typeof(int), typeof(string), typeof(string), typeof(int) });
            object obj = info.Invoke(new object[] { name, mileage, fuel, color, horse });

            return obj;
        }
    }
}
