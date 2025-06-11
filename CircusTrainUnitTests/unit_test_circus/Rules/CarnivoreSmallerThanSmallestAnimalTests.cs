using CircusTrain.Rules;
using CircusTrain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircusTrain.Carts;

namespace CircusTrainUnitTests
{
    [TestClass]
    public sealed class CarnivoreSmallerThanSmallestAnimalTests
    {
        [TestMethod]
        public void CanAddAnimal_SmallCarnivoreSmallerThanMediumHerbivore_ReturnTrue()
        {
            ICartConstraint rule = new CarnivoreSmallerThanSmallestAnimal();
            Cart cart = new Cart([new CartCapacity(), new AnimalBiggerThanLargestCarnivore(), new CarnivoreSmallerThanSmallestAnimal()]);
            cart.TryToAddAnimal(new Animal(Animal.Size.Medium, false));

            bool result = rule.CanAddAnimal(new Animal(Animal.Size.Small, true), cart);

            Assert.AreEqual(true, result, $"couldn't be added \n {result}");
        }

        [TestMethod]
        public void CanAddAnimal_LargeHerbivoreSmallerThanMediumHerbivore_ReturnTrue()
        {
            ICartConstraint rule = new CarnivoreSmallerThanSmallestAnimal();
            Cart cart = new Cart([new CartCapacity(), new AnimalBiggerThanLargestCarnivore(), new CarnivoreSmallerThanSmallestAnimal()]);
            cart.TryToAddAnimal(new Animal(Animal.Size.Medium, false));

            bool result = rule.CanAddAnimal(new Animal(Animal.Size.Large, false), cart);

            Assert.AreEqual(true, result, $"couldn't be added \n {result}");
        }

        [TestMethod]
        public void CanAddAnimal_MediumCarnivoreSmallerThanSmallHerbivore_ReturnFalse()
        {
            ICartConstraint rule = new CarnivoreSmallerThanSmallestAnimal();
            Cart cart = new Cart([new CartCapacity(), new AnimalBiggerThanLargestCarnivore(), new CarnivoreSmallerThanSmallestAnimal()]);
            cart.TryToAddAnimal(new Animal(Animal.Size.Small, false));

            bool result = rule.CanAddAnimal(new Animal(Animal.Size.Medium, true), cart);

            Assert.AreEqual(false, result, $"couldn't be added \n {result}");
        }
    }
}
