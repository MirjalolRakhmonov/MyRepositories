using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    abstract class Employee
    {
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected int IdNumber { get; set; }
        protected string Password { get; set; }
        protected string Username { get; set; }
        //protected string specialty { get; set; }
        //public int GMCnumber { get; }

        public Employee(string newName, string newSurname, int newIdNumber,string newPassword,string newUsername)
        {
            Name = newName;
            Surname = newSurname;
            IdNumber = newIdNumber;
            Password = newPassword;
            Username = newUsername;
        }

        public virtual void Info()
        {
            Console.WriteLine($"{this.Name} {this.Surname} \n{this.IdNumber} \n{this.Username} \n{this.Password} ");
            //return this.Name + " " + this.Surname+ " " +this.IdNumber+" "+this._username+" "+this._password;
        }
    }
}
