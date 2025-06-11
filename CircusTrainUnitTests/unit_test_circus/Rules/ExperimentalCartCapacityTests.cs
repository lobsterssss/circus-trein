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
    public sealed class ExperimentalCartCapacityTests
    {
        [TestMethod]
        public void CanAddAnimal_AddMediumToFullExperimentalCart_ReturnTrue()
        {
            ICartConstraint rule = new ExperimentalCartCapacity();
            ExperimentalCart cart = new ExperimentalCart([new ExperimentalCartMaxSize(), new ExperimentalCartCapacity()]);
            cart.TryToAddAnimal(new Animal(Animal.Size.Small, false));
            cart.TryToAddAnimal(new Animal(Animal.Size.Small, false));

            bool result = rule.CanAddAnimal(new Animal(Animal.Size.Medium, true), cart);

            Assert.AreEqual(false, result, $"couldn't be added \n {result}");
        }

        [TestMethod]
        public void CanAddAnimal_AddMediumToHalfFullExperimentalCart_ReturnFalse()
        {
            ICartConstraint rule = new ExperimentalCartCapacity();
            ExperimentalCart cart = new ExperimentalCart([new ExperimentalCartMaxSize(), new ExperimentalCartCapacity()]);
            cart.TryToAddAnimal(new Animal(Animal.Size.Medium, false));

            bool result = rule.CanAddAnimal(new Animal(Animal.Size.Medium, true), cart);

            Assert.AreEqual(true, result, $"couldn't be added \n {result}");
        }

    }
}
