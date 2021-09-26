using System;
using System.Text;
using System.Linq;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise A
            bool Bool = true;
            byte Byte = 250;            // [0, 255]
            sbyte sByte = -120;         // [-128, 127]
            char Char = 'A';
            decimal Decimal = 1.76M;    // Precision 28-29 digits
            double Double = 1.72;       // Precision 15-17 digits
            float Float = 1.72f;        // Precision 6-9 digits
            int Int = 1;
            uint uInt = 1;
            long Long = 9223372036854775807; // [-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807]
            ulong uLong = 9223372036854775808;
            short Short = -32000;
            ushort uShort = 64000;

            Console.WriteLine($"Bool: {Bool}\nByte: {Byte}\nsByte: {sByte}\nChar: {Char}\nDecimal: {Decimal}\n" +
                $"Double: {Double}\nFloat: {Float}\nInt: {Int}\nuInt: {uInt}\nLong: {Long}\nuLong: {uLong}\n" +
                $"Short: {Short}\nuShort: {uShort}");

            byte a = 13; //неявное приведение
            ushort ushortNumber = a;
            sbyte b = -13;
            short shortNumber = b; //знаковый бит копируется в добавленные разряды
            Long = Int;
            Float = Byte;
            Decimal = shortNumber;

            int c = 36;//явное приведение
            float intNumber = (float)c;
            long d = long.Parse("37");
            float e = float.Parse("37,28");
            Console.WriteLine($"Float Parse = {e}");
            decimal f = Convert.ToDecimal(e);
            double g = Convert.ToDouble(c);
            Console.WriteLine($"g = {g}");

            Object FloatBox = Float;
            float unFloatBox = (float)Float;

            var VarFloat = 12.345f;
            Console.WriteLine($"VarFloat = {VarFloat}");

            Nullable<int> NullableInt = null;
            Console.WriteLine($"NullableInt = {NullableInt}");

            //-------------------------------------------------------------------------------------------------Exersice B
            string s1 = "qwerty";
            string s2 = "qwertyu";
            if (String.Compare(s1, s2) == 0)
            {
                Console.WriteLine($"Строки {s1} и {s2} являются идентичными");
            }
            else
            {
                Console.WriteLine($"Строки {s1} и {s2} являются различными");
            }

            string firstStr = "Black";
            string secondStr = "Berry";
            string copy;
            string Company = firstStr + secondStr; //Сцепление строк
            copy = Company; //Копирование строк 
            Console.WriteLine($"Компания = {copy}");
            string substr = Company.Substring(0, 6); //Выделение подстроки 
            Console.WriteLine($"Подстрoка = {substr}\n");
            string Cars = "Mercedes, BMW, Audi, Volkswagen, Aston Martin";
            string[] CarList = Cars.Split(", ");
            Console.WriteLine($"Список автомобилей: \n");
            for(int i = 0; i < CarList.Length; i++)
            {
                Console.WriteLine($"{ i + 1}." + CarList[i]);
            }
            string sub = "voo";       // Вставка подстроки в заданную позицию
            string mainstr = "Donkerrt";
            Console.WriteLine("\n" + mainstr.Substring(0, 6) + sub + mainstr.Remove(0, 6));
            string del = "abcdefvooghijk";
            Console.WriteLine("\n" + del.Replace(sub, ""));   // Удаление подстроки
            //////////////string.IsNullOrEmpty example/////////////////////////////
            string filledstr = "abcdef";
            string emptystr = "";
            string nullstr = null;

            Console.WriteLine("String s1 {0}.", Teststr(filledstr));
            Console.WriteLine("String s2 {0}.", Teststr(emptystr));
            Console.WriteLine("String s3 {0}.", Teststr(nullstr));

            String Teststr(string s)
            {
                if (String.IsNullOrEmpty(s))
                    return "является пустой или null строкой";
                else
                    return String.Format("(\"{0}\") является заполненной строкой", s);
            }

            //////////StringBuilder/////////////////////////////////
            StringBuilder fraze = new StringBuilder("Медленный успех формирует ");
            fraze.Insert(26, "характер, а быстрый приводит к эгоизму!");
            fraze.Remove(54, 11);
            fraze.Append(" в никуда!");
            Console.WriteLine(fraze);

            //-------------------------------------------------------------------------------------------------Exersice C
            int[,] Matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // 3b
            try
            {
                Console.Write("\nСписок автомобилей: ");
                foreach (string s in CarList)
                {
                    Console.Write(s + " ");
                }

                Console.Write("\nВведите позицию: ");
                int Id = Convert.ToInt32(Console.ReadLine());
                if (Id - 1 > Cars.Length)
                {
                    throw new Exception("Неверный индекс!");
                }
                Console.Write("Введите значение: ");
                string Change = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(Change))
                {
                    throw new Exception("Неверное значение!");
                }

                CarList[Id - 1] = Change;
                Console.Write("Новый список фруктов: ");
                foreach (string s in CarList)
                {
                    Console.Write(s + " ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // 3c
            Random Rnd = new Random();
            float[][] SArray = new float[3][];
            SArray[0] = new float[2];
            SArray[1] = new float[3];
            SArray[2] = new float[4];

            Console.WriteLine("\n\nСтупенчатый массив: ");
            for (int i = 0; i < SArray.Length; i++)
            {
                for (int j = 0; j < SArray[i].Length; j++)
                {
                    SArray[i][j] = Convert.ToSingle(Math.Round(Rnd.NextDouble() * 5, 2));
                    Console.Write(SArray[i][j] + "\t");
                }
                Console.WriteLine();
            }

            // 3d
            var VarInt = new int[] { 1, 2, 3, 4, 5 };
            var VarStr = "Abcdefg";

            // 4a - 4b 
            (int, string, char, string, ulong) Cortege = (18, "Александр", 'М', "Мозолевский", 3031666);
            Console.WriteLine("\n--------Информация--------");
            Console.WriteLine("Возраст:         " + Cortege.Item1);
            Console.WriteLine("Имя:             " + Cortege.Item2);
            Console.WriteLine("Пол:             " + Cortege.Item3);
            Console.WriteLine("Фамилия:         " + Cortege.Item4);
            Console.WriteLine("Дом. телефон:    " + Cortege.Item5);

            // Частичный вывод
            Console.WriteLine("\n" + Cortege.Item1 + " " + Cortege.Item3 + " " + Cortege.Item4);

            // 4c
            (var y, var z) = (144, "156");
            Console.WriteLine("\n" + a + " " + b);

            // 4d
            var First = (a: 10, b: "20");
            var Second = (a: 10, b: "20");
            if (First == Second)
            {
                Console.WriteLine("\nКортежи равны!");
            }
            else
            {
                Console.WriteLine("\nКортежи не равны!");
            }

            // 5
            Tuple<int, int, int, char> Collector(int[] num, string str)
            {
                return Tuple.Create(num.Max(), num.Min(), num.Sum(), str[0]);
            }
            int[] ArrToTuple = { 5, 12, 56 };
            string StrToTuple = "ABC";
            Tuple<int, int, int, char> T = Collector(ArrToTuple, StrToTuple);
            Console.WriteLine("\nКортёж: " + T);

            // 6
            void FirstFoo()
            {
                try
                {
                    checked
                    {
                        int x = int.MaxValue;
                        x++;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Произошло переполнение!");
                }
            }

            void SecondFoo()
            {
                try
                {
                    unchecked // Не вызывает OverflowException
                    {
                        int x = int.MaxValue;
                        x++;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Произошло переполнение!");
                }
            }

            FirstFoo();
            SecondFoo();
            Console.ReadKey();
        }
    }
}
