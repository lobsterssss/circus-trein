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
    public sealed class AnimalBiggerThanLargestCarnivoreTests
    {

        [TestMethod]
        public void CanAddAnimal_LargeHerbivoreBiggerThanMediumCarnivore_ReturnTrue()
        {
            ICartConstraint rule = new AnimalBiggerThanLargestCarnivore();
            Cart cart = new Cart([rule]);
            cart.TryToAddAnimal(new Animal(Animal.Size.Medium, true));

            bool result = rule.CanAddAnimal(new Animal(Animal.Size.Large, false), cart);

            Assert.AreEqual(true, result, $"couldn't be added \n {result}");
        }

        [TestMethod]
        public void CanAddAnimal_SmallHerbivoreBiggerThanMediumCarnivore_ReturnFalse()
        {
            ICartConstraint rule = new AnimalBiggerThanLargestCarnivore();
            Cart cart = new Cart([rule]);
            cart.TryToAddAnimal(new Animal(Animal.Size.Medium, true));

            bool result = rule.CanAddAnimal(new Animal(Animal.Size.Small, false), cart);

            Assert.AreEqual(false, result, $"couldn't be added \n {rule.CanAddAnimal(new Animal(Animal.Size.Small, false), cart)}");
        }

        [TestMethod]
        public void CanAddAnimal_MediumCarnivoreBiggerThanMediumCarnivore_ReturnFalse()
        {
            ICartConstraint rule = new AnimalBiggerThanLargestCarnivore();
            Cart cart = new Cart([rule]);
            cart.TryToAddAnimal(new Animal(Animal.Size.Medium, true));

            bool result = rule.CanAddAnimal(new Animal(Animal.Size.Medium, true), cart);

            Assert.AreEqual(false, result, $"couldn't be added \n {result}");
        }
    }
}
