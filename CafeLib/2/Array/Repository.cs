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

        public async IAsyncEnumerable<T> GetDataAsync()
        {
            for (int i = 0; i < Data.Count; i++)
            {
                yield return Data[i];
            }
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
