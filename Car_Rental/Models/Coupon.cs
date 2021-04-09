using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Models
{
    public class Coupon
    {
        [Key]
        public int Coupon_ID { get; set; }
        [Required]
        public float Discount { get; set; }
        [Required]
        public DateTime Expiration_Date { get; set; }
        public string Details { get; set; }

        public ICollection<Reservation> Reservaions { get; set; }
    }
}
