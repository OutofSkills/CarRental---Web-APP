using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Models
{
    public class BlackList
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Cauza { get; set; }
        [Required]
        public int Ban_Time { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}
