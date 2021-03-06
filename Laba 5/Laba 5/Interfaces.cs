using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_5
{
    public interface IGeneric<T>
    {
        void Add(T item);
        void Delete(int index);
        void Show();
    }
    public interface IDescription
    {
        void Print();
        public int CountAge();
    }
}
