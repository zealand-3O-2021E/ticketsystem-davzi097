using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundbronLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace OresundbronLibrary.Tests
{
    [TestClass()]
    public class OresundbronTests
    {
        //test price of the car without discount
        [TestMethod()]
        public void CarPriceTest()
        {
            Car c1 = new Car();
            var newprice = Oresundbron.CarPrice(c1);
            var expprice = 410;
            Assert.AreEqual(newprice, expprice);
        }

        //test price of the car with discount
        [TestMethod()]
        public void CarPriceWithBrobizzTest()
        {
            Car c1 = new Car();
            c1.Brobizz = true;
            var newprice = Oresundbron.CarPrice(c1);
            var expprice = 161;
            Assert.AreEqual(newprice, expprice);
        }

        //test price of the mc without discount
        [TestMethod()]
        public void MCPriceTest()
        {
            MC mc1 = new MC();
            var newprice = Oresundbron.MCPrice(mc1);
            var expprice = 210;
            Assert.AreEqual(newprice, expprice);
        }

        //test price of the mc with discount
        [TestMethod()]
        public void MCPriceWithBrobizzTest()
        {
            MC mc1 = new MC();
            mc1.Brobizz = true;
            var newprice = Oresundbron.MCPrice(mc1);
            var expprice = 73;
            Assert.AreEqual(newprice, expprice);
        }

        //test if vehicle is car
        [TestMethod()]
        public void CarTypeTest()
        {
            Car c1 = new Car();
            var vehicletype = Oresundbron.VehicleType(c1);
            string vehicle = "Oresund Car";
            Assert.AreEqual(vehicletype, vehicle);
        }

        //test if vehicle is mc
        [TestMethod()]
        public void MCTypeTest()
        {
            MC mc1 = new MC();
            var vehicletype = Oresundbron.VehicleType(mc1);
            string vehicle = "Oresund MC";
            Assert.AreEqual(vehicletype, vehicle);
        }
    }
}