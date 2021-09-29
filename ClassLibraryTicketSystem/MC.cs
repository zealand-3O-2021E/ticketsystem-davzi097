using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC : Vehicle
    {

        public MC()
        {

        }

        public override double Price()
        {
            if (Brobizz)
            {
                return 125 * 0.95;
            }
            else
            {
                return 125;
            }
        }

        public override string VehichleType()
        {
            return "MC";
        }
    }
}
