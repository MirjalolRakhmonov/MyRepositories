using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApplication
{
    class Zoo
    {
        private string name { get; set; }

        private List<Animal> animalsList = new List<Animal>();

        public Zoo(string newName)
        {
            this.name = newName;
        }

        public void AddAnimal(Animal newAnimal)
        {
            animalsList.Add(newAnimal);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Welcome to the zoo : {name}. Animals here:");
            foreach (var Animal in animalsList)
            {
                Animal.Info();
            }
        }
    }
}
