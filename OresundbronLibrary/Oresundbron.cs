using System;
using ClassLibraryTicketSystem;

namespace OresundbronLibrary
{
    public class Oresundbron
    {
        public static double CarPrice(Car c1)
        {
            
            if (c1.Brobizz == true)
            {
                return 161;
            }
            else
            {
                return 410;
            }
        }
        public static double MCPrice(MC mc1)
        {
            
            if (mc1.Brobizz == true)
            {
                return 73;
            }
            else
            {
                return 210;
            }
        }

        public static string VehicleType(Vehicle v1)
        {
             
            Car c1 = new Car();
            if (v1.VehichleType()==c1.VehichleType())
            {
                return "Oresund Car";
            }
            else
            {
                return "Oresund MC";
            }
        }

    }
}
