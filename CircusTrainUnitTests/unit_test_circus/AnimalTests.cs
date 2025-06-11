
namespace CircusTrainUnitTests
{
    using CircusTrain;
    using CircusTrain.Carts;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.CodeDom;

    [TestClass]
    public sealed class AnimalTest
    {
        [TestMethod]
        public void ToString_LargeCarnivore_ReturnLargeCarnivore()
        {
            Animal animal = new Animal(Animal.Size.Large, true);

            string animalstring = animal.ToString();

            Assert.AreEqual($"Large : Carnivore", animalstring, $"Animal ToString unsuccessfull ");
        }
    }
}
