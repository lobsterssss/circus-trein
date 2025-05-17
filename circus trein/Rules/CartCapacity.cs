namespace CircusTrain.Rules
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CircusTrain;
    using CircusTrain.Carts;

    internal class CartCapacity : ICartConstraint
    {
        /// <inheritdoc/>
        public bool CanAddAnimal(Animal animal, Cart cart)
        {
           return (int)animal.AnimalSize + cart.CurrentCapacity <= cart.MaxCapacity;
        }

        public bool CanAddAnimal(Animal animal, ExperimentalCart cart)
        {
            return (int)animal.AnimalSize + cart.CurrentCapacity <= cart.MaxCapacity;
        }
    }
}
