using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("CircusTreinUnitTests")]


namespace CircusTrein
{
    internal class Animal
    {
        public Size AnimalSize { get; private set; }
        public bool IsCarnivor  { get; private set; }

        internal Circus Circus
        {
            get => default;
            set
            {
            }
        }

        public enum Size 
            {
                Small = 1,
                Medium = 3,
                Large = 5
            }

        public Animal() : this(Size.Small, false) 
        {
        }
        public Animal(Size size) : this(size, false)
        {
        }
        public Animal(bool isCarnivor) : this(Size.Small, isCarnivor)
        {
        }

        public Animal(Size size, bool isCarnivor, int priority = 1)
        {
            AnimalSize = size;
            IsCarnivor = isCarnivor;
        }

        public string ToString() 
        {
            string Diet = IsCarnivor ? "Carnivore" : "Herbivore";
            return $"{this.AnimalSize} : {Diet}";
        }
    }
}
