using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wpisz nazwę szpitala: ");
            Hospital employee = new Hospital(Console.ReadLine());
            Console.Write("Wpisz username : ");
            string username = Console.ReadLine();
            Console.Write("Wpisz password : ");
            string password = Console.ReadLine();
            Console.WriteLine("Proszę wpisać pracownika tutaj\n");

            while (true)
            {
                Console.Write("\nWhich types of users in the system: doctor, nurse, administrator ");
                string position = Console.ReadLine();
                Console.Write("\nEnter first name : ");
                string firstName = Console.ReadLine();
                Console.Write("Enter Surname : ");
                string surname = Console.ReadLine();
                Console.WriteLine("Enter ID Number : ");
                int ID = int.Parse(Console.ReadLine());
                switch (position)
                {
                    case "doctor":
                        Doctor doctor = new Doctor(firstName, surname,ID,username,password);
                        //employee.AddEmployee(employee);
                        break;
                    case "administrator":
                        Employee admin = new Employee(firstName, surname, ID, username, password);
                        employee.AddEmployee(employee);
                        if (askForContinue() == true)
                        {
                            continue;
                        }
                        else
                            break;
                    case "nurse":
                        Nurse nurse = new Nurse(firstName, surname, ID, username, password);
                        break;
                }
                Console.Clear();
                employee.DisplayInfo();
                /*if (askForContinue() == true)
                {
                    continue;
                }
                else
                {
                    break;
                }*/
            }
            //Console.Clear();
            //employee.DisplayInfo();
        }

        static public bool askForContinue()
        {
            Console.Write("\nDo you want to add more(y/n): ");
            string ans = Console.ReadLine().ToLower();
            if (ans == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
