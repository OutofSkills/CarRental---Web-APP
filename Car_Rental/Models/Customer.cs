using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Car_Rental.Models
{
    public class Customer: IdentityUser<int>
    {
        [Key]
        public int CustomerID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public override string PhoneNumber { get; set; }

        public byte[] Image { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public override string Email { get; set; }

        [NotMapped]
        [MinLength(6, ErrorMessage = "The password's lenght should be at least 6.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public Role Role { get; set; }
        [ForeignKey("CustomerID")]
        public Address Address { get; set; }
        public BlackList BlackList { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
