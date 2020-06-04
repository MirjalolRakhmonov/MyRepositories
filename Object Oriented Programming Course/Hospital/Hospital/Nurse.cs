using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Nurse : Employee
    {
        public Nurse(string newName, string newSurname, int newIdNumber, string newPassword, string newUsername) 
            : base(newName, newSurname, newIdNumber, newPassword, newUsername)
        {
        }
    }
}
