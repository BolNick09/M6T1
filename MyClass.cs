using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes
{
    public class MyClass : MyInterface
    {
        bool isquest = true;
        public bool isQuest
        { get { return isquest; } }
        public void move()
        {
            Console.WriteLine("Go to the forest");
        }
        public void ask ()
        {
            Console.WriteLine("Quest done");
        }
    }
}
