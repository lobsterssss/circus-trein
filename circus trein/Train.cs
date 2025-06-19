namespace CircusTrain
{
    using CircusTrain.Carts;
    using CircusTrain.Rules;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Train
    {
        private List<Cart> train = new List<Cart>();
        private int experimentalCartCountLeft = 4;


        public void AddAnimals(List<Animal> animals)
        {
            while (animals.Count() != 0)
            {
                bool addedAnimal = false;
                foreach (Cart cart in this.train.Where<Cart>(cart => cart.CurrentCapacity < cart.MaxCapacity))
                {
                    int search = cart.MaxCapacity - cart.CurrentCapacity;
                    Animal animal = animals.OrderByDescending(animal => animal.IsCarnivore).ThenBy(animal => search % (int)animal.AnimalSize).First();
                    try
                    {
                        cart.TryToAddAnimal(animal);
                        animals.Remove(animal);

                        addedAnimal = true;
                        break;
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e);
                    }
                }

                if (!addedAnimal)
                {
                    Cart carts = new Cart([new CartCapacity(), new AnimalBiggerThanLargestCarnivore(), new CarnivoreSmallerThanSmallestAnimal()]);

                    this.train.Add(carts);
                    carts.TryToAddAnimal(animals.First());
                    animals.Remove(animals.First());
                }
            }
        }

        public void AddExperimental()
        {
            ExperimentalCart experimentalCart = new ExperimentalCart([new ExperimentalCartMaxSize(), new ExperimentalCartCapacity()]);
            foreach (Cart cart in this.train.Where<Cart>(cart => cart.GetAnimalAmount() == 1 && cart.Animals.First().AnimalSize <= Animal.Size.Medium).ToList())
            {
                Animal onlyAnimal = cart.Animals.First();
                if (experimentalCart.CheckCartConstraints(onlyAnimal))
                {
                    experimentalCart.TryToAddAnimal(onlyAnimal);
                    this.train.Remove(cart);
                }
                else if (experimentalCartCountLeft == 0)
                {
                    this.train.Add(experimentalCart);
                    experimentalCartCountLeft--;
                    experimentalCart = new ExperimentalCart([new ExperimentalCartMaxSize(), new ExperimentalCartCapacity()]);
                    experimentalCart.TryToAddAnimal(onlyAnimal);
                    this.train.Remove(cart);
                }
            }

            this.train.Add(experimentalCart);

            this.RemoveEmptyCarts();
        }

        public int GetCartCount()
        {
            return this.train.Count();
        }

        public IReadOnlyCollection<Cart> GetTrain()
        {
            return this.train.AsReadOnly();
        }

        private void RemoveEmptyCarts()
        {
            foreach (Cart cart in this.train.Where(cart => cart.GetAnimalAmount() == 0).ToList())
            {
                this.train.Remove(cart);
            }
        }

        public string ShowTrain()
        {
            string show = "";
            foreach (Cart item in this.GetTrain())
            {
                show = show + item.ToString() + "\n";
            }
            return show;
        }
    }
}
