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
        [TestMethod()]
        public void CarTest()
        {
            Vehicle c1 = new Car();
            c1.Licenseplate = "1234567";
        }

        [TestMethod()]
        public void PriceTest()
        {
            Car c1 = new Car();
            Console.WriteLine(c1.Price());
        }

        [TestMethod()]
        public void VehichleTypeTest()
        {
            Vehicle mc1 = new MC();
            Console.WriteLine(mc1.VehichleType());
        }
    }
}