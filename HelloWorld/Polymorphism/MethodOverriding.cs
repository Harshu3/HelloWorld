using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Polymorphism
{
    internal class Animal
    {
        internal string name;

        public virtual void Run()
        {
            Console.WriteLine("Running slow");
        }
        public void AnimalDetails()
        {
            Console.WriteLine("Name of the animal: " + name);
        }
    }
    class Lion:Animal
    {
        public override void Run()
        {
            Console.WriteLine("Running fast");
        }
    }
}
