using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApplication
{
    class Lion : Animal
    {
        private double maneSize { get; set; }

        public Lion(double newAge, string newName)
            : base(newAge, newName)
        {
            this.maneSize = 12121;
        }

        public override void Info()
        {
            Console.WriteLine("Doctor : ");
            Console.WriteLine("Has such a big mane  : ", this.maneSize);
        }
    }
}
