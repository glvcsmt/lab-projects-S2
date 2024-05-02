using NUnit;
using Labor04;
using NUnit.Framework;

namespace Labor04Teszt
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test()
        {
            Proba p = new Proba(3);
            Assert.That("Ertek: 3", Is.EqualTo(p.ToString()));
        }
    }
}