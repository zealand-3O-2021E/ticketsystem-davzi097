using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    class Vehicle
    {
        private string _licensePlate;
        private DateTime _date;

        public Vehicle()
        {}

        public Vehicle(string licensePlate, DateTime date)
        {

            _date = date;
            if (licensePlate.Length > 7)
            
                throw new ArgumentOutOfRangeException("License is over 7 characters");
         
            else 
                
                _licensePlate = licensePlate;
        }

        public string LicensePlate { get => _licensePlate; set => _licensePlate = value; }
        public DateTime Date { get => _date; set => _date = value; }

        
       
	

	}
    
}
