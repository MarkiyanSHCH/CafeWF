using System;
namespace CafeLib.Models
{
    [Serializable]
    public class Employee : Person
    {
        
        public short stars { get; set; }

        public Employee()
        {

        }

        public Employee(string firstName = " ", string lastName = " ", short age = 0, short stars = 0) : base(firstName, lastName, age)
        {
            this.stars = stars;
            if (stars < 0 || stars > 5)
            {
                throw new Exception("Error: Enter wrong rating");
            }
            
        }

        public void addEmployee(string fsirstName, string lastName, short age, short stars = 0)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.stars = stars;
           
        }

        public override string ToString()
        {
            return $"First Name : {firstName}\nLast Name: {lastName}\nAge : {age}\nStars: {stars}";
        }

        public override string returnStringInfo()
        {
            return $"{firstName} {lastName} {age} {stars}";
        }
    }
}
