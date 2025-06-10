namespace CircusTrain.Carts
{
    using CircusTrain;
    using CircusTrain.Rules;

    internal class ExperimentalCart : Cart
    {
        //private readonly List<ICartConstraint> cartConstraints;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentalCart"/> class.
        /// </summary>
        public ExperimentalCart(List<ICartConstraint> cartConstraints, int MaxAnimals = 2)
            : base(cartConstraints)
        {
            this.MaxAnimals = MaxAnimals;
        }

        public int MaxAnimals { get; private set; }

        /// <summary>
        /// checks if a Object Animal can be put inside of this class and adds it.
        /// </summary>
        /// <param name="animal">the Animal that is being checked and added.</param>
        /// /// <returns>Bool.</returns>

        /// <summary>
        /// checks if a Object Animal can be put inside of this class.
        /// </summary>
        /// <param name="animal">the Animal that is being checked and added.</param>
        /// <returns>bool.</returns>
        public new bool CheckCartConstraints(Animal animal)
        {
            foreach (ICartConstraint rules in this.cartConstraints)
            {
                if (!rules.CanAddAnimal(animal, this))
                {
                    return false;
                }
            }

            return true;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            string cartData = string.Empty;

            foreach (Animal animal in this.Animals)
            {
                cartData = cartData + animal.ToString() + ", ";
            }

            return "{" + cartData + "}";
        }
    }
}
