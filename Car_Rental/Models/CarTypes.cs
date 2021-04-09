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
        public int Type_ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Number_Passengers { get; set; }
        [Required]
        public int Number_Suitacases { get; set; }
        [Required]
        public int Number_Doors { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
