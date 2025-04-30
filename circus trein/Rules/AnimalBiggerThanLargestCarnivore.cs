using CircusTrein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circus_trein.Rules
{
    internal class AnimalBiggerThanLargestCarnivore : ICartConstraint
    {
        public bool CanAddAnimal(Animal animal, Cart cart)
        {
            return ComepareToLargestCarnavor(animal, cart.animals);
        }

        private bool ComepareToLargestCarnavor(Animal Animal, List<Animal> animals)
        {
            return !animals.Any<Animal>(a => a.IsCarnivor && Animal.AnimalSize <= a.AnimalSize);
        }
    }
}
