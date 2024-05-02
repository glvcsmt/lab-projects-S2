using Labor06;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(100, true, 400)]
        [TestCase(100, false, 400)]
        [TestCase(501, true, 1000)]
        public void EnvelopeTest(int g, bool csa, int vart)
        {
            Envelope e = new Envelope("ajandek", g, "Jamal");
            Assert.That(e.CalculatePrice(csa), Is.EqualTo(vart));
        }

        [Test]
        public void EnvelopeExceptionTest()
        {
            Envelope e = new Envelope("ajandek", 2001, "Jamal");
            Assert.Throws<OverweightException>(() => e.CalculatePrice(true));
        }

        [Test]
        public void FragileParcelTest()
        {
            FragileParcel fp = new FragileParcel(500, "cim1", Mod.Horizontal);
            Assert.Throws<DeliveryException>(() => fp.CalculatePrice(true));
        }

        [Test]
        public void FragilParcelTest2()
        {
            try
            {
                FragileParcel fp = new FragileParcel(500, "cim1", Mod.Arbitrary);
            }
            catch(IncorrectOrientationException)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void CourierTest()
        {
            Courier c = new Courier(10);
            IDeliverable[] csomagok = new IDeliverable[]
            {
                new Envelope("1", 100, "ad"),
                new FragileParcel(111, "cim1", Mod.Horizontal),
                new FragileParcel(112, "cim2", Mod.Horizontal),
                new NormalParcel(300, "cim4")
            };

            int suly = 0;
            for (int i = 0; i < csomagok.Length; i++)
            {
                c.PickUpItem(csomagok[i]);
                suly += csomagok[i].Weight;
            }

            Assert.That(c.Ossztomeg, Is.EqualTo(suly));
        }

        [Test]
        public void CourierTest2()
        {
            Courier c = new Courier(10);
            IDeliverable[] csomagok = new IDeliverable[]
            {
                new Envelope("1", 100, "ad"),
                new FragileParcel(111, "cim1", Mod.Horizontal),
                new FragileParcel(25, "cim2", Mod.Horizontal),
                new NormalParcel(300, "cim4")
            };

            IDeliverable[] vart = new IDeliverable[]
            {
                csomagok[2],
                csomagok[1]
            };

            for (int i = 0; i < csomagok.Length; i++)
            {
                c.PickUpItem(csomagok[i]);
            }

            Assert.That(c.FragilesSorted, Is.EqualTo(vart));
        }
    }
}