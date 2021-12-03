using System;

namespace Laba_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection<string> collection = new Collection<string>();
            string[] items = new string[3];
            items[0] = "Ilya";
            items[1] = "Egor";
            items[2] = "Daniil";
            collection.Add(items[0]);
            collection.Add(items[1]);
            collection.Add(items[2]);
            collection.Show();

            FileStream.WriteToFile(collection);
            Collection<string> from_file_collection = new Collection<string>();
            FileStream.ReadFile(ref from_file_collection);
            from_file_collection.Show();
            
            from_file_collection.Add(items[0]);
            FileStream.WriteToFile(from_file_collection);

            ////////
            Collection<SentientBeing> collection_class = new Collection<SentientBeing>();
            collection_class.Add(new Transformer("bumbla", "ally", 2000));
            collection_class.Add(new Human("Andrew", "white"));
            collection_class.Show();

        }
    }
}
