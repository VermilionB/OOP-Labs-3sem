using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_8
{
    public interface IGeneric<T>
    {
        void Add(T item);
        void Remove(ref T item);
        void Show();
    }
    public interface IDescription
    {
        void Print();
        public int CountAge();
    }
}
