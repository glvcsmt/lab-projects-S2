using System.Dynamic;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RendezettEExceptionTeszt()
        {
            int[] tomb = new int[]
            {
                1, 4, 2
            };
            SetOfInts s;
            Assert.Throws<ArgumentException>(() => s = new SetOfInts(tomb));
        }

        [Test]
        public void EgyediEExceptionTeszt()
        {
            int[] tomb = new int[]
            {
                1, 1, 2, 3
            };
            SetOfInts s;
            Assert.Throws<ArgumentException>(() => s = new SetOfInts(tomb));
        }

        [Test]
        public void NOExceptionTeszt()
        {
            int[] tomb = new int[] { 10, 20, 30 };
            try
            {
                SetOfInts s = new SetOfInts(tomb);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
            Assert.Pass();
        }

        [Test]
        //ket halmaz megegyezik-e
        public void EgyezoekE()
        {
            int[] ta = new int[] { 1, 2, 3 };
            int[] tb = new int[] { 1, 2, 3 };

            SetOfInts A = new SetOfInts(ta);
            //SetOfInts B = A;

            //Assert.That(A == B, Is.True);

            SetOfInts B = new SetOfInts(tb);
            Assert.That(A.Equals(B), Is.True);
        }

        [Test]
        //ket halmaz megegyezik-e
        public void EgyezoekE2()
        {
            int[] ta = new int[] { 1, 2, 3 };
            int[] tb = new int[] { 1, 2, 3, 4 };

            SetOfInts A = new SetOfInts(ta);
            //SetOfInts B = A;

            //Assert.That(A == B, Is.True);

            SetOfInts B = new SetOfInts(tb);
            Assert.That(A.Equals(B), Is.False);
        }

        [TestCase(3, 2)]
        [TestCase(8, -1)]
        public void BinKeresTeszt(int keresett, int vart)
        {
            int[] t = new int[] { 1, 2, 3, 4 };
            SetOfInts setOfInts = new SetOfInts(t);

            Assert.That(setOfInts.BinKeres(keresett), Is.EqualTo(vart));
        }

        [TestCase(new int[] { 1, 2 }, true)]
        [TestCase(new int[] { 1, 2, 3, 4, 5}, false)]
        [TestCase(new int[] { 8 }, false)]
        public void SubsetTeszt1(int[] tomb, bool vart)
        {
            int[] t = new int[] { 1, 2, 3, 4 };
            SetOfInts subSetOfInts = new SetOfInts(tomb);
            SetOfInts setOfInts = new SetOfInts(t);

            Assert.That(setOfInts.Subset(subSetOfInts), Is.EqualTo(vart));
        }
    }
}