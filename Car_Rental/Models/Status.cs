using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Models
{
    public class Status
    {
        [Key]
        public int Status_ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Details { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
