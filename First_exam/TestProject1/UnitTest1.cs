using System.Linq.Expressions;
using ZH1_GMG;
namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SmallAirplaneTest()
        {
            Assert.Throws<NotEnoughSeatsException>(() => new SmallAirplane("name1", 5000, PlaneType.Piper, 13));
        }

        [TestCase(20000, 5000, true)]
        [TestCase(40000, 6000, false)]
        public void MediumAirplaneTest1(int planeWeight, int cargoWeight, bool expected)
        {
            MediumAirplane test = new MediumAirplane("name1", planeWeight, PlaneType.Airbus, cargoWeight);
            Assert.That(test.TakeOff(), Is.EqualTo(expected));
        }

        [Test]
        public void MediumAirplaneTest2()
        {
            MediumAirplane test = new MediumAirplane("name1", 20000, PlaneType.Boeing, 10000);
            if(test.TakeOff() == true) Assert.That(test.ToString, Is.EqualTo($"name1 [ x kg / y fõ] felszállhat"));
            Assert.That(test.ToString, Is.EqualTo($"name1 [ x kg / y fõ] Nem szállhat fel"));
        }

        [Test]
        public void CargoTest()
        {
            Cargo test = new Cargo(50000, 60000);
            if(test.Passangers != 1) Assert.Fail();
            Assert.Pass();
        }

        [Test]
        public void AerodromeTest()
        {
            Aerodrome test = new Aerodrome(4);

            IAircraft[] airplanes = new IAircraft[]
            {
                new SmallAirplane("name1", 3000, PlaneType.Caravan, 10),
                new Cargo(10000, 80000),
                new MediumAirplane("name2", 10000, PlaneType.Boeing, 3000),
                new SmallAirplane("name3", 6000, PlaneType.Piper, 3)
            };

            for (int i = 0; i < airplanes.Length; i++)
            {
                test.AddPlane(airplanes[i]);
            }

            IAircraft[] expected = new IAircraft[]
            {
                airplanes[3],
                airplanes[0], 
                airplanes[2]
            };

            Assert.That(test.Prioritize(), Is.EqualTo(expected));
            
        }
    }
}