using System;

namespace Laba_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Printer printer = new Printer();

            //Automobile c200 = new Automobile("c-class", "diesel", "red");
            //c200.TopUp(99999999);
            //Automobile g63 = new Automobile("g-class", "benzine", "black");

            Console.WriteLine("Dates for Transformers\n-------------------\n");

            Transformer[] transformers = new Transformer[3];
            transformers[0] = new Transformer("Bumblebee", "ally", 3000);
            transformers[1] = new Transformer("Optimus", "ally", 5000);
            transformers[2] = new Transformer("Megatron", "enemy", 4000);

            //Transformer bumblebee = new Transformer("BumblebeeZEE", "ally");
            //bumblebee.Start();
            //bumblebee.Fire(Transformer.TypesOfGun.minigun);
            //bumblebee.Stop();
            //Console.WriteLine();
            

            Console.WriteLine("Dates for Humen\n-------------------\n");

            Human[] humen = new Human[3];
            humen[0] = new Human("Andrew", "white");
            humen[1] = new Human("Evgeny", "white");
            humen[2] = new Human("Jordie", "black");

            //foreach (Human man in humen) {
            //    Console.WriteLine(man.ToString());
            //}

            Army<SentientBeing> army = new Army<SentientBeing>();
            army.Add(humen[0]);
            army.Add(humen[2]);
            army.Add(transformers[1]);
            army.Add(transformers[2]);
            army.Show();
            army.Delete(2);
            Console.WriteLine("Info about army after deleting unit:\n\n");
            army.Show();

            army.SearchByAge();
            army.ShowTransformersWithGivenPower();

        }
    }
}
