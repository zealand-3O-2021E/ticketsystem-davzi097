using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class Car : Vehicle
    {
        public Car()
        {

        }
        public override double Price()
        {
            if (Brobizz)
            {
                return 240 - (240 * 5 / 100);
            }
            else
            {
                return 240;
            }
        }

        public override string VehichleType()
        {
            return "Car";
        }

        

    }
}
