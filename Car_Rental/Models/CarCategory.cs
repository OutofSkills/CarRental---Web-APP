using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental.Models
{
    public class CarCategory
    {
        [Key]
        public string Category_Name { set; get; }
        [Column(TypeName = "money")]
        [Required]
        public decimal Price_per_Day { get; set; }
        public string Details { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}