using System.Runtime.CompilerServices;
using CircusTrain.Rules;

[assembly: InternalsVisibleTo("CircusTrainUnitTests")]

namespace CircusTrain.Carts
{
    internal class Cart
    {
        protected List<ICartConstraint> cartConstraints;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cart"/> class.
        /// </summary>
        public Cart(List<ICartConstraint> cartConstraints, int MaxCapacity = 10)
        {
            this.MaxCapacity = MaxCapacity;
            this.Animals = new List<Animal>();
            this.cartConstraints = cartConstraints;
        }

        public List<Animal> Animals { get; private set; }

        public int CurrentCapacity { get; private set; }

        public int MaxCapacity { get; private set; }

        /// <summary>
        /// checks if a Object Animal can be put inside of this class and adds it.
        /// </summary>
        /// <param name="animal">the Animal that is being checked and added.</param>
        /// <returns>bool.</returns>
        public void TryToAddAnimal(Animal animal)
        {
            if (!this.CheckCartConstraints(animal))
            {
                throw new InvalidOperationException("Cart constraints not met for the given animal.");
            }

            this.Animals.Add(animal);
            this.CurrentCapacity = this.CalculateCurrentCapacity();
        }

        /// <summary>
        /// checks if a Object Animal can be put inside of this class.
        /// </summary>
        /// <param name="animal">the Animal that is being checked to see if it can be added.</param>
        /// <returns>bool.</returns>
        public bool CheckCartConstraints(Animal animal)
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

            return "[" + cartData + "]";
        }

        /// <summary>
        /// checks if a Object Animal can be put inside of this class.
        /// </summary>
        /// <returns>int.</returns>
        public int GetAnimalAmount()
        {
            return this.Animals.Count();
        }

        private int CalculateCurrentCapacity()
        {
            int capacity = 0;
            foreach (Animal animal in this.Animals)
            {
                capacity += (int)animal.AnimalSize;
            }

            return capacity;
        }
    }
}
