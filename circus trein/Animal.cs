using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("CircusTrainUnitTests")]


namespace CircusTrain
{
    internal class Animal
    {
        public Animal(Size size, bool isCarnivore)
        {
            this.AnimalSize = size;
            this.IsCarnivore = isCarnivore;
        }

        public enum Size
        {
            Small = 1,
            Medium = 3,
            Large = 5,
        }

        public Size AnimalSize { get; private set; }

        public bool IsCarnivore { get; private set; }

        public new string ToString()
        {
            string diet = this.IsCarnivore ? "Carnivore" : "Herbivore";
            return $"{this.AnimalSize} : {diet}";
        }
    }
}
