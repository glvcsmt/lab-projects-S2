using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TrainingCosts;

namespace TrainingCostsTests
{
    [TestFixture]
    internal class MonthlyCostsTests
    {
        [Test]
        public void LoadFromNonExisting()
        {
            Assert.Throws<FileNotFoundException>(() => MonthlyCosts.LoadFrom("non_existing.csv"));
        }

        [Test]
        public void LoadFromEmpty()
        {
            MonthlyCosts februaryCosts = MonthlyCosts.LoadFrom(@"..\..\..\csv_files\2024_02.csv");
            Assert.That(februaryCosts.TrainingCosts.Length, Is.EqualTo(0));
        }

        [Test]
        public void LoadFromSuccessful()
        {
            MonthlyCosts januaryCosts = MonthlyCosts.LoadFrom(@"..\..\..\csv_files\2024_01.csv");
            Assert.That(januaryCosts.TrainingCosts.Length, Is.EqualTo(6));
        }

        [TestCase("01", 65900)]
        [TestCase("02", 0)]
        public void TeljesKoltesTeszt(String hnap, int vartErtek)
        {
            MonthlyCosts januaryCosts = MonthlyCosts.LoadFrom(@"..\..\..\csv_files\2024_" + hnap + ".csv");
            Assert.That(januaryCosts.TeljesKoltes, Is.EqualTo(vartErtek));
        }

        [Test]
        public void TeljesKoltesFeltetellelTeszt()
        {
            MonthlyCosts januaryCosts = MonthlyCosts.LoadFrom(@"..\..\..\csv_files\2024_01.csv");
            Assert.That(januaryCosts.TeljesKoltes(p => p.Type == TrainingType.Swimming || p.Type == TrainingType.Cycling),
                Is.EqualTo(65900));
        }

        [Test]
        public void TeljesKoltesFeltetellelTeszt2()
        {
            MonthlyCosts januaryCosts = MonthlyCosts.LoadFrom(@"..\..\..\csv_files\2024_01.csv");
            Assert.That(januaryCosts.TeljesKoltes(p => p.Cost > 10000), Is.EqualTo(42100));
        }

        [TestCase(TrainingType.Cycling, 14500, true)]
        [TestCase(TrainingType.Cycling, 9500, false)]
        public void VoltETeszt(TrainingType te, int ertek, bool vart)
        {
            MonthlyCosts januaryCosts = MonthlyCosts.LoadFrom(@"..\..\..\csv_files\2024_01.csv");
            Assert.That(januaryCosts.VoltE(p => p.Cost == ertek && p.Type == te), Is.EqualTo(vart));
        }

        [TestCase(TrainingType.Cycling, 2, true)]
        [TestCase(TrainingType.Swimming, 4, false)]
        public void LegalabbKTeszt(TrainingType t, int k, bool vart)
        {
            MonthlyCosts januaryCosts = MonthlyCosts.LoadFrom(@"..\..\..\csv_files\2024_01.csv");
            Assert.That(januaryCosts.LegalabbK(p => p.Type == t, k), Is.EqualTo(vart));
        }

        [TestCase(TrainingType.Cycling, 2, "Chain")]
        [TestCase(TrainingType.Swimming, 4, "null")]
        public void KFeltetelTeszt(TrainingType t, int k, string vart)
        {
            MonthlyCosts januaryCosts = MonthlyCosts.LoadFrom(@"..\..\..\csv_files\2024_01.csv");
            Assert.That(januaryCosts.KFeletetel(p => p.Type == t, k), Is.EqualTo(vart));
        }

        [TestCase(TrainingType.Cycling, 3)]
        [TestCase(TrainingType.Swimming, 3)]
        public void FeltetelesKoltesDbTeszt(TrainingType t, int vart)
        {
            MonthlyCosts januaryCosts = MonthlyCosts.LoadFrom(@"..\..\..\csv_files\2024_01.csv");
            Assert.That(januaryCosts.FeltetelesKoltesDb(p => p.Type == t), Is.EqualTo(vart));
        }
    }
}
