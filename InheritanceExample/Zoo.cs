using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExample
{
   public class Zoo
    {
        private int animalIndex = 0;
        public Animal[] animals { get; set; }
        public Zoo()
        {
            animals = new Animal[15];
        }
        public void AddAnimals(Animal animal)
        {
            animals[animalIndex++] = animal;
        }

        public void ShowAllAnimal()
        {
            foreach (var t in animals)
            {
                if (t == null) break;
                t.Goes();
            }
        }
        
    }
}
