using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of animal: ");
            string animalType = Console.ReadLine();

            while (true)
            {

                //case "lion":
                if (animalType == "lion")
                {
                    Console.Write("Please enter the age of lion: ");
                    double age = double.Parse(Console.ReadLine());
                    Console.Write("Please enter the name of lion: ");
                    string name = Console.ReadLine();
                    var lion = new Lion(age, name);
                    lion.Info();
                }
                else
                    Console.WriteLine("Incorrect animal type !");
                break;
                /*default:
                    Console.WriteLine("Wrong input");
                    break;*/
            }

            /*int a = 1;
            int b = 2;
            Console.WriteLine("number {1} and {0}",a,b);*/
        }
    }
}
