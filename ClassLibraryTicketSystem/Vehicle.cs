using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public abstract class Vehicle
    {
        private string licenseplate;
        public string Licenseplate
        {
            get { return licenseplate; }
            set
            {
                if (value.Length <= 7)
                {
                    licenseplate = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Lisense Plate it too long");
                }
            }
        }

        public bool Brobizz { get; set; }
        public DateTime Date { get; set; }
        public abstract double Price();
        public abstract string VehichleType();
        }

       

       
        
       
	

	}
    

