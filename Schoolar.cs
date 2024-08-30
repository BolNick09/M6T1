using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes
{
    public class Schoolar : Learner
    {
        string className;
        public Schoolar (string firstName, string lastName, DateTime birthDate, string subject, string className)
                        : base (firstName, lastName, birthDate, subject)
        {
            this.className = className;
        }
        public override void think()
        {
            Console.WriteLine("This schoolr thinks");
        }
        public override void study()
        {
            Console.WriteLine("This schoolar studies");
        }
        public override void print()
        {
            base.print();
            Console.WriteLine($"This schoolar goes to {className} class");
        }
    }
}
