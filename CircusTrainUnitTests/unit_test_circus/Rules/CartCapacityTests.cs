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
    public sealed class CartCapacityTests
    {
        [TestMethod]
        public void CanAddAnimal_AddMediumToFullCart_ReturnFalse()
        {
            ICartConstraint rule = new CartCapacity();
            Cart cart = new Cart([new CartCapacity(), new AnimalBiggerThanLargestCarnivore(), new CarnivoreSmallerThanSmallestAnimal()]);
            cart.TryToAddAnimal(new Animal(Animal.Size.Large, false));
            cart.TryToAddAnimal(new Animal(Animal.Size.Large, false));

            bool result = rule.CanAddAnimal(new Animal(Animal.Size.Medium, false), cart);

            Assert.AreEqual(false, result, $"couldn't be added \n {result}");
        }

        [TestMethod]
        public void CanAddAnimal_AddMediumToHalfFullCart_ReturnTrue()
        {
            ICartConstraint rule = new CartCapacity();
            Cart cart = new Cart([new CartCapacity(), new AnimalBiggerThanLargestCarnivore(), new CarnivoreSmallerThanSmallestAnimal()]);
            cart.TryToAddAnimal(new Animal(Animal.Size.Large, false));

            bool result = rule.CanAddAnimal(new Animal(Animal.Size.Medium, true), cart);

            Assert.AreEqual(true, result, $"couldn't be added \n {result}");
        }
    }
}
