using Labor04;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1)]
        [TestCase(20)]
        public void Test1(int a)
        {
            Proba p = new Proba(a);
            if(p.ToString() == $"Ertek: {a}")
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}