using CircusTrein;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circus_trein
{
    internal static class AnimalCollection
    {
        private static List<Animal> Animals = new List<Animal>();

        public static List<Animal> GetAnimalList() 
        {
            List<Animal> animals = new List<Animal>();
            animals.AddRange(Animals);
            return animals;
        }

        public static void ClearAnimalList()
        {
            Animals.Clear();
        }

        public static void CreateMultipulAnimals(int SH, int MH, int LH, int SC, int MC, int LC)
        {
            /* adds herbivores */
            Animals.Clear();

            for (int i = 0; i < LH; i++)
            {
                Animals.Add(new Animal(Animal.Size.Large, isCarnivor: false));
            }

            for (int i = 0; i < MH; i++)
            {
                Animals.Add(new Animal(Animal.Size.Medium, isCarnivor: false));
            }

            for (int i = 0; i < SH; i++)
            {
                Animals.Add(new Animal(Animal.Size.Small, isCarnivor: false));
            }

            /* adds carnivores */
            for (int i = 0; i < LC; i++)
            {
                Animals.Add(new Animal(Animal.Size.Large, isCarnivor: true));
            }

            for (int i = 0; i < MC; i++)
            {
                Animals.Add(new Animal(Animal.Size.Medium, isCarnivor: true));
            }

            for (int i = 0; i < SC; i++)
            {
                Animals.Add(new Animal(Animal.Size.Small, isCarnivor: true));
            }
        }
    }
}
