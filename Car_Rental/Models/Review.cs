using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental.Models
{
    public class Review
    {
        public int ID { get; set; }

        [Required]
        public int Score { get; set; }
        public Reservation Reservation { get; set; }
    }
}
