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

        public Train MoveAnimals(int sH, int mH, int lH, int sC, int mC, int lC)
        {
            Train train = new Train();
            List<Animal> animals = AnimalFactory.CreateAnimals(sH, mH, lH, sC, mC, lC);

            animals = animals.OrderByDescending(animal => animal.IsCarnivore).ThenByDescending(animal => animal.AnimalSize).ToList();

            train.AddAnimals(animals);

            train.AddExperimental();
            return train;
        }
    }
}
