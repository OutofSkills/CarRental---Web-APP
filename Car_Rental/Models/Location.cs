using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Models
{
    public class Location
    {
        [Key]
        public int Location_ID { get; set; }
        [Required]
        public string County { get; set; }
        [Required]
        public string City { get; set; }
        public string Street { get; set; }
        public int Street_Number { get; set; }
        public string CityPicture { get; set; }

        public ICollection<CarLocation> CarsAtLocation { get; set; }

        public Location()
        {
            CarsAtLocation = new HashSet<CarLocation>();
        }
    }
}
