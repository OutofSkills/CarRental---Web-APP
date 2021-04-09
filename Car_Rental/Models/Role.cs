using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Models
{
    public class Role
    {
        [Key]
        public int Role_ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Details { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}
