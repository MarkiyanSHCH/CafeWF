using System;
using System.Collections.Generic;
using System.IO;
using CafeLib.Models;

namespace CafeLib.Repository.TXT
{
    public class CustomerRep : Repository<Customer>
    {
        public CustomerRep(string _FileName = "Customer.txt")
        {
            base.FileName += _FileName;
            ReadFromStorage();
        }

        ~CustomerRep()
        {
            WriteToStorage();
        }

        protected override void SpecificRead(List<String> lines)
        {
            foreach (string line in lines)
            {
                string[] tmp = line.Split();

                string firstName = tmp[0];
                string lastName = tmp[1];
                short age = Convert.ToInt16(tmp[2]);
                string address = tmp[3];
                int bonus = Convert.ToInt32(tmp[4]);
                Customer t = new Customer(firstName, lastName, age, address, bonus);
                base.Add(t);
            }
        }

        protected override void SpecificWrite(StreamWriter sw)
        {
            for (int i = 0; i < Data.Count; i++)
            {
                sw.WriteLine(Data[i].returnStringInfo());
            }
        }

        
    }
}
