using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using CafeLib.Models;

namespace CafeLib.Repository.XML
{
    public class Repository<T>:IRepository<T>
    {
        public List<T> Data { get; } = new List<T>();
        protected string FileName = "../../../Data/Xml/";

        public void ReadFromStorage()
        {
            //XmlDocument xDoc = new XmlDocument();
            //xDoc.Load("../../../../Data/Xml/" + FileName);
            //XmlElement xRoot = xDoc.DocumentElement;
            //SpecificRead(xRoot);

            XmlSerializer formatter = new XmlSerializer(typeof(T[]));

            using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                T[] newpeople = (T[])formatter.Deserialize(fs);

                foreach (T p in newpeople)
                {
                    Data.Add(p);
                }
            }

        }

        public void WriteToStorage()
        {
            //XmlDocument xDoc = new XmlDocument();
            //xDoc.Load("../../../../Data/Xml/" + FileName);

            //SpecificWrite(xDoc);
            //xDoc.Save("../../../../Data/Xml/" + FileName);

            XmlSerializer formatter = new XmlSerializer(typeof(List<T>));
            using (FileStream fs = new FileStream(FileName, FileMode.Create))
            {
               
                    formatter.Serialize(fs, Data);
                
            }
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

        //protected abstract void SpecificRead(XmlElement xRoot);

        //protected abstract void SpecificWrite(XmlDocument xDoc);
    }
}
