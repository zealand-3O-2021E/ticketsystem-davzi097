using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class MCTests
    {
        //test license lenght is 7
        [TestMethod()]
        public void LicenseLength7Test()
        {
            Vehicle mc1 = new MC();
            mc1.Licenseplate = "1234567";
            int explength = 7;
            Assert.AreEqual(mc1.Licenseplate.Length, explength);

        }

        //test license lenght is 8 (over 7)
        [TestMethod()]
        public void LicenseLength8Test()
        {
            Vehicle mc1 = new MC();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => mc1.Licenseplate = "12345678");

        }

        //test price of the car
        [TestMethod()]
        public void PriceTest()
        {
            MC mc1 = new MC();
            var expprice = 125;
            Assert.AreEqual(mc1.Price(), expprice);
        }
    }
}