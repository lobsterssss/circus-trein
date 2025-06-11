
namespace CircusTrainUnitTests
{
    using CircusTrain;
    using CircusTrain.Carts;
    using System.CodeDom;

    [TestClass]
    public sealed class CircusTests
    {
        [TestMethod]
        /*ID 1*/
        public void MoveAnimals_2SmallCarnivores_Return1Carts()
        {
            Circus circus = new Circus();

            Train train = circus.MoveAnimals(0, 0, 0, 2, 0, 0);

            Assert.AreEqual(1, train.GetCartCount(), $"train building unsuccessfull, ID 1 \n {train.ShowTrain()}");
        }

        [TestMethod]
        /*ID 1*/
        public void MoveAnimals_5SmallHerbivores3MediumHerbivores1LargeHerbivores_Return2Carts()
        {
            Circus circus = new Circus();

            Train train = circus.MoveAnimals(5, 3, 1, 0, 0, 0);

            Assert.AreEqual(2, train.GetCartCount(), $"train building unsuccessfull, ID 1 \n {train.ShowTrain()}");

        }

        /*ID 2*/
        [TestMethod]
        public void MoveAnimal_3LargeHerbivores1SmallCarnivore3MediumCarnavore2LargeCarnivore_Return6Carts()
        {
            Circus circus = new Circus();

            Train train = circus.MoveAnimals(0, 0, 3, 1, 3, 2);

            Assert.AreEqual(6, train.GetCartCount(), $"train building unsuccessfull, ID 2 \n {train.ShowTrain()}");

        }
        /*ID 3*/
        [TestMethod]
        public void MoveAnimal_5SmallHerbivores5MediumHerbivores5LargeHerbivores2SmallCarnivore2MediumCarnavore2LargeCarnivore_Return8Carts()
        {
            Circus circus = new Circus();

            Train train = circus.MoveAnimals(5, 5, 5, 2, 2, 2);

            Assert.AreEqual(8, train.GetCartCount(), $"train building unsuccessfull, ID 3 \n {train.ShowTrain()}");

        }

        /*ID 4*/
        [TestMethod]
        public void MoveAnimal_1SmallHerbivores3MediumHerbivores2LargeHerbivores_Return2Carts()
        {
            Circus circus = new Circus();

            Train train = circus.MoveAnimals(1, 3, 2, 0, 0, 0);
            Assert.AreEqual(2, train.GetCartCount(), $"train building unsuccessfull, ID 4 \n {train.ShowTrain()}");

        }

        /*ID 5*/
        [TestMethod]
        public void MoveAnimal_3MediumHerbivores2LargeHerbivores1SmallCarnivore_Return2Carts()
        {
            Circus circus = new Circus();

            Train train = circus.MoveAnimals(0, 3, 2, 1, 0, 0);

            Assert.AreEqual(2, train.GetCartCount(), $"train building unsuccessfull, ID 5 \n {train.ShowTrain()}");

        }

        /*ID 6*/
        [TestMethod]
        public void MoveAnimal_2MediumHerbivores2LargeHerbivores2SmallCarnivore_Return2Carts()
        {
            Circus circus = new Circus();

            Train train = circus.MoveAnimals(0, 2, 2, 2, 0, 0);

            Assert.AreEqual(2, train.GetCartCount(), $"train building unsuccessfull, ID 6 \n {train.ShowTrain()}");

        }

        /*ID 7*/ 
        [TestMethod]
        public void MoveAnimal_6MediumHerbivores2LargeHerbivores2SmallCarnivore_Return3Carts()
        {
            Circus circus = new Circus();

            Train train = circus.MoveAnimals(0, 6, 2, 2, 0, 0);

            Assert.AreEqual(3, train.GetCartCount(), $"train building unsuccessfull, ID 7 \n {train.ShowTrain()}");

        }

    }
}
