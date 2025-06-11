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
    public sealed class ExperimentalCartMaxSizeTests
    {
        [TestMethod]
        public void CanAddAnimal_AddLargeExperimentalCart_ReturnFalse()
        {
            ICartConstraint rule = new ExperimentalCartMaxSize();
            ExperimentalCart cart = new ExperimentalCart([new ExperimentalCartMaxSize(), new ExperimentalCartCapacity()]);

            bool result = rule.CanAddAnimal(new Animal(Animal.Size.Large, true), cart);

            Assert.AreEqual(false, result, $"couldn't be added \n {result}");
        }

        [TestMethod]
        public void CanAddAnimal_AddMediumExperimentalCart_ReturnTrue()
        {
            ICartConstraint rule = new ExperimentalCartMaxSize();
            ExperimentalCart cart = new ExperimentalCart([new ExperimentalCartMaxSize(), new ExperimentalCartCapacity()]);

            bool result = rule.CanAddAnimal(new Animal(Animal.Size.Medium, true), cart);

            Assert.AreEqual(true, result, $"couldn't be added \n {result}");
        }
    }
}
