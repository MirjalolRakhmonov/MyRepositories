using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolynomialEquations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input points in x  y representation.");
            Console.WriteLine("Type END to finish entering equations");

            int index = 1;

            var exc1 = new ExtraClass();
            try
            {
                while (true)
                {
                    Console.Write($"Eq #{index++}: ");

                    String input = Console.ReadLine();

                    if (input.Trim() == "END")
                        break;


                    ExtraClass.addEquation(new AnotherClass(input));

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured: " + e.Message);
            }

            Console.WriteLine("You have entered following equations:");

            for (int i = 0; i < exc1.Length; i++)
                Console.Write($"Eq #{i}: {exc1.getEquation(i)}\n");

            Console.WriteLine("Result is:");
            exc1.printResults();
        }
    }
    }
}
