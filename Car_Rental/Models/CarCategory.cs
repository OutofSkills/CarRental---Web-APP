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
        public string ImgUrl { get; set; }
        public string Details { get; set; }
        [NotMapped]
        public decimal AveragePrice { get; set; }
        public int NumberOfCars { get; set; }
        public ICollection<Car> Cars { get; set; }

        public CarCategory()
        {
            Cars = new HashSet<Car>();
        }
    }
}