using System.Security.Cryptography;
using ZH1_gyak1;

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
        public void PassportTest1()
        {
            Assert.Throws<InvalidBirthdateException>(() => new Passport("xy", 12, new DateTime(2025, 02, 09), DateTime.Now, CountryType.Impor));        
        }
    }
}