using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Car_Rental.Models
{
    public class Car
    {
        [Key]
        public int CarID { set; get; }
        [JsonIgnore]
        [Required]
        public string Model { get; set; }
        [JsonIgnore]
        [Required]
        [Display(Name = "Picture Url")]
        [MinLength(10)]
        public string PictureURL { get; set; }
        [JsonIgnore]
        [Required]
        [Display(Name = "Fuel Type")]
        public string FuelType { get; set; }
        [JsonIgnore]
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fabrication Date")]
        public DateTime Fabrication_Date { get; set; }
        [JsonIgnore]
        [Required]
        [Display(Name = "Price/Day")]
        public decimal PricePerDay { get; set; }
        [Display(Name = "Average Score")]
        public float AverageScore { get; set; }
        [JsonIgnore]
        public float Acceleration { get; set; }
        [JsonIgnore]
        [Required]
        [Display(Name = "Transmission Type")]
        public string TransmisionType { get; set; }
        [JsonIgnore]
        [Required]
        [Display(Name = "Climate Control")]
        public bool ClimateControll { get; set; }

        public int TypeID { get; set; }
        public string CategoryName { get; set; }

        [JsonIgnore]
        [ForeignKey("CategoryName")]
        public CarCategory Category { get; set; }
        [JsonIgnore]
        [ForeignKey("TypeID")]
        public CarTypes Type { get; set; }
        [JsonIgnore]
        public ICollection<CarLocation> CarLocations { get; set; }
        [JsonIgnore]
        public ICollection<Reservation> Reservations { get; set; }

        public Car()
        {
            CarLocations = new HashSet<CarLocation>();
            Reservations = new HashSet<Reservation>();
        }
    }
}