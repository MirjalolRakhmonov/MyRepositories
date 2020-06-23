using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zoo Application ! ");
            Console.Write($"Please input the name of the Zoo : ");
            string name = Console.ReadLine();
            Zoo zoo = new Zoo(name);
            //Console.Write("Add lion : ");
            //string lion = Console.ReadLine();
            Console.Write("Add animal : ");
            string annimal = Console.ReadLine();
            Console.WriteLine("Input age : ");
            string age = Console.ReadLine();
            Animal animal = new Animal(annimal, age);
            zoo.AddAnimal(animal);
            zoo.Print();

        }
    }
}
