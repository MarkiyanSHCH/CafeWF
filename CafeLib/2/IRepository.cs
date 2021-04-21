using System;
using System.Collections.Generic;

namespace CafeLib.Repository
{
    public interface IRepository<T>
    {
        List<T> Data { get; }
        void ReadFromStorage();
        void WriteToStorage();
        void Add(T tmp);
        void Remove(short ind);
    }
}
