namespace CircusTrain.Rules
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CircusTrain;
    using CircusTrain.Carts;

    internal interface ICartConstraint
    {
        /// <summary>
        /// checks if a Object Animal can be put inside of cart.
        /// </summary>
        /// <param name="animal">the Animal that is being checked and added.</param>
        /// <param name="cart">the cart to which the rules will be applied.</param>
        /// <returns>bool.</returns>
        public bool CanAddAnimal(Animal animal, Cart cart);
    }
}
