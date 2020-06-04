using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Hospital
    {
        private string _name { get; set; }

        private List<Employee> employeeList = new List<Employee>();

        public Hospital(string newName)
        {
            this._name = newName;
        }

        public void AddEmployee(Employee newEmployee) { employeeList.Add(newEmployee); }
        //public void Info(int workerNumber) { employeeList[workerNumber].Info(); }
        /*{
            employeeList.Add(newEmployee);
        }*/

        //public void Info(int empNumber) { employeeList[empNumber].Info(); }

        public void DisplayInfo()
        {
            Console.WriteLine("Witamy w szpitalu: " + this._name + "\nEmployees here: ");

            foreach (Employee employee in employeeList)
            {
                //employee.Info();
                Console.WriteLine(employee.Info());
            }
        }

        /*private bool Info()
        {
            return true;
            //throw new NotImplementedException();
        }*/
    }
}
