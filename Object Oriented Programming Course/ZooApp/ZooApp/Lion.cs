using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    public class Lion : Animal, IPrintable
    {
        private string ManeSize { get; set; }

        public Lion(string name, string age, string maneSize) 
            : base(name, age)
        {
            ManeSize = maneSize;
            if (maneSize == null)
                throw new InvalidLionException();
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Lion : ");
            Console.WriteLine($"Has such a big mane : {ManeSize}");
        }
    }
}
