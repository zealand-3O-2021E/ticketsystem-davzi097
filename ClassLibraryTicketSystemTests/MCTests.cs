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
        [TestMethod()]
        public void MCTest()
        {
            Vehicle mc1 = new MC();
            mc1.Licenseplate = "1234567";
        }

        [TestMethod()]
        public void PriceTest()
        {
            MC c1 = new MC();
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