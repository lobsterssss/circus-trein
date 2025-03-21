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
        public ESize Size { get; private set; }
        public bool IsCarnivor  { get; private set; }

        internal Circus Circus
        {
            get => default;
            set
            {
            }
        }

        public enum ESize 
            {
                small = 1,
                medium = 3,
                large = 5
            }

        public Animal() : this(ESize.small, false) 
        {
        }
        public Animal(ESize size) : this(size, false)
        {
        }
        public Animal(bool isCarnivor) : this(ESize.small, isCarnivor)
        {
        }

        public Animal(ESize size, bool isCarnivor, int priority = 1)
        {
            Size = size;
            IsCarnivor = isCarnivor;
        }

        public string ToString() 
        {
            string Diet = IsCarnivor ? "Carnivore" : "Herbivore";
            return $"{this.Size} : {Diet}";
        }

    }
}
