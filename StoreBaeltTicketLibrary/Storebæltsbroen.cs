using System;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary
{
    public class Storebæltsbroen
    {
        
        public static double WeekendDiscount(Car C1)
        {
            
            DateTime date = C1.Date;
            if (date.DayOfWeek==DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                return C1.Price() * 0.8;
            }
            else
            {
                return C1.Price();
            }
        }
    }
}
