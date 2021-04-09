using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Models
{
    public class Address
    {
        [Key]
        public int Customer_ID { get; set; }
        [Required]
        public string County { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
        public int Street_Number { get; set; }
        public string Zip_Code { get; set; }

        public Customer Customer { get; set; }
    }
}
