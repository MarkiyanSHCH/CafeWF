using System;
using System.Xml;
using CafeLib.Models;

namespace CafeLib.Repository.XML
{
    public class EmployeeRep:Repository<Employee>
    {

        public EmployeeRep(string _FileName = "Employee.xml")
        {
            base.FileName += _FileName;
            ReadFromStorage();
        }

        ~EmployeeRep()
        {
            WriteToStorage();
        }

        //protected override void SpecificRead(XmlElement xRoot)
        //{
        //    foreach (XmlNode xnode in xRoot)
        //    {
        //        int Id = 0;
        //        string firstName = "";
        //        string lastName = "";
        //        short age = 0;
        //        short stars = 0;

        //        if (xnode.Attributes.Count > 0)
        //        {
        //            XmlNode attr = xnode.Attributes.GetNamedItem("Id");
        //            if (attr != null)
        //            {
        //                Id = Convert.ToInt32(attr.Value);
        //            }
        //        }

        //        foreach (XmlNode childnode in xnode.ChildNodes)
        //        {

        //            if (childnode.Name == "firstName")
        //            {
        //                firstName = childnode.InnerText;
        //            }

        //            if (childnode.Name == "lastName")
        //            {
        //                lastName = childnode.InnerText;
        //            }

        //            if (childnode.Name == "age")
        //            {
        //                age = Convert.ToInt16(childnode.InnerText);

        //            }
        //            if (childnode.Name == "stars")
        //            {
        //                stars = Convert.ToInt16(childnode.InnerText);
        //            }
        //        }
        //        var t = new Employee(firstName, lastName, age, stars);
        //        base.Add(t);
        //    }
        //}


        //protected override void SpecificWrite(XmlDocument xDoc)
        //{

        //    var xRoot = xDoc.DocumentElement;
        //    xRoot.RemoveAll();

        //    for (int i = 0; i < Data.Count; i++)
        //    {


        //        XmlElement userElem = xDoc.CreateElement("employee");

        //        XmlAttribute idAttr = xDoc.CreateAttribute("Id");

        //        XmlElement firstNameElem = xDoc.CreateElement("firstName");
        //        XmlElement lastNameElem = xDoc.CreateElement("lastName");
        //        XmlElement ageElem = xDoc.CreateElement("age");
        //        XmlElement starsElem = xDoc.CreateElement("stars");

        //        XmlText IdText = xDoc.CreateTextNode(Convert.ToString(i));
        //        XmlText firstNameText = xDoc.CreateTextNode(Data[i].firstName);
        //        XmlText lastNameText = xDoc.CreateTextNode(Data[i].lastName);
        //        XmlText ageText = xDoc.CreateTextNode(Convert.ToString(Data[i].age));
        //        XmlText starsText = xDoc.CreateTextNode(Convert.ToString(Data[i].stars));

        //        idAttr.AppendChild(IdText);
        //        firstNameElem.AppendChild(firstNameText);
        //        lastNameElem.AppendChild(lastNameText);
        //        ageElem.AppendChild(ageText);
        //        starsElem.AppendChild(starsText);
        //        userElem.Attributes.Append(idAttr);
        //        userElem.AppendChild(firstNameElem);
        //        userElem.AppendChild(lastNameElem);
        //        userElem.AppendChild(ageElem);
        //        userElem.AppendChild(starsElem);
        //        xRoot.AppendChild(userElem);


        //    }
        //}



    }
}
