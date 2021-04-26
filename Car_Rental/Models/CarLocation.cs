using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Models
{
    public class CarLocation
    {
        [Key]
        public int ID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public int LocationID { get; set; }
        public Location Location { get; set; }
    }
}
