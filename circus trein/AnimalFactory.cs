﻿namespace CircusTrain
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CircusTrain;

    internal class AnimalFactory
    {
        /// <summary>
        /// adds animals of the given values.
        /// </summary>
        /// <param name="sH">adds x amount of small herbivores animals.</param>
        /// <param name="mH">adds x amount of medium herbivores animals.</param>
        /// <param name="lH">adds x amount of large herbivores animals.</param>
        /// <param name="sC">adds x amount of small carnivores animals.</param>
        /// <param name="mC">adds x amount of medium carnivores animals.</param>
        /// <param name="lC">adds x amount of large carnivores animals.</param>
        public static List<Animal> CreateAnimals(int sH, int mH, int lH, int sC, int mC, int lC)
        {
            /* adds herbivores */
            List<Animal> animals = new List<Animal>();

            for (int i = 0; i < lH; i++)
            {
                animals.Add(new Animal(Animal.Size.Large, isCarnivore: false));
            }

            for (int i = 0; i < mH; i++)
            {
                animals.Add(new Animal(Animal.Size.Medium, isCarnivore: false));
            }

            for (int i = 0; i < sH; i++)
            {
                animals.Add(new Animal(Animal.Size.Small, isCarnivore: false));
            }

            /* adds carnivores */
            for (int i = 0; i < lC; i++)
            {
                animals.Add(new Animal(Animal.Size.Large, isCarnivore: true));
            }

            for (int i = 0; i < mC; i++)
            {
                animals.Add(new Animal(Animal.Size.Medium, isCarnivore: true));
            }

            for (int i = 0; i < sC; i++)
            {
                animals.Add(new Animal(Animal.Size.Small, isCarnivore: true));
            }

            return animals;
        }
    }
}
