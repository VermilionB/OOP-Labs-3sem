using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Laba_4
{
    public class Set<T>
    {
        public class Owner
        {
            private readonly int id;
            public string name;
            public string organization;
           
            public Owner(string name, string organization)
            {
                this.name = name;
                this.organization = organization;
                id = GetHashCode();
            }
 
            public void ShowOwners()
            { 
                Console.WriteLine(
                    $"ID: {id}\n" +
                    $"Name: {name}\n" +
                    $"Organization: {organization}");
            }
        }
        public class Date
        {
            private readonly DateTime time;
            
            public Date()
            {
                time = DateTime.Now;
            }
         
            public void ShowDate() => Console.WriteLine(time);
        }

        public List<T> items = new List<T>();
        public int Count => items.Count;
        public void ShowItems()
        {  
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
        public void AddItem(T item)
        {   
            if (!items.Contains(item))
            {
                items.Add(item);
            }
        }
        public static Set<T> Union(Set<T> set1, Set<T> set2)
        {   // Union of sets. 
            var fin_set = new Set<T>();
            var items_of_fin_set = new List<T>();
            if (set1.items.Count > 0)
            {   
                items_of_fin_set.AddRange(new List<T>(set1.items));
            }
            if (set2.items.Count > 0)
            {   
                items_of_fin_set.AddRange(new List<T>(set2.items));
            }
            
            return fin_set;
        }

        public static Set<T> Intersection(Set<T> set1, Set<T> set2)
        {   // Intersection of sets.
            var fin_set = new Set<T>();
            if (set1.Count < set2.Count)
            {
                foreach (var item in set1.items)
                {   
                    if (set2.items.Contains(item))
                    {
                        fin_set.AddItem(item);
                    }
                }
            }
            else
            {
                foreach (var item in set2.items)
                {   // If an element from the second set is contained in the first set => add it to the result set.
                    if (set1.items.Contains(item))
                    {
                        fin_set.AddItem(item);
                    }
                }
            }
            return fin_set;
        }

        public static bool CheckLength(Set<T> set, int firstD = 1, int secondD = 7)
        {
            if (set.Count >= firstD && set.Count <= secondD)
            {
                return true;
            }
            else return false;
        }

        public static int ShowCount(Set<T> set)
        {
            return set.Count;
        }
        public void CommaAtTheEnd(Set<string> set)
        {   // Adding dot at the end of string.
            for (int i = 0; i < set.Count; i++)
                set.items[i] += ",";
        }


        //Overload operators//////////////

        public static Set<T> operator +(Set<T> set, T item)
        {
            set?.AddItem(item);
            return set;
        }

        public static Set<T> operator +(Set<T> set1, Set<T> set2)
        {
            return Union(set1, set2);
        }

        public static Set<T> operator *(Set<T> set1, Set<T> set2)
        {
            return Intersection(set1, set2);
        }
        public static bool operator true(Set<T> set)
        {
            return CheckLength(set);
        }
        public static bool operator false(Set<T> set)
        {
            return !CheckLength(set);
        }

    }
}
