using CircusTrein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circus_trein.Rules
{
    internal class AnimalSmallerThanLargestAnimal : ICartConstraint
    {
        public bool CanAddAnimal(Animal animal, Cart cart)
        {

           return ComepareToSmallestAnimal(animal, cart.animals);
        }

        private bool ComepareToSmallestAnimal(Animal Animal, List<Animal> animals)
        {
            return !animals.Any<Animal>(a => Animal.IsCarnivor && Animal.AnimalSize > a.AnimalSize);
        }
    }
}
