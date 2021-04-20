using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Car_Rental.Models
{
    public class Customer
    {
        [Key]
        public int Customer_ID { get; set; }
        [Required]
        public string First_Name { get; set; }
        [Required]
        public string Second_Name { get; set; }
        public string Phone_Number { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        public Role Role { get; set; }
        [ForeignKey("Customer_ID")]
        public Address Address { get; set; }
        public BlackList BlackList { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
