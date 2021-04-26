using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Models
{
    public class CarTypes
    {
        [Key]
        public int TypeID { get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Number of Passengers")]
        public int Number_Passengers { get; set; }
        [Required]
        [Display(Name = "Number of Suitcases")]
        public int Number_Suitacases { get; set; }
        [Required]
        [Display(Name = "Number of Doors")]
        public int Number_Doors { get; set; }

        public ICollection<Car> Cars { get; set; }

        public CarTypes()
        {
            Cars = new HashSet<Car>();
        }
    }
}
