using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    public class Animal : IPrintable
    {
        protected string Name { get; private set; }
        private string age { get; set; }

        public Animal(string name, string age)
        {
            Name = name;
            this.age = age;
            if(name==null ||age==null)
            throw new InvalidAnimalException();
        }

        public virtual void Print()
        {
            Console.WriteLine($"{Name} is {age} old .");
        }
    }
}
