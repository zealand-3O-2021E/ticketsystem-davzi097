using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;


namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class StorebæltsbroenTests
    {

        //test Storebæltsbroen discount
        [TestMethod()]
        public void StorebæltsbroenTest()
        {
            Car c1 = new Car();
            c1.Date = new DateTime(2021, 10, 2);
            var newprice = Storebæltsbroen.WeekendDiscount(c1);
            var expprice = 240 * 0.8;
            Assert.AreEqual(newprice, expprice);
        }

        //test Storebæltsbroen + Brobizz discount
        [TestMethod()]
        public void StorebæltsbroenAndBrobizzTest()
        {
            Car c1 = new Car();
            c1.Date = new DateTime(2021, 10, 2);
            c1.Brobizz = true;
            var newprice = Storebæltsbroen.WeekendDiscount(c1);
            var expprice = 240 * 0.8 * 0.95;
            Assert.AreEqual(newprice, expprice, 0.0001d);
        }
       
    }
}