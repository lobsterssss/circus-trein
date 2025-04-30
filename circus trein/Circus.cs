using circus_trein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

[assembly: InternalsVisibleTo("CircusTreinUnitTests")]

namespace CircusTrein
{


    internal class Circus
    {
        public Train moveAnimals() 
        {
            Train Train = new Train();
            List<Animal> animals = AnimalCollection.GetAnimalList();

            animals = animals.OrderByDescending(animal => animal.IsCarnivor).ThenByDescending(animal => animal.AnimalSize - 10 ).ToList();
            while (animals.Count() != 0)
            {
                animals = Train.AddAnimal(animals);
            }
                return Train;
        }

        public Train moveAnimals(List<Animal> animals)
        {
            Train Train = new Train();

            animals = animals.OrderByDescending(animal => animal.IsCarnivor).ThenByDescending(animal => animal.AnimalSize - 10).ToList();
            while (animals.Count() != 0)
            {
                animals = Train.AddAnimal(animals);
            }
            return Train;
        }

    }
}
