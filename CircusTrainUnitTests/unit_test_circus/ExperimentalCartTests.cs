
namespace CircusTrainUnitTests
{
    using CircusTrain;
    using CircusTrain.Carts;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.CodeDom;

    [TestClass]
    public sealed class ExperimentalCartTests
    {
        [TestMethod]
        public void AddAnimals_2smallCarnivores_Return2Carts()
        {
            Train train = new Train();
            List<Animal> animals = CreateMultipleAnimals(0, 0, 0, 2, 0, 0);

            train.AddAnimals(animals);

            Assert.AreEqual(2, train.GetCartCount(), $"train building unsuccessfull ");
            Assert.AreEqual(0, animals.Count(), $"train building unsuccessfull ");
        }

        [TestMethod]
        public void AddExperimental_2smallCarnivores_Return1Carts()
        {
            Train train = new Train();
            List<Animal> animals = CreateMultipleAnimals(0, 0, 0, 2, 0, 0);
            train.AddAnimals(animals);

            train.AddExperimental();

            Assert.AreEqual(1, train.GetCartCount(), $"train building unsuccessfull ");
            Assert.AreEqual(0, animals.Count(), $"train building unsuccessfull ");
        }


        private static List<Animal> CreateMultipleAnimals(int SH, int MH, int LH, int SC, int MC, int LC)
        {
            List<Animal> Animals = new List<Animal>();
            /* adds herbivores */
            Animals.Clear();

            for (int i = 0; i < LH; i++)
            {
                Animals.Add(new Animal(Animal.Size.Large, false));
            }

            for (int i = 0; i < MH; i++)
            {
                Animals.Add(new Animal(Animal.Size.Medium, false));
            }

            for (int i = 0; i < SH; i++)
            {
                Animals.Add(new Animal(Animal.Size.Small, false));
            }

            /* adds carnivores */
            for (int i = 0; i < LC; i++)
            {
                Animals.Add(new Animal(Animal.Size.Large, true));
            }

            for (int i = 0; i < MC; i++)
            {
                Animals.Add(new Animal(Animal.Size.Medium, true));
            }

            for (int i = 0; i < SC; i++)
            {
                Animals.Add(new Animal(Animal.Size.Small, true));
            }

            return Animals;
        }

    }
}
