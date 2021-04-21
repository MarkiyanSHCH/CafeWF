using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace CafeLib.Repository.TXT
{


    public abstract class Repository<T> : IRepository<T>
    {
        public delegate void UserMessage(string message);
        public event UserMessage Notify;

        public List<T> Data { get; } = new List<T>();
        protected string FileName = "../../../Data/";

        public void ReadFromStorage()
        {
            if (!File.Exists(FileName))
            {
                throw new Exception($"Error: File({FileName}) not found");
            }
            List<String> lines = new List<string>();
            using (StreamReader sr = new StreamReader(FileName))
            {
                while (!sr.EndOfStream)
                    lines.Add(sr.ReadLine());
            }

            SpecificRead(lines);
            Notify?.Invoke($"File {FileName} Read Successfully");
        }

        public async void WriteToStorage()
        {
            if (!File.Exists(FileName))
            {
                throw new Exception($"Error: File({FileName}) not found");
            }
            using (StreamWriter sw = new StreamWriter(FileName, false))
            {

                SpecificWrite(sw);
            }

            Notify?.Invoke($"File {FileName} Write Successfully");
        }


        public void Add(T tmp)
        {
            Data.Add(tmp);
            WriteToStorage();
        }

        public void Remove(short ind)
        {
            Data.RemoveAt(ind);
            WriteToStorage();
        }

       
       
        protected abstract void SpecificRead(List<String> lines);

        protected abstract void SpecificWrite(StreamWriter sw);

    }
}
