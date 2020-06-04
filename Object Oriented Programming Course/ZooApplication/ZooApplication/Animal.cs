using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApplication
{
    abstract class Animal
    {
        private double age { get; set; }
        protected string Name { get; private set; }

        public Animal(double newAge, string newName)
        {
            this.age = newAge;
            this.Name = newName;
        }

        public virtual void Info()
        {
            Console.WriteLine($"{Name} is {age} old");
        }
    }
}
