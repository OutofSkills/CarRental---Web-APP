using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Models
{
    public class Reservation
    {
        [Key]
        public int Reservation_ID { get; set; }
        [Required]
        public DateTime Start_Date { get; set; }
        [Required]
        public DateTime End_Date { get; set; }
        public int ReviewID { get; set; }

        public Customer Customer { get; set; }
        public  Car Car { get; set; }
        public Coupon Coupon { get; set; }
        public Status Status { get; set; }

        public Review Review { get; set; }
    }
}
