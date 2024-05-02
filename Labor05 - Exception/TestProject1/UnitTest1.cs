using Labor05;
using Moq;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ToStringTest()
        {
            FoodIngredient f = new FoodIngredient("liszt", 2, Egyseg.kilogramm);

            string vart = "liszt - 2 - kilogramm";

            Assert.That(f.ToString, Is.EqualTo(vart));
        }

        [Test]
        public void EmptyTest()
        {
            IngredientStack s = new IngredientStack(2);
            Assert.That(s.Empty(), Is.EqualTo(true));
        }


        [Test]
        public void MockEmptyTest()
        {
            Mock<IStack> mock = new Mock<IStack>();

            mock.Setup(x => x.Empty()).Returns(true);

            Assert.That(mock.Object.Empty, Is.EqualTo(true));
        }


        [Test]
        public void EmptyTest2()
        {
            IngredientStack s = new IngredientStack(2);
            FoodIngredient f1 = new FoodIngredient("liszt", 3, Egyseg.kilogramm);
            s.Push(f1);
            Assert.That(s.Empty(), Is.EqualTo(false));
        }

        [Test]
        public void PushTest()
        {
            IngredientStack s = new IngredientStack(0);
            FoodIngredient f1 = new FoodIngredient("liszt", 3, Egyseg.kilogramm);

            /*try
            {
                s.Push(f1);
            }
            catch (StackFullException)
            {
                Assert.Pass();
            }
            Assert.Fail();*/

            Assert.Throws<StackFullException>(() => s.Push(f1));
        }

        [Test]
        public void PopTest()
        {
            IngredientStack s = new IngredientStack(0);
            FoodIngredient f1 = new FoodIngredient("liszt", 3, Egyseg.kilogramm);

            Assert.Throws<StackEmptyException>(() => s.Pop());
        }

        [Test]
        public void TopTest()
        {
            IngredientStack s = new IngredientStack(1);
            FoodIngredient f1 = new FoodIngredient("liszt", 3, Egyseg.kilogramm);

            s.Push(f1);

            Assert.That(s.Top, Is.EqualTo(f1));
        }

        [Test]
        public void HandlerTest()
        {
            IngredientStack stack = new IngredientStack(2);

            FoodIngredient[] food = new FoodIngredient[]
            {
                new FoodIngredient("liszt", 3, Egyseg.kilogramm),
                new FoodIngredient("vaj", 3, Egyseg.kilogramm),
                new FoodIngredient("tej", 3, Egyseg.kilogramm),
                new FoodIngredient("zsemle", 3, Egyseg.kilogramm),
                new FoodIngredient("kolbasz", 3, Egyseg.kilogramm)
            };

            IngredientStackHandler handler = new IngredientStackHandler(stack);

            FoodIngredient[] nemFertBele = handler.AddItems(food);

            FoodIngredient[] vart =
            {
                food[2], food[3], food[4]
            };

            Assert.That(nemFertBele, Is.EqualTo(vart));
        }
    }
}