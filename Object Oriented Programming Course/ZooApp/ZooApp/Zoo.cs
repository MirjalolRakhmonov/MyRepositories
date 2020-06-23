using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    public class Zoo : IPrintable
    {
        private List<Animal> animalsList = new List<Animal>();

        private string name { get; set; }

        public Zoo(string name)
        {
            this.name = name;
        }

        public void AddAnimal(Animal animal)
        {
            animalsList.Add(animal);
        }

        public void Print()
        {
            Console.WriteLine($"Welcome to the Zoo : {name}. \nAnimals are here : ");

            foreach (Animal newAnimal in animalsList)
            {
                newAnimal.Print();
            }
        }
    }
}
