using System;
using System.Xml;
using CafeLib.Models;

namespace CafeLib.Repository.XML
{
    public class CustomerRep : Repository<Customer>
    {
        public CustomerRep(string _FileName = "Customer.xml")
        {
            base.FileName += _FileName;
            ReadFromStorage();
        }

        ~CustomerRep()
        {
            WriteToStorage();
        }
    }
}
