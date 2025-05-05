namespace CircusTrain.Rules
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CircusTrain;
    using CircusTrain.Carts;

    internal class ExperimentalCartMaxSize : ICartConstraint
    {
        /// <inheritdoc/>
        public bool CanAddAnimal(Animal animal, Cart cart)
        {
           return animal.AnimalSize <= Animal.Size.Medium;
        }
    }
}
