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
        [Required]
        public string Street { get; set; }
        [Required]
        [Display(Name = "Street Number")]
        public int Street_Number { get; set; }
        [Required]
        [Display(Name = "City Picture")]
        public string CityPicture { get; set; }

        public ICollection<CarLocation> CarsAtLocation { get; set; }

        public Location()
        {
            CarsAtLocation = new HashSet<CarLocation>();
        }
    }
}
