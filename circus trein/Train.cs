namespace CircusTrain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CircusTrain.Carts;

    internal class Train
    {
        private List<Cart> train = new List<Cart>();

        public List<Animal> AddAnimal(List<Animal> animals)
        {
            bool addedAnimal = false;
            foreach (Cart cart in this.train.Where<Cart>(cart => cart.CurrentCapacity < cart.MaxCapacity))
            {
                int search = cart.MaxCapacity - cart.CurrentCapacity;
                animals = animals.OrderByDescending(animal => animal.IsCarnivore).ThenByDescending(animal => search % (int)Enum.GetValues(typeof(Animal.Size)).Cast<Animal.Size>().Max() == 0 ? animal.AnimalSize : search - animal.AnimalSize).ToList();
                if (cart.CheckCartConstraints(animals.First()))
                {
                    cart.AddAnimal(animals.First());
                    animals.Remove(animals.First());

                    addedAnimal = true;
                    break;
                }
            }

            if (!addedAnimal)
            {
                Cart carts = new Cart();
                this.train.Add(carts);
                carts.AddAnimal(animals.First());
                animals.Remove(animals.First());
            }

            return animals;
        }

        public void AddExperimental()
        {
            ExperimentalCart experimentalCart = new ExperimentalCart();
            int experimentalCartCount = 1;
            foreach (Cart cart in this.train.Where<Cart>(cart => cart.GetAnimalAmount() == 1 && cart.Animals.First().AnimalSize <= Animal.Size.Medium).ToList())
            {
                if (experimentalCart.CheckCartConstraints(cart.Animals.First()))
                {
                    experimentalCart.AddAnimal(cart.Animals.First());
                    this.train.Remove(cart);
                }
                else if (experimentalCartCount < 4)
                {
                    this.train.Add(experimentalCart);
                    experimentalCartCount++;
                    experimentalCart = new ExperimentalCart();
                    experimentalCart.AddAnimal(cart.Animals.First());
                    this.train.Remove(cart);
                }
            }

            this.train.Add(experimentalCart);

            this.RemoveEmptyCarts();
        }

        public int GetCount()
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
