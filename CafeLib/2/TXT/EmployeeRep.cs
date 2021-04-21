using System;
using System.Collections.Generic;
using System.IO;
using CafeLib.Models;

namespace CafeLib.Repository.TXT
{
    public class EmployeeRep : Repository<Employee>
    {
        public EmployeeRep(string _FileName = "Employee.txt")
        {
            base.FileName += _FileName;
            ReadFromStorage();
        }

        ~EmployeeRep()
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
                short stars = Convert.ToInt16(tmp[3]);
                Employee t = new Employee(firstName, lastName, age, stars);
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
