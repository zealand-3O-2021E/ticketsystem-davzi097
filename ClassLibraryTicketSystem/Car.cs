using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    class Car
    {
        private string _licensePlate;
        private DateTime _date;

        public Car(string licensePlate, DateTime date)
        {
            _licensePlate = licensePlate;
            _date = date;
        }

        public string LicensePlate { get => _licensePlate; set => _licensePlate = value; }
        public DateTime Date { get => _date; set => _date = value; }

        public double Price()
        {
            return 240;
        }

        public string VehicleType()
        {
            return "Car";
        }
    }
}
