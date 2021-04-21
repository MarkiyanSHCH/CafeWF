using System;
namespace CafeLib.Models
{
    [Serializable]
    public class Customer : Person
    {
        public string address { get; set; }
        public int bonus { get; set; }

        public Customer()
        {

        }

        public Customer(string firstName = " ", string lastName = " ", short age = 0, string address = " ", int bonus = 0) : base(firstName, lastName, age)
        {
            this.address = address;
            this.bonus = bonus;
        }

        public void addCustomer(string firstName, string lastName, short age, string address, int bonus = 0)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.address = address;
            this.bonus = bonus;

        }

        public void addBonus()
        {
            bonus += 100;
        }

        public override string ToString()
        {
            return $"First Name : {firstName}\nLast Name: {lastName}\nAge : {age}\nAddress: {address}\nBonus: {bonus}";
        }

        public override string returnStringInfo()
        {
            return $"{firstName} {lastName} {age} {address} {bonus}";
        }
    }
}
