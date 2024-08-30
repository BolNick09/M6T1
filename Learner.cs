using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes
{
    public abstract class Learner : Human
    {
        string subject;

        public Learner (string firstName, string lastName, DateTime birthDate, string subject) : base (firstName, lastName, birthDate)
        {
            this.subject = subject;
        }
        public abstract void study(); // ошибка на этапе компиляции, если не определеить метод в дочернем классе
        public override void print()
        {
            base.print();
            Console.WriteLine($"Subject: {subject}");
        }       
    }
}
