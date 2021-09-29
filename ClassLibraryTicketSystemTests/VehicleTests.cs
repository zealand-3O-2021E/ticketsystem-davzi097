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
    public class VehicleTests
    {

        //test brobizz discount on MC
        [TestMethod()]
        public void MCBrobizzPriceTest()
        {
            MC mc1 = new MC();
            mc1.Brobizz = true;
            var expprice = 125 * 0.95;
            Assert.AreEqual(expprice,mc1.Price());
        }

        //test brobizz discount on Car
        [TestMethod()]
        public void CarBrobizzPriceTest()
        {
            Car c1 = new Car();
            c1.Brobizz = true;
            var expprice = 240 * 0.95;
            Assert.AreEqual(expprice, c1.Price());
        }
    }
}