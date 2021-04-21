using System;
namespace CafeLib.Models
{
    [Serializable]
    public class Driver : Employee
    {
        public string car { get; set; }

        public Driver()
        {

        }

        public Driver(string firstName = " ", string lastName = " ", short age = 0, short stars = 0,
            string car = " ") : base(firstName, lastName, age, stars)
        {
            this.car = car;
        }

        public void addDriver(string firstName, string lastName, short age, short stars, string car)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.stars = stars;
            this.car = car;
        }

        public override string ToString()
        {
            return $"First Name : {firstName}\nLast Name: {lastName}\nAge : {age}\nStars: {stars}\nCar: {car}";
            
        }

        public override string returnStringInfo()
        {
            return $"{firstName} {lastName} {age} {stars} {car}";
        }
    }
}
