using Labor10;
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
        public void IsOrderedTest()
        {
            PhoneBookItem[] phoneBookItems = new PhoneBookItem[]
            {
                new PhoneBookItem(){Nev = "Pisti", Telefonszam = 11},
                new PhoneBookItem(){Nev = "Jani", Telefonszam = 12},
                new PhoneBookItem(){Nev = "Bazsi", Telefonszam = 13}
            };

            OrderedItemsHandler oih = new OrderedItemsHandler(phoneBookItems);
            Assert.That(oih.IsOrdered(), Is.EqualTo(false));
        }

        [Test]
        public void IsOrderedTest2()
        {
            PhoneBookItem[] phoneBookItems = new PhoneBookItem[]
            {
                new PhoneBookItem(){Nev = "Pisti", Telefonszam = 11},
                new PhoneBookItem(){Nev = "Jani", Telefonszam = 12},
                new PhoneBookItem(){Nev = "Bazsi", Telefonszam = 13}
            };

            OrderedItemsHandler oih = new OrderedItemsHandler(phoneBookItems);
            Assert.That(oih.IsOrdered(false), Is.EqualTo(true));
        }

        [Test]
        public void InsertionSortTest()
        {
            PhoneBookItem[] phoneBookItems = new PhoneBookItem[]
            {
                new PhoneBookItem(){Nev = "Pisti", Telefonszam = 11},
                new PhoneBookItem(){Nev = "Jani", Telefonszam = 12},
                new PhoneBookItem(){Nev = "Bazsi", Telefonszam = 13}
            };

            OrderedItemsHandler oih = new OrderedItemsHandler(phoneBookItems);
            oih.Sort(SortingMethod.Insertion);
            Assert.That(oih.IsOrdered(), Is.EqualTo(true));
        }

        [Test]
        public void BubbleSortTest()
        {
            PhoneBookItem[] phoneBookItems = new PhoneBookItem[]
            {
                new PhoneBookItem(){Nev = "Pisti", Telefonszam = 11},
                new PhoneBookItem(){Nev = "Jani", Telefonszam = 12},
                new PhoneBookItem(){Nev = "Bazsi", Telefonszam = 13}
            };

            OrderedItemsHandler oih = new OrderedItemsHandler(phoneBookItems);
            oih.Sort(SortingMethod.Insertion);
            Assert.That(oih.IsOrdered(), Is.EqualTo(true));
        }

        [Test]
        public void SelectionSortTest()
        {
            PhoneBookItem[] phoneBookItems = new PhoneBookItem[]
            {
                new PhoneBookItem(){Nev = "Pisti", Telefonszam = 11},
                new PhoneBookItem(){Nev = "Jani", Telefonszam = 12},
                new PhoneBookItem(){Nev = "Bazsi", Telefonszam = 13}
            };

            OrderedItemsHandler oih = new OrderedItemsHandler(phoneBookItems);
            oih.Sort(SortingMethod.Selection);
            Assert.That(oih.IsOrdered(), Is.EqualTo(true));
        }

        [Test]
        public void BinKeresRekTest()
        {
            PhoneBookItem[] phoneBookItems = new PhoneBookItem[]
            {
                new PhoneBookItem(){Nev = "Pisti", Telefonszam = 11},
                new PhoneBookItem(){Nev = "Jani", Telefonszam = 12},
                new PhoneBookItem(){Nev = "Bazsi", Telefonszam = 13}
            };
            OrderedItemsHandler oih = new OrderedItemsHandler(phoneBookItems);
            //rendezes
            oih.Sort(SortingMethod.Selection);

            Assert.That(oih.BinKeresRek(phoneBookItems[2]), Is.EqualTo(2));
        }

        [Test]
        public void NemNagyobbKeresTest()
        {
            PhoneBookItem[] phoneBookItems = new PhoneBookItem[]
            {
                new PhoneBookItem(){Nev = "Pisti", Telefonszam = 11},
                new PhoneBookItem(){Nev = "Jani", Telefonszam = 12},
                new PhoneBookItem(){Nev = "Bazsi", Telefonszam = 13}
            };
            OrderedItemsHandler oih = new OrderedItemsHandler(phoneBookItems);

            oih.Sort(SortingMethod.Selection);
            Assert.That(oih.NemNagyobbKeres(phoneBookItems[1]), Is.EqualTo(0));
        }

        [Test]
        public void ElsoNagyobbKeres()
        {
            PhoneBookItem[] phoneBookItems = new PhoneBookItem[]
            {
                new PhoneBookItem(){Nev = "Pisti", Telefonszam = 11},
                new PhoneBookItem(){Nev = "Jani", Telefonszam = 12},
                new PhoneBookItem(){Nev = "Bazsi", Telefonszam = 13}
            };
            OrderedItemsHandler oih = new OrderedItemsHandler(phoneBookItems);

            oih.Sort(SortingMethod.Bubble);
            Assert.That(oih.ElsoNagyobbKeres(phoneBookItems[1]), Is.EqualTo(2));
        }
    }
}