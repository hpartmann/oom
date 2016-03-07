using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2
{
    [TestFixture]
    public class Tests
    {

        [Test]

        public void SimpleTest()
        {
            Assert.IsTrue(1 == 1);
        }

        [Test]
        public void KannHausErzeugen()
        {
            var Haus_x = new Haus("Prefa", "Josko", "Josko", 3, 390000);

            Assert.IsTrue(Haus_x.Dach == "Prefa");
            Assert.IsTrue(Haus_x.Fenster == "Josko");
            Assert.IsTrue(Haus_x.Türen == "Josko");
            Assert.IsTrue(Haus_x.Zimmer == 3);
            Assert.IsTrue(Haus_x.Preis == 390000);

        }

        [Test]
        public void KannNichtHausOhneDachErzeugen()
        {

            Assert.Catch(() =>
            {
                var Haus_x = new Haus(null, "Josko", "Josko", 3, 390000);
            });

        }

        [Test]
        public void KannNichtHausOhneFensterErzeugen()
        {

            Assert.Catch(() =>
            {
                var Haus_x = new Haus("Prefa", null, "Josko", 3, 390000);
            });

        }

        [Test]
        public void KannNichtHausOhneTürenErzeugen()
        {

            Assert.Catch(() =>
            {
                var Haus_x = new Haus("Bramac", "Josko", null, 3, 390000);
            });

        }

        [Test]
        public void KannNichtHausohneZimmerErzeugen()
        {

            Assert.Catch(() =>
            {
                var Haus_x = new Haus("Bramac", "Josko", "Josko", 0, 390000);
            });

        }

        [Test]
        public void KannZimmerUpdateDurchführen()
        {
            var Haus_x = new Haus("Bramac", "Josko", "Josko", 3, 390000);
            Haus_x.Zimmer = 5;

            Assert.IsTrue(Haus_x.Zimmer == 5);

        }

        [Test]
        public void KannPreisUpdateDurchführen()
        {
            var Haus_x = new Haus("Bramac", "Josko", "Josko", 4, 390000);
            Haus_x.UpdatePreis(500000);

            Assert.IsTrue(Haus_x.Preis == 500000);

        }

        [Test]
        public void KannZimmerFixpreisDurchführen()
        {
            var Haus_x = new Haus("Bramac", "Josko", "Josko", 5, 390000);

            Haus_x.Zimmer = 3;
            Assert.IsTrue(Haus_x.Preis == 250000);

        }

        [Test]
        public void KannNichtNegativenPreisUpdaten()
        {
            Assert.Catch(() =>
            {
                var Haus_x = new Haus("Bramac", "Josko", "Josko", 5, 390000);
                Haus_x.UpdatePreis(-500000);
            });

        }
    }
}
