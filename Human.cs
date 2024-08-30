using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes
{
    public abstract class Human
    {
        string firstName;
        string lastName;
        DateTime birthDate;

        public Human (string firstName, string lastName, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }
        public abstract void think();
        public virtual void print()
        {
            Console.WriteLine($"Last name: {lastName} first Name: {firstName} date of birth: {birthDate.ToLongDateString()}");
        }
    }
}
