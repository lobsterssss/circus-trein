using CircusTrein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circus_trein
{
    internal class Train
    {
        List<Cart> train = new List<Cart>();

        public List<Animal> AddAnimal(List<Animal> animals) 
        {
            bool addedAnimal = false;
            foreach (Cart cart in train.Where<Cart>(cart => cart.CurrentCapacity < cart.maxCapacity))
            {
                int search = cart.maxCapacity - cart.CurrentCapacity;
                animals = animals.OrderByDescending(animal => animal.IsCarnivor).ThenByDescending(animal => search % 5 == 0 ? animal.AnimalSize : search - animal.AnimalSize - 1).ToList();
                if (cart.checkCartConstraints(animals.First()))
                {
                    cart.addAnimal(animals.First());
                    animals.Remove(animals.First());

                    addedAnimal = true;
                    break;
                }
            }
            if (!addedAnimal)
            {
                Cart carts = new Cart();
                train.Add(carts);
                carts.addAnimal(animals.First());
                animals.Remove(animals.First());

            }
            return animals;
        }

        public int GetCount() 
        {
            return train.Count();
        }

        public IReadOnlyCollection<Cart> GetTrain()
        {
            return train.AsReadOnly();
        }
    }
}
