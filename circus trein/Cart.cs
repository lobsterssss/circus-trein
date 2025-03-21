using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("CircusTreinUnitTests")]


namespace CircusTrein
{
    internal class Cart
    {
        public int maxCapacity { get; private set; } = 10;
        public List<Animal> animals { get; private set; }
        public int CurrentCapacity { get; private set; }

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
            if ((int)animal.Size + CurrentCapacity > maxCapacity)
            {
                return false;
            }

            if (!animal.IsCarnivor && ComepareToLargestCarnavor(animal))
            {
                return true;
            }

            else if (ComepareToLargestCarnavor(animal) && ComepareToSmallestAnimal(animal))
            {
                return true;
            }

            return false;
        }

        private bool ComepareToLargestCarnavor(Animal animal)
        {

            if (animals.Count == 0)
            {
                return true;
            }
            List<Animal> carnivores = animals.Where<Animal>(animal => animal.IsCarnivor).ToList<Animal>();
            if (carnivores.Count() == 0)
            {
                return true;

            }
            Animal largest = carnivores[0];
            foreach (Animal u in carnivores)
            {
                if (u.Size > largest.Size)
                {
                    largest = u;
                }
            }
            return animal.Size > largest.Size;



        }

        private bool ComepareToSmallestAnimal(Animal Animal)
        {
            if (animals.Count <= 0)
            {
                return true;
            }
            Animal lowest = animals[0];
            foreach (Animal u in animals)
            {
                if (u.Size < lowest.Size)
                    lowest = u;
            }
            return Animal.Size < lowest.Size;
        }
        private int CalcCurrentCapacity()
        {
            int capacity = 0;
            foreach (Animal animal in animals)
            {
                capacity += (int)animal.Size;
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
