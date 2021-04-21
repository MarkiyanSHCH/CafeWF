using System;
namespace CafeLib.Models
{
    [Serializable]
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public short age { get; set; }

        public Person()
        {

        }

        public Person(string FirstName = " ", string LastName = " ", short Age = 0)
        {
            firstName = FirstName;
            lastName = LastName;
            age = Age;
            
        }

        public void addPerson(string firstName, string lastName, short age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }


        public override string ToString()
        {
            return $"First Name : {firstName}\nLast Name: {lastName}\nAge : {age}";
        }

        public virtual string returnStringInfo()
        {
            return $"{firstName} {lastName} {age}";
        }
    }
}
