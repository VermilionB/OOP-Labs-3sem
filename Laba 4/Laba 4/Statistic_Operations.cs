using System.Linq;

namespace Laba_4
{
    public static class StatisticOperation
    {
        public static int Count_setItems(this Set<string> set) => set.Count;
        
        public static int Difference(this Set<int> set)
            => set.items.Max() - set.items.Min();

        public static void Concat_setItems(this Set<string> set)
            => set.items.ForEach(x => System.Console.Write(x)); 
    }
}