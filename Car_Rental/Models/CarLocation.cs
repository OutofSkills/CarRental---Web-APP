using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Models
{
    public class CarLocation
    {
        public int CarID { get; set; }
        public Car Car { get; set; }
        public int LocationID { get; set; }
        public Location Location { get; set; }
    }
}
