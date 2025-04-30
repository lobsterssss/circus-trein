using circus_trein.Rules;
using Microsoft.VisualBasic.ApplicationServices;
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
    internal class Cart
    {
        public int maxCapacity { get; private set; } = 10;
        public List<Animal> animals { get; private set; }
        public int CurrentCapacity { get; private set; }

        private List<ICartConstraint> CartConstraints;

        internal Circus Circus
        {
            get => default;
            set
            {
            }
        }

        public Cart()
        {
            animals = new List<Animal>();
            CartConstraints = new List<ICartConstraint>();
            CartConstraints.Add(new CartCapacity());
            CartConstraints.Add(new AnimalBiggerThanLargestCarnivore());
            CartConstraints.Add(new AnimalSmallerThanLargestAnimal());

        }
        public bool addAnimal(Animal animal)
        {
            if (!checkCartConstraints(animal))
            {
                return false;
            }

            animals.Add(animal);
            CurrentCapacity = CalcCurrentCapacity();

            return true;

        }

        public bool checkCartConstraints(Animal animal)
        {

            foreach (ICartConstraint Rules in CartConstraints)
            {
                if (!Rules.CanAddAnimal(animal, this)) return false;
            }

            return true;
        }

        private int CalcCurrentCapacity()
        {
            int capacity = 0;
            foreach (Animal animal in animals)
            {
                capacity += (int)animal.AnimalSize;
            }
            return capacity;
        }

        public string ToString()
        {
            string CartData = "";

            foreach (Animal animal in animals)
            {
                CartData = CartData + animal.ToString() + ", ";
            }

            return "[" + CartData + "]";
        }
    }
}
