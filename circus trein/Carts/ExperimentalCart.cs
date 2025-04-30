using circus_trein.Carts;

namespace CircusTrein
{
    internal class ExperimentalCart : Cart
    {
        public int MaxAnimals { get; private set; } = 2;

        public bool AddAnimal(Animal animal)
        {
            if (checkCartConstraints(animal))
            {
                return false;
            }

            animals.Add(animal);
            return true;
        }

        public bool CheckCartConstraints(Animal animal)
        {
            if (animals.Count() > MaxAnimals && animal.AnimalSize <= Animal.Size.Medium)
            {
                return false;
            }
            return true;
        }

    }
}
