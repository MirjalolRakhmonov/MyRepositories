using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    abstract class Doctor : Employee
    {
        protected string specialty { get; set; }
        public int GMCnumber { get; }

        public Doctor(string newName, string newSurname, int newIdNumber, string newPassword, string newUsername)
            :base(newName, newSurname, newIdNumber, newPassword,  newUsername)
        {
            this.specialty = specialty;
            GMCnumber = 0453232;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($" Specialty: {this.specialty}");
            //return "Doctor: " + base.Info() + " Specialty: " + this.specialty ;
        }
    }
}
