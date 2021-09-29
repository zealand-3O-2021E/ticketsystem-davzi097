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
    public class CarTests
    {

        //test license lenght is 7
        [TestMethod()]
        public void LicenseLength7Test()
        {
            Vehicle c1 = new Car();
            c1.Licenseplate = "1234567";
            int explength = 7;
            Assert.AreEqual(c1.Licenseplate.Length, explength);

        }

        //test license lenght is 8 (over 7)
        [TestMethod()]
        public void LicenseLength8Test()
        {
            Vehicle c1 = new Car();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => c1.Licenseplate = "12345678");

        }

        //test price of the car
        [TestMethod()]
        public void PriceTest()
        {
            Car c1 = new Car();
            var expprice = 240;
            Assert.AreEqual(c1.Price(), expprice);
        }

        
    }
}