using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CircusTrain;

[assembly: InternalsVisibleTo("CircusTrainUnitTests")]

namespace CircusTrain
{
    internal class Circus
    {
        public Train MoveAnimals()
        {
            Train train = new Train();
            List<Animal> animals = AnimalCollection.GetAnimalList();

            animals = animals.OrderByDescending(animal => animal.IsCarnivore).ThenByDescending(animal => animal.AnimalSize).ToList();
            while (animals.Count() != 0)
            {
                animals = train.AddAnimal(animals);
            }

            train.AddExperimental();
            return train;
        }

        public Train MoveAnimals(List<Animal> animals)
        {
            Train train = new Train();

            animals = animals.OrderByDescending(animal => animal.IsCarnivore).ThenByDescending(animal => animal.AnimalSize).ToList();
            while (animals.Count() != 0)
            {
                animals = train.AddAnimal(animals);
            }

            return train;
        }
    }
}
