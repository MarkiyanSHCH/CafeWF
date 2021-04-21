using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CafeLib.Repository.Array
{
    public class Repository<T>:IRepository<T>
    {
        public List<T> Data { get; } = new List<T>();

        public void Add(T tmp)
        {
            Data.Add(tmp);
        }
        public void Remove(short ind)
        {
            Data.RemoveAt(ind);
        }

       
        void IRepository<T>.ReadFromStorage()
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.WriteToStorage()
        {
            throw new NotImplementedException();
        }
    }
}
