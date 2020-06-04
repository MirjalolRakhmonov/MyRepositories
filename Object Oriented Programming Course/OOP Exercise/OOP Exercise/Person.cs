using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise
{
    class Person
    {
        public string FirstName
        {
            get;
            private set;
        }
        public string FamilyName
        {
            get;
            private set;
        }
        public void SetData(string newFirstname, string newFamilyName)
        {
            this.FirstName = newFirstname;
            this.FamilyName = newFamilyName;
        }
        public string IntroduceYourself()
        {
            return $"My name is {this.FirstName}, {this.FamilyName}";
        }
    }
    
}
