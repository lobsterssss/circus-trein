namespace CircusTrain.Rules
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CircusTrain;
    using CircusTrain.Carts;

    internal class CarnivoreSmallerThanSmallestAnimal : ICartConstraint
    {
        /// <inheritdoc/>
        public bool CanAddAnimal(Animal animal, Cart cart)
        {
           return !cart.Animals.Any<Animal>(a => animal.IsCarnivore && animal.AnimalSize >= a.AnimalSize);
        }
    }
}
