using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Donkey.Test_Cases
{
    [TestFixture]
    public class FarmyardTest
    {
        [Test]
        public void TestCat()
        {
            Farmyard fy = new Farmyard();

            String sound = fy.PlaySound("cat");

            Assert.AreEqual("meow", sound);
        }

        [Test]
        public void TestDog()
        {
            Farmyard fy = new Farmyard();

            String sound = fy.PlaySound("dog");

            Assert.AreEqual("woof", sound);
        }

        [Test]
        public void TestDonkey()
        {
            Farmyard fy = new Farmyard();

            String sound = fy.PlaySound("donkey");

            Assert.AreEqual("neigh", sound);
        }
    }
}
