using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Laba_8.Exeptions;

namespace Laba_8
{
    internal class Collection<T> : IEnumerable<T>, IGeneric<T> where T : class
    {
        private int size;
        public List<T> list;

        public Collection()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            if (GetSize() < 4)
            {
                list.Add(item);
                size++;
            }
            else throw new SizeEx("Collection is full!");
        }
        public void Remove(ref T item) => list?.Remove(item);
        public void Show()
        {
            foreach (T item in list)
                Console.WriteLine(item.ToString());
        }
        public int GetSize() => size;

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)list).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)list).GetEnumerator();
        }
    }
}
