using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
