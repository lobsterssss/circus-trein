namespace CircusTrein
{
    internal class ExperimentalCart : Cart
    {
        public int MaxAnimals { get; private set; } = 2;

        public bool addAnimal(Animal animal)
        {
            if (checkCartConstraints(animal))
            {
                return false;
            }

            animals.Add(animal);
            return true;
        }

        public bool checkCartConstraints(Animal animal)
        {
            if (animals.Count() > MaxAnimals && animal.Size <= Animal.ESize.medium)
            {
                return false;
            }
            return true;
        }

    }
}
