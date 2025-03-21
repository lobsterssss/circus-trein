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
      internal class Circus
    {
        public List<Cart> moveAnimals(List<Animal> animals) 
        {
            List<ExperimentalCart> Experimental_carts = new List<ExperimentalCart>();
            List<Cart> train = new List<Cart>();
            bool addedAnimal;
            foreach (Animal animal in animals.OrderByDescending(animal => animal.IsCarnivor).ThenByDescending(animal => animal.Size))
            {
                addedAnimal = false;
                foreach (Cart cart in train.Where<Cart>(cart => cart.CurrentCapacity < cart.maxCapacity))
                {
                    if (cart.checkCartConstraints(animal)) {
                        cart.addAnimal(animal);
                        addedAnimal = true;
                        break;
                    }
                }
                if (!addedAnimal)
                {
                    Cart carts = new Cart();
                    train.Add(carts);
                    carts.addAnimal(animal);
                }
            }
                return train;
        }

    }
}
