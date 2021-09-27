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
        [TestMethod()]
        public void PriceTest()
        {
            Car c1 = new Car();
            c1.Brobizz = true;
            Console.WriteLine(c1.Price());
        }

        [TestMethod()]
        public void VehichleTypeTest()
        {
            Vehicle C1 = new Car();
            Console.WriteLine(C1.VehichleType());
        }
    }
}