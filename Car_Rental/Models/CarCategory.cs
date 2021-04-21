using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental.Models
{
    public class CarCategory
    {
        [Key]
        [Required]
        [MinLength(3)]
        [Display(Name = "Category Name")]
        public string Category_Name { set; get; }

        [Required]
        [MinLength(5)]
        [Display(Name = "Picture Url")]
        public string ImgUrl { get; set; }

        [Required]
        [MinLength(10)]
        public string Details { get; set; }

        [NotMapped]
        [Display(Name = "Average Price")]
        public decimal AveragePrice { get; set; }
        [Required]
        [Display(Name = "Number of Cars")]
        public int NumberOfCars { get; set; }
        public ICollection<Car> Cars { get; set; }

        public CarCategory()
        {
            Cars = new HashSet<Car>();
        }
    }
}