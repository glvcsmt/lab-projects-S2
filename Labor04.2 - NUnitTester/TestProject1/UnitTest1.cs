using Labor04._2;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(16, false)]
        public void Test1(int a, bool p)
        {
            PrimeTool pt = new PrimeTool(a);

            Assert.That(pt.IsPrime(), Is.EqualTo(p));
        }

        [Test]
        public void TotalTest()
        {
            ArrayStatistics A = new ArrayStatistics(new int[] { 3, 4, 5 });
            Assert.That(12, Is.EqualTo(A.Total()));
        }

        [TestCase(true, new int[] { 4, 5, 6 }, 6)]
        [TestCase(false, new int[] { 4, 5, 6 }, 69)]
        public void ContainsTest(bool vart, int[] tomb, int keresett)
        {
            ArrayStatistics As = new ArrayStatistics(tomb);
            Assert.That(vart, Is.EqualTo(As.Contains(keresett)));
        }

        [TestCase(true, new int[] { 1, 2, 3 })]
        [TestCase(false, new int[] { 5, 2, 3 })]
        public void SortedTest(bool vart, int[] tomb)
        {
            ArrayStatistics A = new ArrayStatistics(tomb);
            Assert.That(vart, Is.EqualTo(A.Sorted()));
        }

        [TestCase(3, new int[] {2, 4, 6, 8, 10}, 6)]
        [TestCase(-1, new int[] {2, 4, 6, 8, 10}, 11)]
        public void FirstGreaterTest(int vart, int[] tomb, int keresett)
        {
            ArrayStatistics A = new ArrayStatistics(tomb);
            Assert.That(vart, Is.EqualTo(A.FirstGreater(keresett)));
        }

        [Test]
        public void SortTest()
        {
            ArrayStatistics A = new ArrayStatistics(new int[] {5, 3, 1});
            A.Sort();
            Assert.That(true, Is.EqualTo(A.Sorted()));
        }
    }
}