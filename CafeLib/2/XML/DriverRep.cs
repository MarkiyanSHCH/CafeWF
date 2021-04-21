using System;
using System.Xml;
using CafeLib.Models;

namespace CafeLib.Repository.XML
{
    public class DriverRep : Repository<Driver>
    {
        public DriverRep(string _FileName = "Driver.xml")
        {
            base.FileName += _FileName;
            ReadFromStorage();
        }
        ~DriverRep()
        {
            WriteToStorage();
        }
    }
}